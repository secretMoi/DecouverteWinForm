using System.ComponentModel;

namespace DecouverteWinForm
{
    partial class FicClavierSouris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.listBoxClavier = new System.Windows.Forms.ListBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.panelZoneSouris = new System.Windows.Forms.Panel();
            this.labelGauche = new System.Windows.Forms.Label();
            this.textBoxGauche = new System.Windows.Forms.TextBox();
            this.textBoxDroit = new System.Windows.Forms.TextBox();
            this.labelDroit = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.labelY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxClavier
            // 
            this.listBoxClavier.FormattingEnabled = true;
            this.listBoxClavier.ItemHeight = 15;
            this.listBoxClavier.Location = new System.Drawing.Point(12, 12);
            this.listBoxClavier.Name = "listBoxClavier";
            this.listBoxClavier.Size = new System.Drawing.Size(156, 199);
            this.listBoxClavier.TabIndex = 0;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(12, 226);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(93, 226);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(75, 23);
            this.buttonQuitter.TabIndex = 2;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // panelZoneSouris
            // 
            this.panelZoneSouris.Location = new System.Drawing.Point(174, 65);
            this.panelZoneSouris.Name = "panelZoneSouris";
            this.panelZoneSouris.Size = new System.Drawing.Size(298, 184);
            this.panelZoneSouris.TabIndex = 3;
            // 
            // labelGauche
            // 
            this.labelGauche.Location = new System.Drawing.Point(174, 12);
            this.labelGauche.Name = "labelGauche";
            this.labelGauche.Size = new System.Drawing.Size(69, 23);
            this.labelGauche.TabIndex = 4;
            this.labelGauche.Text = "Clic gauche";
            // 
            // textBoxGauche
            // 
            this.textBoxGauche.Location = new System.Drawing.Point(174, 36);
            this.textBoxGauche.Name = "textBoxGauche";
            this.textBoxGauche.Size = new System.Drawing.Size(69, 23);
            this.textBoxGauche.TabIndex = 5;
            // 
            // textBoxDroit
            // 
            this.textBoxDroit.Location = new System.Drawing.Point(249, 36);
            this.textBoxDroit.Name = "textBoxDroit";
            this.textBoxDroit.Size = new System.Drawing.Size(69, 23);
            this.textBoxDroit.TabIndex = 7;
            // 
            // labelDroit
            // 
            this.labelDroit.Location = new System.Drawing.Point(249, 12);
            this.labelDroit.Name = "labelDroit";
            this.labelDroit.Size = new System.Drawing.Size(69, 23);
            this.labelDroit.TabIndex = 6;
            this.labelDroit.Text = "Clic droit";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(324, 36);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(69, 23);
            this.textBoxX.TabIndex = 9;
            // 
            // labelX
            // 
            this.labelX.Location = new System.Drawing.Point(324, 12);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(69, 23);
            this.labelX.TabIndex = 8;
            this.labelX.Text = "Position X";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(403, 36);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(69, 23);
            this.textBoxY.TabIndex = 11;
            // 
            // labelY
            // 
            this.labelY.Location = new System.Drawing.Point(403, 12);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(69, 23);
            this.labelY.TabIndex = 10;
            this.labelY.Text = "Position Y";
            // 
            // FicClavierSouris
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.textBoxDroit);
            this.Controls.Add(this.labelDroit);
            this.Controls.Add(this.textBoxGauche);
            this.Controls.Add(this.labelGauche);
            this.Controls.Add(this.panelZoneSouris);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.listBoxClavier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FicClavierSouris";
            this.Text = "FicClavierSouris";
            this.Load += new System.EventHandler(this.FicClavierSouris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label labelDroit;
        private System.Windows.Forms.TextBox textBoxDroit;
        private System.Windows.Forms.TextBox textBoxGauche;
        private System.Windows.Forms.Label labelGauche;
        private System.Windows.Forms.Panel panelZoneSouris;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ListBox listBoxClavier;
    }
}