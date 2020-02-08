using System.ComponentModel;

namespace DecouverteWinForm
{
    partial class FicProgression
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
            this.progressBarPrincipal = new System.Windows.Forms.ProgressBar();
            this.labelPrincipal = new System.Windows.Forms.Label();
            this.labelSecondaire = new System.Windows.Forms.Label();
            this.progressBarSecondaire = new System.Windows.Forms.ProgressBar();
            this.buttonExecuter = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBarPrincipal
            // 
            this.progressBarPrincipal.Location = new System.Drawing.Point(12, 35);
            this.progressBarPrincipal.Name = "progressBarPrincipal";
            this.progressBarPrincipal.Size = new System.Drawing.Size(229, 52);
            this.progressBarPrincipal.Step = 1;
            this.progressBarPrincipal.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarPrincipal.TabIndex = 0;
            // 
            // labelPrincipal
            // 
            this.labelPrincipal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelPrincipal.ForeColor = System.Drawing.Color.Maroon;
            this.labelPrincipal.Location = new System.Drawing.Point(12, 9);
            this.labelPrincipal.Name = "labelPrincipal";
            this.labelPrincipal.Size = new System.Drawing.Size(100, 23);
            this.labelPrincipal.TabIndex = 1;
            this.labelPrincipal.Text = "Copie (global)";
            // 
            // labelSecondaire
            // 
            this.labelSecondaire.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelSecondaire.ForeColor = System.Drawing.Color.Maroon;
            this.labelSecondaire.Location = new System.Drawing.Point(12, 105);
            this.labelSecondaire.Name = "labelSecondaire";
            this.labelSecondaire.Size = new System.Drawing.Size(100, 23);
            this.labelSecondaire.TabIndex = 3;
            this.labelSecondaire.Text = "Copie (fichier)";
            // 
            // progressBarSecondaire
            // 
            this.progressBarSecondaire.Location = new System.Drawing.Point(12, 132);
            this.progressBarSecondaire.Name = "progressBarSecondaire";
            this.progressBarSecondaire.Size = new System.Drawing.Size(229, 52);
            this.progressBarSecondaire.Step = 20;
            this.progressBarSecondaire.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarSecondaire.TabIndex = 2;
            // 
            // buttonExecuter
            // 
            this.buttonExecuter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonExecuter.ForeColor = System.Drawing.Color.Maroon;
            this.buttonExecuter.Location = new System.Drawing.Point(12, 200);
            this.buttonExecuter.Name = "buttonExecuter";
            this.buttonExecuter.Size = new System.Drawing.Size(87, 42);
            this.buttonExecuter.TabIndex = 4;
            this.buttonExecuter.Text = "Exécuter";
            this.buttonExecuter.UseVisualStyleBackColor = true;
            this.buttonExecuter.Click += new System.EventHandler(this.buttonExecuter_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonQuitter.ForeColor = System.Drawing.Color.Maroon;
            this.buttonQuitter.Location = new System.Drawing.Point(160, 200);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(80, 42);
            this.buttonQuitter.TabIndex = 5;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // FicProgression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 253);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonExecuter);
            this.Controls.Add(this.labelSecondaire);
            this.Controls.Add(this.progressBarSecondaire);
            this.Controls.Add(this.labelPrincipal);
            this.Controls.Add(this.progressBarPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FicProgression";
            this.Text = "Barre de progression";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label labelPrincipal;
        private System.Windows.Forms.ProgressBar progressBarPrincipal;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.Button buttonExecuter;
        private System.Windows.Forms.ProgressBar progressBarSecondaire;
        private System.Windows.Forms.Label labelSecondaire;
    }
}