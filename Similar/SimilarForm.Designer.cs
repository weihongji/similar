namespace Similar
{
	partial class SimilarForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimilarForm));
			this.panelTop = new System.Windows.Forms.Panel();
			this.labelDescription = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.statusLengthLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusLength = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusPositionLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusPosition = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusCharLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusChar = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusCodeLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusCode = new System.Windows.Forms.ToolStripStatusLabel();
			this.panelButtons = new System.Windows.Forms.Panel();
			this.chkCase = new System.Windows.Forms.CheckBox();
			this.panelButtonsInner = new System.Windows.Forms.Panel();
			this.btnRestore = new System.Windows.Forms.Button();
			this.contextMenuRestore = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuClean = new System.Windows.Forms.ToolStripMenuItem();
			this.btnCompress = new System.Windows.Forms.Button();
			this.btnLocate = new System.Windows.Forms.Button();
			this.panelText = new System.Windows.Forms.Panel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnUp = new System.Windows.Forms.Button();
			this.txtUp = new ScintillaNET.Scintilla();
			this.btnDown = new System.Windows.Forms.Button();
			this.txtDown = new ScintillaNET.Scintilla();
			this.panelTop.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.panelButtons.SuspendLayout();
			this.panelButtonsInner.SuspendLayout();
			this.contextMenuRestore.SuspendLayout();
			this.panelText.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelTop
			// 
			this.panelTop.Controls.Add(this.labelDescription);
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(0, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(664, 35);
			this.panelTop.TabIndex = 0;
			// 
			// labelDescription
			// 
			this.labelDescription.AutoSize = true;
			this.labelDescription.Location = new System.Drawing.Point(3, 10);
			this.labelDescription.Name = "labelDescription";
			this.labelDescription.Size = new System.Drawing.Size(240, 13);
			this.labelDescription.TabIndex = 0;
			this.labelDescription.Text = "Compare two text blocks and show the difference";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLengthLabel,
            this.statusLength,
            this.statusPositionLabel,
            this.statusPosition,
            this.statusCharLabel,
            this.statusChar,
            this.statusCodeLabel,
            this.statusCode});
			this.statusStrip1.Location = new System.Drawing.Point(0, 135);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(664, 26);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusBar";
			// 
			// statusLengthLabel
			// 
			this.statusLengthLabel.Name = "statusLengthLabel";
			this.statusLengthLabel.Size = new System.Drawing.Size(47, 21);
			this.statusLengthLabel.Text = "Length:";
			// 
			// statusLength
			// 
			this.statusLength.AutoSize = false;
			this.statusLength.Name = "statusLength";
			this.statusLength.Size = new System.Drawing.Size(180, 21);
			this.statusLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// statusPositionLabel
			// 
			this.statusPositionLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.statusPositionLabel.Name = "statusPositionLabel";
			this.statusPositionLabel.Size = new System.Drawing.Size(73, 21);
			this.statusPositionLabel.Text = "Position #1:";
			// 
			// statusPosition
			// 
			this.statusPosition.AutoSize = false;
			this.statusPosition.Name = "statusPosition";
			this.statusPosition.Size = new System.Drawing.Size(120, 21);
			this.statusPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// statusCharLabel
			// 
			this.statusCharLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.statusCharLabel.Name = "statusCharLabel";
			this.statusCharLabel.Size = new System.Drawing.Size(39, 21);
			this.statusCharLabel.Text = "Char:";
			// 
			// statusChar
			// 
			this.statusChar.AutoSize = false;
			this.statusChar.Name = "statusChar";
			this.statusChar.Size = new System.Drawing.Size(60, 21);
			this.statusChar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// statusCodeLabel
			// 
			this.statusCodeLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.statusCodeLabel.Name = "statusCodeLabel";
			this.statusCodeLabel.Size = new System.Drawing.Size(42, 21);
			this.statusCodeLabel.Text = "ASCII:";
			// 
			// statusCode
			// 
			this.statusCode.AutoSize = false;
			this.statusCode.Name = "statusCode";
			this.statusCode.Size = new System.Drawing.Size(60, 21);
			this.statusCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panelButtons
			// 
			this.panelButtons.Controls.Add(this.chkCase);
			this.panelButtons.Controls.Add(this.panelButtonsInner);
			this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelButtons.Location = new System.Drawing.Point(0, 102);
			this.panelButtons.Name = "panelButtons";
			this.panelButtons.Size = new System.Drawing.Size(664, 33);
			this.panelButtons.TabIndex = 2;
			// 
			// chkCase
			// 
			this.chkCase.AutoSize = true;
			this.chkCase.Checked = true;
			this.chkCase.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkCase.Location = new System.Drawing.Point(71, 7);
			this.chkCase.Name = "chkCase";
			this.chkCase.Size = new System.Drawing.Size(94, 17);
			this.chkCase.TabIndex = 0;
			this.chkCase.TabStop = false;
			this.chkCase.Text = "&Case sensitive";
			this.chkCase.UseVisualStyleBackColor = true;
			this.chkCase.Click += new System.EventHandler(this.chkCase_Click);
			// 
			// panelButtonsInner
			// 
			this.panelButtonsInner.Controls.Add(this.btnRestore);
			this.panelButtonsInner.Controls.Add(this.btnCompress);
			this.panelButtonsInner.Controls.Add(this.btnLocate);
			this.panelButtonsInner.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelButtonsInner.Location = new System.Drawing.Point(354, 0);
			this.panelButtonsInner.Name = "panelButtonsInner";
			this.panelButtonsInner.Size = new System.Drawing.Size(310, 33);
			this.panelButtonsInner.TabIndex = 0;
			// 
			// btnRestore
			// 
			this.btnRestore.ContextMenuStrip = this.contextMenuRestore;
			this.btnRestore.Location = new System.Drawing.Point(236, 2);
			this.btnRestore.Name = "btnRestore";
			this.btnRestore.Size = new System.Drawing.Size(64, 27);
			this.btnRestore.TabIndex = 2;
			this.btnRestore.TabStop = false;
			this.btnRestore.Text = "&Restore";
			this.btnRestore.UseVisualStyleBackColor = true;
			this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
			// 
			// contextMenuRestore
			// 
			this.contextMenuRestore.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClean});
			this.contextMenuRestore.Name = "contextMenuRestore";
			this.contextMenuRestore.Size = new System.Drawing.Size(105, 26);
			this.contextMenuRestore.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuRestore_Opening);
			// 
			// menuClean
			// 
			this.menuClean.Name = "menuClean";
			this.menuClean.Size = new System.Drawing.Size(104, 22);
			this.menuClean.Text = "&Clean";
			this.menuClean.Click += new System.EventHandler(this.menuClean_Click);
			// 
			// btnCompress
			// 
			this.btnCompress.Location = new System.Drawing.Point(134, 2);
			this.btnCompress.Name = "btnCompress";
			this.btnCompress.Size = new System.Drawing.Size(64, 27);
			this.btnCompress.TabIndex = 1;
			this.btnCompress.TabStop = false;
			this.btnCompress.Text = "Com&press";
			this.btnCompress.UseVisualStyleBackColor = true;
			this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
			// 
			// btnLocate
			// 
			this.btnLocate.Location = new System.Drawing.Point(32, 2);
			this.btnLocate.Name = "btnLocate";
			this.btnLocate.Size = new System.Drawing.Size(64, 27);
			this.btnLocate.TabIndex = 0;
			this.btnLocate.TabStop = false;
			this.btnLocate.Text = "&Locate";
			this.btnLocate.UseVisualStyleBackColor = true;
			this.btnLocate.Click += new System.EventHandler(this.btnLocate_Click);
			// 
			// panelText
			// 
			this.panelText.Controls.Add(this.tableLayoutPanel1);
			this.panelText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelText.Location = new System.Drawing.Point(0, 35);
			this.panelText.Name = "panelText";
			this.panelText.Size = new System.Drawing.Size(664, 67);
			this.panelText.TabIndex = 1;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.btnUp, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtUp, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnDown, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtDown, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(664, 67);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// btnUp
			// 
			this.btnUp.Location = new System.Drawing.Point(3, 3);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new System.Drawing.Size(64, 25);
			this.btnUp.TabIndex = 0;
			this.btnUp.TabStop = false;
			this.btnUp.Text = "Paste &1";
			this.btnUp.UseVisualStyleBackColor = true;
			this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
			// 
			// txtUp
			// 
			this.txtUp.AutoCMaxHeight = 9;
			this.txtUp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtUp.HScrollBar = false;
			this.txtUp.Location = new System.Drawing.Point(73, 3);
			this.txtUp.Name = "txtUp";
			this.txtUp.Size = new System.Drawing.Size(588, 27);
			this.txtUp.TabIndex = 1;
			this.txtUp.TabWidth = 8;
			this.txtUp.UseTabs = true;
			this.txtUp.WrapMode = ScintillaNET.WrapMode.Word;
			this.txtUp.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			this.txtUp.Click += new System.EventHandler(this.TextBox_Click);
			this.txtUp.Enter += new System.EventHandler(this.TextBox_Enter);
			this.txtUp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
			this.txtUp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
			// 
			// btnDown
			// 
			this.btnDown.Location = new System.Drawing.Point(3, 36);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new System.Drawing.Size(64, 25);
			this.btnDown.TabIndex = 2;
			this.btnDown.TabStop = false;
			this.btnDown.Text = "Paste &2";
			this.btnDown.UseVisualStyleBackColor = true;
			this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
			// 
			// txtDown
			// 
			this.txtDown.AutoCMaxHeight = 9;
			this.txtDown.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtDown.HScrollBar = false;
			this.txtDown.Location = new System.Drawing.Point(73, 36);
			this.txtDown.Name = "txtDown";
			this.txtDown.Size = new System.Drawing.Size(588, 28);
			this.txtDown.TabIndex = 3;
			this.txtDown.TabWidth = 8;
			this.txtDown.UseTabs = true;
			this.txtDown.WrapMode = ScintillaNET.WrapMode.Word;
			this.txtDown.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			this.txtDown.Click += new System.EventHandler(this.TextBox_Click);
			this.txtDown.Enter += new System.EventHandler(this.TextBox_Enter);
			this.txtDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
			this.txtDown.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
			// 
			// SimilarForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(664, 161);
			this.Controls.Add(this.panelText);
			this.Controls.Add(this.panelButtons);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.panelTop);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "SimilarForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Similar";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SimilarForm_FormClosing);
			this.Load += new System.EventHandler(this.SimilarForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SimilarForm_KeyDown);
			this.Resize += new System.EventHandler(this.SimilarForm_Resize);
			this.panelTop.ResumeLayout(false);
			this.panelTop.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.panelButtons.ResumeLayout(false);
			this.panelButtons.PerformLayout();
			this.panelButtonsInner.ResumeLayout(false);
			this.contextMenuRestore.ResumeLayout(false);
			this.panelText.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panelTop;
		private System.Windows.Forms.CheckBox chkCase;
		private System.Windows.Forms.Label labelDescription;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.Panel panelButtons;
		private System.Windows.Forms.Panel panelText;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnUp;
		private System.Windows.Forms.Panel panelButtonsInner;
		private System.Windows.Forms.Button btnRestore;
		private System.Windows.Forms.Button btnCompress;
		private System.Windows.Forms.Button btnLocate;
		private ScintillaNET.Scintilla txtUp;
		private System.Windows.Forms.Button btnDown;
		private ScintillaNET.Scintilla txtDown;
		private System.Windows.Forms.ToolStripStatusLabel statusLengthLabel;
		private System.Windows.Forms.ToolStripStatusLabel statusLength;
		private System.Windows.Forms.ToolStripStatusLabel statusPositionLabel;
		private System.Windows.Forms.ToolStripStatusLabel statusPosition;
		private System.Windows.Forms.ToolStripStatusLabel statusCharLabel;
		private System.Windows.Forms.ToolStripStatusLabel statusChar;
		private System.Windows.Forms.ToolStripStatusLabel statusCodeLabel;
		private System.Windows.Forms.ToolStripStatusLabel statusCode;
		private System.Windows.Forms.ContextMenuStrip contextMenuRestore;
		private System.Windows.Forms.ToolStripMenuItem menuClean;
	}
}

