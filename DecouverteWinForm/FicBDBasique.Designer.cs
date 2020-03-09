using System.ComponentModel;

namespace DecouverteWinForm
{
    partial class FicBDBasique
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
            this.listBoxConsole = new System.Windows.Forms.ListBox();
            this.buttonLecture = new System.Windows.Forms.Button();
            this.buttonCalcul = new System.Windows.Forms.Button();
            this.buttonInserer = new System.Windows.Forms.Button();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxConsole
            // 
            this.listBoxConsole.FormattingEnabled = true;
            this.listBoxConsole.Location = new System.Drawing.Point(10, 10);
            this.listBoxConsole.Name = "listBoxConsole";
            this.listBoxConsole.Size = new System.Drawing.Size(194, 186);
            this.listBoxConsole.TabIndex = 0;
            // 
            // buttonLecture
            // 
            this.buttonLecture.Location = new System.Drawing.Point(209, 10);
            this.buttonLecture.Name = "buttonLecture";
            this.buttonLecture.Size = new System.Drawing.Size(75, 35);
            this.buttonLecture.TabIndex = 1;
            this.buttonLecture.Text = "Lecture";
            this.buttonLecture.UseVisualStyleBackColor = true;
            this.buttonLecture.Click += new System.EventHandler(this.ButtonLecture_Click);
            // 
            // buttonCalcul
            // 
            this.buttonCalcul.Location = new System.Drawing.Point(209, 50);
            this.buttonCalcul.Name = "buttonCalcul";
            this.buttonCalcul.Size = new System.Drawing.Size(75, 35);
            this.buttonCalcul.TabIndex = 2;
            this.buttonCalcul.Text = "Calculer";
            this.buttonCalcul.UseVisualStyleBackColor = true;
            this.buttonCalcul.Click += new System.EventHandler(this.ButtonCalcul_Click);
            // 
            // buttonInserer
            // 
            this.buttonInserer.Location = new System.Drawing.Point(209, 161);
            this.buttonInserer.Name = "buttonInserer";
            this.buttonInserer.Size = new System.Drawing.Size(75, 35);
            this.buttonInserer.TabIndex = 3;
            this.buttonInserer.Text = "Insérer";
            this.buttonInserer.UseVisualStyleBackColor = true;
            this.buttonInserer.Click += new System.EventHandler(this.ButtonInserer_Click);
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(210, 136);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(86, 20);
            this.textBoxPrenom.TabIndex = 4;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(209, 111);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(86, 20);
            this.textBoxNom.TabIndex = 5;
            // 
            // FicBDBasique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 205);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.buttonInserer);
            this.Controls.Add(this.buttonCalcul);
            this.Controls.Add(this.buttonLecture);
            this.Controls.Add(this.listBoxConsole);
            this.Name = "FicBDBasique";
            this.Text = "FicBDBasique";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalcul;
        private System.Windows.Forms.Button buttonLecture;
        private System.Windows.Forms.ListBox listBoxConsole;
        private System.Windows.Forms.Button buttonInserer;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
    }
}