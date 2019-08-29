using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Similar
{
	public partial class SimilarForm : Form
	{
		private readonly string BUTTON_COMPRESS = "Com&press";
		private readonly string BUTTON_EXPAND = "Ex&pand";

		private readonly int KEYVALUE_PLUS = 187;
		private readonly int KEYVALUE_MINUS = 189;

		private readonly int FORM_HEIGHT_MIN = 185;
		private readonly int AUTO_EXPAND_MAX = 9;

		private string text1 = "";
		private string text2 = "";

		private bool clipboardCleaned = false;
		private TextBox tbox2Locate = null;

		public SimilarForm() {
			InitializeComponent();
		}

		#region "Form Events"
		private void SimilarForm_Load(object sender, EventArgs e) {
			ShowLengthStatus();
			ShowPositionStatus();

			tbox2Locate = txtUp;
		}

		private void SimilarForm_FormClosing(object sender, FormClosingEventArgs e) {
			if (this.clipboardCleaned && string.IsNullOrEmpty(Clipboard.GetText())) {
				var result = MessageBox.Show("Windows clipboard has been cleaned. Continue exiting the program?", this.Text, MessageBoxButtons.OKCancel);
				if (result == DialogResult.Cancel) {
					e.Cancel = true;
				}
			}
		}

		private void SimilarForm_Resize(object sender, EventArgs e) {
			if (this.TopMost && this.WindowState == FormWindowState.Maximized) { // Don't always be on top when maximized.
				this.TopMost = false;
			}
			else if (!this.TopMost && this.WindowState == FormWindowState.Normal) {
				this.TopMost = true;
			}
		}

		private void SimilarForm_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Escape) { // ESC
				this.WindowState = FormWindowState.Minimized;
			}
			else if (e.KeyCode == Keys.X && e.Alt) { // ALT + "X"
				e.Handled = e.SuppressKeyPress = true;
				Application.Exit();
			}
			else if (e.Control && e.KeyValue == KEYVALUE_MINUS) { // CTRL + "-"
				ResizeForm(0, -60);
			}
			else if (e.Control && e.KeyValue == KEYVALUE_PLUS) { // CTRL + "+"
				ResizeForm(0, 60);
			}
			else if (e.Control && e.KeyValue == '0') { // CTRL + 1
				ResizeForm(FORM_HEIGHT_MIN);
			}
			else if (e.Control && e.KeyValue == '9') { // CTRL + 9
				this.WindowState = this.WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
			}
		}

		#endregion

		#region "Text Boxes"
		private void btnUp_Click(object sender, EventArgs e) {
			PasteText(txtUp);
			IncreaseHeight();
		}

		private void btnDown_Click(object sender, EventArgs e) {
			PasteText(txtDown);
			IncreaseHeight();
		}

		private void TextBox_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.A && e.Control) {
				SelectAllText((TextBox)sender);
				e.Handled = e.SuppressKeyPress = true;
			}
		}

		private void TextBox_KeyUp(object sender, KeyEventArgs e) {
			ShowPositionStatus();
		}

		private void TextBox_TextChanged(object sender, EventArgs e) {
			ShowLengthStatus();
			ShowPositionStatus();
		}

		private void TextBox_Click(object sender, EventArgs e) {
			this.tbox2Locate = (TextBox)sender;
			ShowPositionStatus();
		}

		private void TextBox_Enter(object sender, EventArgs e) {
			this.tbox2Locate = (TextBox)sender;
		}
		#endregion

		#region "Location Buttons"
		private void btnLocate_Click(object sender, EventArgs e) {
			// Just in case. This button should be disabled when the two texts are same.
			if (txtUp.Text.Equals(txtDown.Text)) {
				return;
			}

			// Save existing text for later restore
			if (String.IsNullOrEmpty(text1) && txtUp.Text.Length > 0) {
				text1 = txtUp.Text;
			}
			if (String.IsNullOrEmpty(text2) && txtDown.Text.Length > 0) {
				text2 = txtDown.Text;
			}

			// Get position of the first difference
			char[] s1 = txtUp.Text.ToCharArray();
			char[] s2 = txtDown.Text.ToCharArray();
			int len1 = s1.Length;
			int len2 = s2.Length;
			int lenMin = Math.Min(len1, len2);
			int index = -1;
			for (int i = 0; i < lenMin; i++) {
				if (s1[i] != s2[i]) {
					index = i;
					break;
				}
			}
			if (index < 0 && len1 != len2) {
				index = lenMin;
			}

			// Show the different character
			if (index < 0) { // Should never happen
				return;
			}
			var tbox = this.tbox2Locate;
			SelectDifferentChar(tbox, index);
			ShowPositionStatus();
			this.tbox2Locate = this.tbox2Locate == txtUp ? txtDown : txtUp;
		}

		private void btnCompress_Click(object sender, EventArgs e) {
			if (btnCompress.Text.Equals(BUTTON_COMPRESS)) {
				// Save existing text for later restore
				if (String.IsNullOrEmpty(text1) && txtUp.Text.Length > 0) {
					text1 = txtUp.Text;
				}
				if (String.IsNullOrEmpty(text2) && txtDown.Text.Length > 0) {
					text2 = txtDown.Text;
				}

				txtUp.Text = CompressText(txtUp.Text);
				txtDown.Text = CompressText(txtDown.Text);

				btnCompress.Text = BUTTON_EXPAND;
			}
			else { // Expand
				txtUp.Text = ExpandText(txtUp.Text);
				txtDown.Text = ExpandText(txtDown.Text);

				this.btnCompress.Text = BUTTON_COMPRESS;
			}
		}

		private void btnRestore_Click(object sender, EventArgs e) {
			var restored = false;
			if (text1.Length > 0) {
				txtUp.Text = text1;
				restored = true;
			}
			if (text2.Length > 0) {
				txtDown.Text = text2;
				restored = true;
			}
			if (restored) {
				this.btnCompress.Text = BUTTON_COMPRESS;
			}
		}

		private void contextMenuRestore_Opening(object sender, CancelEventArgs e) {
			if (String.IsNullOrEmpty(text1 + text2) && menuClean.Enabled) {
				menuClean.Enabled = false;
			}
			else if ((text1 + text2).Length > 0 && !menuClean.Enabled) {
				menuClean.Enabled = true;
			}
		}

		private void menuClean_Click(object sender, EventArgs e) {
			text1 = text2 = "";
		}

		private void chkCase_Click(object sender, EventArgs e) {
			ShowLengthStatus();
		}
		#endregion

		private void ResizeForm(int height, int increase = 0) {
			if (this.WindowState != FormWindowState.Normal) {
				return;
			}

			int newHeight = 0;
			if (height > 0) {
				newHeight = height;
			}
			else {
				newHeight = this.Height + increase;
			}

			if (newHeight <= FORM_HEIGHT_MIN) {
				newHeight = FORM_HEIGHT_MIN;
			}
			if (this.Height != newHeight) {
				this.Height = newHeight;
			}
		}

		private void PasteText(TextBox textbox) {
			textbox.Text = Clipboard.GetText();
			Clipboard.Clear();
			if (textbox.Text.Length > 0) {
				this.clipboardCleaned = true;
			}
		}

		private void IncreaseHeight() {
			int lines = txtUp.Text.Count<char>(x => x == '\n') + 1;
			int requiredLines = Math.Min(lines, AUTO_EXPAND_MAX);
			int requiredHeight = FORM_HEIGHT_MIN + (requiredLines - 1) * 30;
			if (this.Height < requiredHeight) {
				ResizeForm(requiredHeight);
			}
		}

		private void SelectAllText(TextBox tbox) {
			tbox.SelectAll();
		}

		private TextBox GetActiveTextBox(bool forceOne = true) {
			TextBox tbox = null;
			if (this.ActiveControl != null && this.ActiveControl.GetType() == typeof(TextBox)) {
				tbox = (TextBox)this.ActiveControl;
			}
			if (tbox == null && forceOne) {
				tbox = txtUp;
			}
			return tbox;
		}

		private string CompressText(string s) {
			if (String.IsNullOrWhiteSpace(s)) {
				return string.Empty;
			}
			s = s.Replace('\n', '|');
			s = Regex.Replace(s, @"\s*\|\s*", "|"); // Removing blank characters like space, tab or \r.
			s = Regex.Replace(s, @"\|{2,}", "|"); // Shrink multiple "|" to one.
			s = Regex.Replace(s, @"\s+", " "); // Shrink multiple blank characters to one space (32).
			return s;
		}

		private string ExpandText(string s) {
			if (String.IsNullOrWhiteSpace(s)) {
				return string.Empty;
			}
			s = s.Replace("|", "\r\n"); // Replace all vertical bars to new lines. No matter they are generated by compressing or exist in original text.
			return s;
		}

		private void ShowLengthStatus() {
			var s1 = txtUp.Text;
			var s2 = txtDown.Text;
			var same = s1.Equals(s2, chkCase.Checked ? StringComparison.CurrentCulture : StringComparison.CurrentCultureIgnoreCase);

			// Status bar
			var lengthText = "";
			if (same) {
				lengthText = String.Format("{0} - Identical", FormatNumber(s1.Length));
			}
			else if (s1.Length == s2.Length) {
				lengthText = String.Format("{0} - Different", FormatNumber(s1.Length));
			}
			else {
				lengthText = String.Format("{0} {2} {1}", FormatNumber(s1.Length), FormatNumber(s2.Length), s1.Length > s2.Length ? ">" : "<");
			}
			statusLength.Text = lengthText;

			// Locate button
			if (same && btnLocate.Enabled) {
				btnLocate.Enabled = false;
			}
			else if (!same && !btnLocate.Enabled) {
				btnLocate.Enabled = true;
			}
		}

		private void ShowPositionStatus() {
			var tbox = GetActiveTextBox();
			var index = tbox.SelectionStart;
			var length = tbox.Text.Length;
			if (length > 0) {
				if (tbox.SelectionLength > 0) {
					index++;
				}
				statusPosition.Text = String.Format("{0} / {1}", FormatNumber(index), tbox.Text.Length);
			}
			else {
				statusPosition.Text = "0";
			}
			statusPositionLabel.Text = String.Format("Position #{0}: ", tbox.Name.IndexOf("Up") > 0 ? "1" : "2");
		}

		private void ShowCharStatus(string c) {
			string charText = "";
			switch (c) {
				case "":
					charText = "to end";
					break;
				case "\t":
					charText = "Tab";
					break;
				case "\r":
					charText = @"\r";
					break;
				case "\n":
					charText = @"\n";
					break;
				case " ":
					charText = "Space";
					break;
				default:
					charText = c;
					break;
			}
			statusChar.Text = charText;
			int code = String.IsNullOrEmpty(c) ? 0 : (int)c[0];
			string hex = code.ToString("X");
			statusCode.Text = String.Format("{0} (x{1})", code, hex.PadLeft(2, '0'));
		}

		private void SelectDifferentChar(TextBox tbox, int index) {
			tbox.Focus();
			if (index < tbox.Text.Length) {
				tbox.Select(index, 1);
			}
			else {
				tbox.Select(index, 0);
			}
			ShowCharStatus(tbox.SelectedText);
		}

		private string FormatNumber(int n) {
			return n.ToString("#,0");
		}
	}
}
