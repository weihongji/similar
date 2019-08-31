namespace Similar
{
	partial class ScintillaForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScintillaForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox1 = new ScintillaNET.Scintilla();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.statusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBox2 = new System.Windows.Forms.RichTextBox();
			this.panel1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(534, 295);
			this.panel1.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.AutoCMaxHeight = 9;
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.HScrollBar = false;
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(534, 295);
			this.textBox1.TabIndex = 0;
			this.textBox1.TabWidth = 8;
			this.textBox1.Text = resources.GetString("textBox1.Text");
			this.textBox1.UseTabs = true;
			this.textBox1.WrapMode = ScintillaNET.WrapMode.Word;
			this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
			this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 395);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(534, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "test";
			// 
			// statusLabel1
			// 
			this.statusLabel1.Name = "statusLabel1";
			this.statusLabel1.Size = new System.Drawing.Size(26, 17);
			this.statusLabel1.Text = "test";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(12, 8);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(100, 17);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "Tab stop on me";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.textBox2);
			this.panel2.Controls.Add(this.checkBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 295);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(534, 100);
			this.panel2.TabIndex = 3;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(210, 6);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(206, 72);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "I\'m a build-in RichTextBox.";
			// 
			// ScintillaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 417);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.statusStrip1);
			this.Name = "ScintillaForm";
			this.Text = "Scintilla Form";
			this.Load += new System.EventHandler(this.ScintillaForm_Load);
			this.panel1.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private ScintillaNET.Scintilla textBox1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel statusLabel1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.RichTextBox textBox2;
	}
}