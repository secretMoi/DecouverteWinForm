using System.ComponentModel;

namespace DecouverteWinForm
{
    partial class FicListe
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
            this.labelFichier = new System.Windows.Forms.Label();
            this.listBoxPersonnes = new System.Windows.Forms.ListBox();
            this.buttonOuvrir = new System.Windows.Forms.Button();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.buttonConfirmer = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.comboBoxQualite = new System.Windows.Forms.ComboBox();
            this.labelQualite = new System.Windows.Forms.Label();
            this.buttonSauver = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.panelDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFichier
            // 
            this.labelFichier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelFichier.Location = new System.Drawing.Point(35, 9);
            this.labelFichier.Name = "labelFichier";
            this.labelFichier.Size = new System.Drawing.Size(131, 23);
            this.labelFichier.TabIndex = 0;
            this.labelFichier.Text = "Nom du fichier";
            // 
            // listBoxPersonnes
            // 
            this.listBoxPersonnes.FormattingEnabled = true;
            this.listBoxPersonnes.ItemHeight = 15;
            this.listBoxPersonnes.Location = new System.Drawing.Point(12, 47);
            this.listBoxPersonnes.Name = "listBoxPersonnes";
            this.listBoxPersonnes.Size = new System.Drawing.Size(189, 169);
            this.listBoxPersonnes.Sorted = true;
            this.listBoxPersonnes.TabIndex = 1;
            this.listBoxPersonnes.DoubleClick += new System.EventHandler(this.listBoxPersonnes_DoubleClick);
            // 
            // buttonOuvrir
            // 
            this.buttonOuvrir.Location = new System.Drawing.Point(12, 222);
            this.buttonOuvrir.Name = "buttonOuvrir";
            this.buttonOuvrir.Size = new System.Drawing.Size(100, 40);
            this.buttonOuvrir.TabIndex = 2;
            this.buttonOuvrir.Text = "Ouvrir";
            this.buttonOuvrir.UseVisualStyleBackColor = true;
            this.buttonOuvrir.Click += new System.EventHandler(this.buttonOuvrir_Click);
            // 
            // panelDetails
            // 
            this.panelDetails.Controls.Add(this.buttonConfirmer);
            this.panelDetails.Controls.Add(this.buttonAnnuler);
            this.panelDetails.Controls.Add(this.textBoxNom);
            this.panelDetails.Controls.Add(this.labelNom);
            this.panelDetails.Controls.Add(this.comboBoxQualite);
            this.panelDetails.Controls.Add(this.labelQualite);
            this.panelDetails.Location = new System.Drawing.Point(218, 9);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(225, 201);
            this.panelDetails.TabIndex = 3;
            // 
            // buttonConfirmer
            // 
            this.buttonConfirmer.Location = new System.Drawing.Point(3, 153);
            this.buttonConfirmer.Name = "buttonConfirmer";
            this.buttonConfirmer.Size = new System.Drawing.Size(100, 40);
            this.buttonConfirmer.TabIndex = 7;
            this.buttonConfirmer.Text = "Confirmer";
            this.buttonConfirmer.UseVisualStyleBackColor = true;
            this.buttonConfirmer.Click += new System.EventHandler(this.buttonConfirmer_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(122, 153);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(100, 40);
            this.buttonAnnuler.TabIndex = 6;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(3, 111);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(210, 23);
            this.textBoxNom.TabIndex = 4;
            // 
            // labelNom
            // 
            this.labelNom.Location = new System.Drawing.Point(3, 76);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(100, 23);
            this.labelNom.TabIndex = 3;
            this.labelNom.Text = "Nom";
            // 
            // comboBoxQualite
            // 
            this.comboBoxQualite.FormattingEnabled = true;
            this.comboBoxQualite.Items.AddRange(new object[] {"Madame", "Monsieur", "Mademoiselle"});
            this.comboBoxQualite.Location = new System.Drawing.Point(3, 36);
            this.comboBoxQualite.Name = "comboBoxQualite";
            this.comboBoxQualite.Size = new System.Drawing.Size(210, 23);
            this.comboBoxQualite.TabIndex = 2;
            // 
            // labelQualite
            // 
            this.labelQualite.Location = new System.Drawing.Point(3, 10);
            this.labelQualite.Name = "labelQualite";
            this.labelQualite.Size = new System.Drawing.Size(100, 23);
            this.labelQualite.TabIndex = 1;
            this.labelQualite.Text = "Qualite";
            // 
            // buttonSauver
            // 
            this.buttonSauver.Location = new System.Drawing.Point(12, 268);
            this.buttonSauver.Name = "buttonSauver";
            this.buttonSauver.Size = new System.Drawing.Size(100, 40);
            this.buttonSauver.TabIndex = 4;
            this.buttonSauver.Text = "Sauver";
            this.buttonSauver.UseVisualStyleBackColor = true;
            this.buttonSauver.Click += new System.EventHandler(this.buttonSauver_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(118, 222);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(100, 40);
            this.buttonAjouter.TabIndex = 5;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(118, 268);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(100, 40);
            this.buttonSupprimer.TabIndex = 6;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // FicListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 317);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.buttonSauver);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.buttonOuvrir);
            this.Controls.Add(this.listBoxPersonnes);
            this.Controls.Add(this.labelFichier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FicListe";
            this.Text = "FicListe";
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonSauver;
        private System.Windows.Forms.Button buttonOuvrir;
        private System.Windows.Forms.ListBox listBoxPersonnes;
        private System.Windows.Forms.Label labelFichier;
        private System.Windows.Forms.Label labelQualite;
        private System.Windows.Forms.ComboBox comboBoxQualite;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonConfirmer;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.TextBox textBoxNom;
    }
}