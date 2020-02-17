﻿using System.ComponentModel;

namespace DecouverteWinForm
{
    partial class FicPrincipal
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
            this.menuStripMenu = new System.Windows.Forms.MenuStrip();
            this.menuControle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuControleProgression = new System.Windows.Forms.ToolStripMenuItem();
            this.menuControleListe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuControleEditeur = new System.Windows.Forms.ToolStripMenuItem();
            this.menuControlesClavierSouris = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApplicationSpirographe = new System.Windows.Forms.ToolStripMenuItem();
            this.spirographeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApplicationsHorloge = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApplicationsSpinographe2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApplicationsNavigateur = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAPropos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAProposAPropos = new System.Windows.Forms.ToolStripMenuItem();
            this.boutonColore1 = new Bac2Q2Controles.BoutonColore();
            this.userControl11 = new Bac2Q2UserControlGraphique.UserControl1();
            this.menuStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userControl11)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMenu
            // 
            this.menuStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuControle,
            this.menuApplicationSpirographe,
            this.menuAPropos});
            this.menuStripMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMenu.Name = "menuStripMenu";
            this.menuStripMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStripMenu.Size = new System.Drawing.Size(524, 24);
            this.menuStripMenu.TabIndex = 0;
            this.menuStripMenu.Text = "menuStrip1";
            // 
            // menuControle
            // 
            this.menuControle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuControleProgression,
            this.menuControleListe,
            this.menuControleEditeur,
            this.menuControlesClavierSouris});
            this.menuControle.Name = "menuControle";
            this.menuControle.Size = new System.Drawing.Size(70, 20);
            this.menuControle.Text = "Contrôles";
            // 
            // menuControleProgression
            // 
            this.menuControleProgression.Name = "menuControleProgression";
            this.menuControleProgression.Size = new System.Drawing.Size(182, 22);
            this.menuControleProgression.Text = "Barre de progression";
            this.menuControleProgression.Click += new System.EventHandler(this.menuControleProgression_Click);
            // 
            // menuControleListe
            // 
            this.menuControleListe.Name = "menuControleListe";
            this.menuControleListe.Size = new System.Drawing.Size(182, 22);
            this.menuControleListe.Text = "Liste";
            this.menuControleListe.Click += new System.EventHandler(this.menuControleListe_Click);
            // 
            // menuControleEditeur
            // 
            this.menuControleEditeur.Name = "menuControleEditeur";
            this.menuControleEditeur.Size = new System.Drawing.Size(182, 22);
            this.menuControleEditeur.Text = "Editeur de texte";
            this.menuControleEditeur.Click += new System.EventHandler(this.menuControleEditeur_Click);
            // 
            // menuControlesClavierSouris
            // 
            this.menuControlesClavierSouris.Name = "menuControlesClavierSouris";
            this.menuControlesClavierSouris.Size = new System.Drawing.Size(182, 22);
            this.menuControlesClavierSouris.Text = "Clavier/Souris";
            this.menuControlesClavierSouris.Click += new System.EventHandler(this.menuControlesClavierSouris_Click);
            // 
            // menuApplicationSpirographe
            // 
            this.menuApplicationSpirographe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spirographeToolStripMenuItem,
            this.menuApplicationsHorloge,
            this.menuApplicationsSpinographe2,
            this.menuApplicationsNavigateur});
            this.menuApplicationSpirographe.Name = "menuApplicationSpirographe";
            this.menuApplicationSpirographe.Size = new System.Drawing.Size(85, 20);
            this.menuApplicationSpirographe.Text = "Applications";
            // 
            // spirographeToolStripMenuItem
            // 
            this.spirographeToolStripMenuItem.Name = "spirographeToolStripMenuItem";
            this.spirographeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.spirographeToolStripMenuItem.Text = "Spirographe";
            this.spirographeToolStripMenuItem.Click += new System.EventHandler(this.spirographeToolStripMenuItem_Click);
            // 
            // menuApplicationsHorloge
            // 
            this.menuApplicationsHorloge.Name = "menuApplicationsHorloge";
            this.menuApplicationsHorloge.Size = new System.Drawing.Size(138, 22);
            this.menuApplicationsHorloge.Text = "Horloge";
            this.menuApplicationsHorloge.Click += new System.EventHandler(this.menuApplicationsHorloge_Click);
            // 
            // menuApplicationsSpinographe2
            // 
            this.menuApplicationsSpinographe2.Name = "menuApplicationsSpinographe2";
            this.menuApplicationsSpinographe2.Size = new System.Drawing.Size(138, 22);
            this.menuApplicationsSpinographe2.Text = "Graphique";
            this.menuApplicationsSpinographe2.Click += new System.EventHandler(this.menuApplicationsSpinographe2_Click);
            // 
            // menuApplicationsNavigateur
            // 
            this.menuApplicationsNavigateur.Name = "menuApplicationsNavigateur";
            this.menuApplicationsNavigateur.Size = new System.Drawing.Size(138, 22);
            this.menuApplicationsNavigateur.Text = "Navigateur";
            this.menuApplicationsNavigateur.Click += new System.EventHandler(this.menuApplicationsNavigateur_Click);
            // 
            // menuAPropos
            // 
            this.menuAPropos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAProposAPropos});
            this.menuAPropos.Name = "menuAPropos";
            this.menuAPropos.Size = new System.Drawing.Size(67, 20);
            this.menuAPropos.Text = "A propos";
            // 
            // menuAProposAPropos
            // 
            this.menuAProposAPropos.Name = "menuAProposAPropos";
            this.menuAProposAPropos.Size = new System.Drawing.Size(122, 22);
            this.menuAProposAPropos.Text = "A propos";
            this.menuAProposAPropos.Click += new System.EventHandler(this.menuAProposAPropos_Click);
            // 
            // boutonColore1
            // 
            this.boutonColore1.CouleurDroite = System.Drawing.Color.DarkBlue;
            this.boutonColore1.CouleurGauche = System.Drawing.Color.LightGreen;
            this.boutonColore1.Location = new System.Drawing.Point(12, 27);
            this.boutonColore1.Name = "boutonColore1";
            this.boutonColore1.Size = new System.Drawing.Size(500, 62);
            this.boutonColore1.TabIndex = 1;
            this.boutonColore1.Text = "Bouton DLL";
            this.boutonColore1.TransparenceDroite = 64;
            this.boutonColore1.TransparenceGauche = 64;
            this.boutonColore1.UseVisualStyleBackColor = true;
            this.boutonColore1.Click += new System.EventHandler(this.BoutonColore1_Click);
            // 
            // userControl11
            // 
            this.userControl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControl11.Location = new System.Drawing.Point(31, 104);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(460, 293);
            this.userControl11.TabIndex = 2;
            this.userControl11.TabStop = false;
            // 
            // FicPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 419);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.boutonColore1);
            this.Controls.Add(this.menuStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStripMenu;
            this.Name = "FicPrincipal";
            this.Text = "Manipulations diverses";
            this.menuStripMenu.ResumeLayout(false);
            this.menuStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userControl11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMenu;
        private System.Windows.Forms.ToolStripMenuItem menuControle;
        private System.Windows.Forms.ToolStripMenuItem menuControleProgression;
        private System.Windows.Forms.ToolStripMenuItem menuAPropos;
        private System.Windows.Forms.ToolStripMenuItem menuControleListe;
        private System.Windows.Forms.ToolStripMenuItem menuControleEditeur;
        private System.Windows.Forms.ToolStripMenuItem menuAProposAPropos;
        private System.Windows.Forms.ToolStripMenuItem spirographeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuApplicationSpirographe;
        private System.Windows.Forms.ToolStripMenuItem menuApplicationsHorloge;
        private System.Windows.Forms.ToolStripMenuItem menuApplicationsSpinographe2;
        private System.Windows.Forms.ToolStripMenuItem menuControlesClavierSouris;
        private System.Windows.Forms.ToolStripMenuItem menuApplicationsNavigateur;
        private Bac2Q2Controles.BoutonColore boutonColore1;
        private Bac2Q2UserControlGraphique.UserControl1 userControl11;
    }
}