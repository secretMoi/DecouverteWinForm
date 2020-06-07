namespace DecouverteWinForm
{
	partial class FicRegex
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FicRegex));
			this.labelRegex = new System.Windows.Forms.Label();
			this.textBoxRegex = new System.Windows.Forms.TextBox();
			this.checkBoxIsValid = new System.Windows.Forms.CheckBox();
			this.checkBoxCorrespondance = new System.Windows.Forms.CheckBox();
			this.checkBoxCasse = new System.Windows.Forms.CheckBox();
			this.checkBoxRemplacer = new System.Windows.Forms.CheckBox();
			this.checkBoxSeparer = new System.Windows.Forms.CheckBox();
			this.textBoxRemplacement = new System.Windows.Forms.TextBox();
			this.labelRemplacement = new System.Windows.Forms.Label();
			this.labelATraiter = new System.Windows.Forms.Label();
			this.richTextBoxATraiter = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// labelRegex
			// 
			this.labelRegex.AutoSize = true;
			this.labelRegex.Location = new System.Drawing.Point(12, 9);
			this.labelRegex.Name = "labelRegex";
			this.labelRegex.Size = new System.Drawing.Size(38, 13);
			this.labelRegex.TabIndex = 0;
			this.labelRegex.Text = "Regex";
			// 
			// textBoxRegex
			// 
			this.textBoxRegex.Location = new System.Drawing.Point(12, 25);
			this.textBoxRegex.Name = "textBoxRegex";
			this.textBoxRegex.Size = new System.Drawing.Size(776, 20);
			this.textBoxRegex.TabIndex = 1;
			this.textBoxRegex.Text = "\\b[1-9][0-9]*\\b";
			this.textBoxRegex.TextChanged += new System.EventHandler(this.textBoxRegex_TextChanged);
			// 
			// checkBoxIsValid
			// 
			this.checkBoxIsValid.AutoSize = true;
			this.checkBoxIsValid.Enabled = false;
			this.checkBoxIsValid.Location = new System.Drawing.Point(12, 51);
			this.checkBoxIsValid.Name = "checkBoxIsValid";
			this.checkBoxIsValid.Size = new System.Drawing.Size(60, 17);
			this.checkBoxIsValid.TabIndex = 2;
			this.checkBoxIsValid.Text = "Validité";
			this.checkBoxIsValid.UseVisualStyleBackColor = true;
			// 
			// checkBoxCorrespondance
			// 
			this.checkBoxCorrespondance.AutoSize = true;
			this.checkBoxCorrespondance.Enabled = false;
			this.checkBoxCorrespondance.Location = new System.Drawing.Point(171, 51);
			this.checkBoxCorrespondance.Name = "checkBoxCorrespondance";
			this.checkBoxCorrespondance.Size = new System.Drawing.Size(108, 17);
			this.checkBoxCorrespondance.TabIndex = 3;
			this.checkBoxCorrespondance.Text = "Correspondanses";
			this.checkBoxCorrespondance.UseVisualStyleBackColor = true;
			// 
			// checkBoxCasse
			// 
			this.checkBoxCasse.AutoSize = true;
			this.checkBoxCasse.Location = new System.Drawing.Point(378, 51);
			this.checkBoxCasse.Name = "checkBoxCasse";
			this.checkBoxCasse.Size = new System.Drawing.Size(55, 17);
			this.checkBoxCasse.TabIndex = 4;
			this.checkBoxCasse.Text = "Casse";
			this.checkBoxCasse.UseVisualStyleBackColor = true;
			this.checkBoxCasse.CheckedChanged += new System.EventHandler(this.checkBoxCasse_CheckedChanged);
			// 
			// checkBoxRemplacer
			// 
			this.checkBoxRemplacer.AutoSize = true;
			this.checkBoxRemplacer.Location = new System.Drawing.Point(532, 51);
			this.checkBoxRemplacer.Name = "checkBoxRemplacer";
			this.checkBoxRemplacer.Size = new System.Drawing.Size(77, 17);
			this.checkBoxRemplacer.TabIndex = 5;
			this.checkBoxRemplacer.Text = "Remplacer";
			this.checkBoxRemplacer.UseVisualStyleBackColor = true;
			this.checkBoxRemplacer.CheckedChanged += new System.EventHandler(this.checkBoxRemplacer_CheckedChanged);
			// 
			// checkBoxSeparer
			// 
			this.checkBoxSeparer.AutoSize = true;
			this.checkBoxSeparer.Location = new System.Drawing.Point(708, 51);
			this.checkBoxSeparer.Name = "checkBoxSeparer";
			this.checkBoxSeparer.Size = new System.Drawing.Size(63, 17);
			this.checkBoxSeparer.TabIndex = 6;
			this.checkBoxSeparer.Text = "Séparer";
			this.checkBoxSeparer.UseVisualStyleBackColor = true;
			this.checkBoxSeparer.CheckedChanged += new System.EventHandler(this.checkBoxSeparer_CheckedChanged);
			// 
			// textBoxRemplacement
			// 
			this.textBoxRemplacement.Location = new System.Drawing.Point(12, 111);
			this.textBoxRemplacement.Name = "textBoxRemplacement";
			this.textBoxRemplacement.Size = new System.Drawing.Size(776, 20);
			this.textBoxRemplacement.TabIndex = 8;
			// 
			// labelRemplacement
			// 
			this.labelRemplacement.AutoSize = true;
			this.labelRemplacement.Location = new System.Drawing.Point(12, 95);
			this.labelRemplacement.Name = "labelRemplacement";
			this.labelRemplacement.Size = new System.Drawing.Size(118, 13);
			this.labelRemplacement.TabIndex = 7;
			this.labelRemplacement.Text = "Texte de remplacement";
			// 
			// labelATraiter
			// 
			this.labelATraiter.AutoSize = true;
			this.labelATraiter.Location = new System.Drawing.Point(12, 159);
			this.labelATraiter.Name = "labelATraiter";
			this.labelATraiter.Size = new System.Drawing.Size(72, 13);
			this.labelATraiter.TabIndex = 9;
			this.labelATraiter.Text = "Texte à traiter";
			// 
			// richTextBoxATraiter
			// 
			this.richTextBoxATraiter.Location = new System.Drawing.Point(12, 175);
			this.richTextBoxATraiter.Name = "richTextBoxATraiter";
			this.richTextBoxATraiter.Size = new System.Drawing.Size(776, 401);
			this.richTextBoxATraiter.TabIndex = 10;
			this.richTextBoxATraiter.Text = resources.GetString("richTextBoxATraiter.Text");
			this.richTextBoxATraiter.Leave += new System.EventHandler(this.richTextBoxATraiter_Leave);
			// 
			// FicRegex
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 588);
			this.Controls.Add(this.richTextBoxATraiter);
			this.Controls.Add(this.labelATraiter);
			this.Controls.Add(this.textBoxRemplacement);
			this.Controls.Add(this.labelRemplacement);
			this.Controls.Add(this.checkBoxSeparer);
			this.Controls.Add(this.checkBoxRemplacer);
			this.Controls.Add(this.checkBoxCasse);
			this.Controls.Add(this.checkBoxCorrespondance);
			this.Controls.Add(this.checkBoxIsValid);
			this.Controls.Add(this.textBoxRegex);
			this.Controls.Add(this.labelRegex);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FicRegex";
			this.Text = "Regex";
			this.Load += new System.EventHandler(this.FicRegex_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelRegex;
		private System.Windows.Forms.TextBox textBoxRegex;
		private System.Windows.Forms.CheckBox checkBoxIsValid;
		private System.Windows.Forms.CheckBox checkBoxCorrespondance;
		private System.Windows.Forms.CheckBox checkBoxCasse;
		private System.Windows.Forms.CheckBox checkBoxRemplacer;
		private System.Windows.Forms.CheckBox checkBoxSeparer;
		private System.Windows.Forms.TextBox textBoxRemplacement;
		private System.Windows.Forms.Label labelRemplacement;
		private System.Windows.Forms.Label labelATraiter;
		private System.Windows.Forms.RichTextBox richTextBoxATraiter;
	}
}