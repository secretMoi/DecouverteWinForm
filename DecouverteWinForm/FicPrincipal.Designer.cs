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
            this.menuControle_Progression = new System.Windows.Forms.ToolStripMenuItem();
            this.menuControle_Liste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuControle_Editeur = new System.Windows.Forms.ToolStripMenuItem();
            this.menuControles_ClavierSouris = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApplication_Spirographe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApplications_Horloge = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApplications_Spirographe2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuApplications_Navigateur = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAPropos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAPropos_APropos = new System.Windows.Forms.ToolStripMenuItem();
            this.boutonColore1 = new Bac2Q2Controles.BoutonColore();
            this.userControl11 = new Bac2Q2UserControlGraphique.UserControl1();
            this.listViewPoints = new System.Windows.Forms.ListView();
            this.columnHeaderNom = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderTaille = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDateCreation = new System.Windows.Forms.ColumnHeader();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.menuStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.userControl11)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMenu
            // 
            this.menuStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.menuControle, this.menuApplication, this.menuAPropos});
            this.menuStripMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripMenu.Name = "menuStripMenu";
            this.menuStripMenu.Size = new System.Drawing.Size(763, 24);
            this.menuStripMenu.TabIndex = 0;
            this.menuStripMenu.Text = "menuStrip1";
            // 
            // menuControle
            // 
            this.menuControle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.menuControle_Progression, this.menuControle_Liste, this.menuControle_Editeur,
                this.menuControles_ClavierSouris
            });
            this.menuControle.Name = "menuControle";
            this.menuControle.Size = new System.Drawing.Size(70, 20);
            this.menuControle.Text = "Contrôles";
            // 
            // menuControle_Progression
            // 
            this.menuControle_Progression.Name = "menuControle_Progression";
            this.menuControle_Progression.Size = new System.Drawing.Size(182, 22);
            this.menuControle_Progression.Text = "Barre de progression";
            this.menuControle_Progression.Click += new System.EventHandler(this.evenement_Click);
            // 
            // menuControle_Liste
            // 
            this.menuControle_Liste.Name = "menuControle_Liste";
            this.menuControle_Liste.Size = new System.Drawing.Size(182, 22);
            this.menuControle_Liste.Text = "Liste";
            this.menuControle_Liste.Click += new System.EventHandler(this.evenement_Click);
            // 
            // menuControle_Editeur
            // 
            this.menuControle_Editeur.Name = "menuControle_Editeur";
            this.menuControle_Editeur.Size = new System.Drawing.Size(182, 22);
            this.menuControle_Editeur.Text = "Editeur de texte";
            this.menuControle_Editeur.Click += new System.EventHandler(this.evenement_Click);
            // 
            // menuControles_ClavierSouris
            // 
            this.menuControles_ClavierSouris.Name = "menuControles_ClavierSouris";
            this.menuControles_ClavierSouris.Size = new System.Drawing.Size(182, 22);
            this.menuControles_ClavierSouris.Text = "Clavier/Souris";
            this.menuControles_ClavierSouris.Click += new System.EventHandler(this.evenement_Click);
            // 
            // menuApplication
            // 
            this.menuApplication.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.menuApplication_Spirographe, this.menuApplications_Horloge, this.menuApplications_Spirographe2,
                this.menuApplications_Navigateur
            });
            this.menuApplication.Name = "menuApplication";
            this.menuApplication.Size = new System.Drawing.Size(85, 20);
            this.menuApplication.Text = "Applications";
            // 
            // menuApplication_Spirographe
            // 
            this.menuApplication_Spirographe.Name = "menuApplication_Spirographe";
            this.menuApplication_Spirographe.Size = new System.Drawing.Size(152, 22);
            this.menuApplication_Spirographe.Text = "Spirographe";
            this.menuApplication_Spirographe.Click += new System.EventHandler(this.evenement_Click);
            // 
            // menuApplications_Horloge
            // 
            this.menuApplications_Horloge.Name = "menuApplications_Horloge";
            this.menuApplications_Horloge.Size = new System.Drawing.Size(152, 22);
            this.menuApplications_Horloge.Text = "Horloge";
            this.menuApplications_Horloge.Click += new System.EventHandler(this.evenement_Click);
            // 
            // menuApplications_Spirographe2
            // 
            this.menuApplications_Spirographe2.Name = "menuApplications_Spirographe2";
            this.menuApplications_Spirographe2.Size = new System.Drawing.Size(152, 22);
            this.menuApplications_Spirographe2.Text = "Graphique";
            this.menuApplications_Spirographe2.Click += new System.EventHandler(this.evenement_Click);
            // 
            // menuApplications_Navigateur
            // 
            this.menuApplications_Navigateur.Name = "menuApplications_Navigateur";
            this.menuApplications_Navigateur.Size = new System.Drawing.Size(152, 22);
            this.menuApplications_Navigateur.Text = "Navigateur";
            this.menuApplications_Navigateur.Click += new System.EventHandler(this.evenement_Click);
            // 
            // menuAPropos
            // 
            this.menuAPropos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.menuAPropos_APropos});
            this.menuAPropos.Name = "menuAPropos";
            this.menuAPropos.Size = new System.Drawing.Size(67, 20);
            this.menuAPropos.Text = "A propos";
            // 
            // menuAPropos_APropos
            // 
            this.menuAPropos_APropos.Name = "menuAPropos_APropos";
            this.menuAPropos_APropos.Size = new System.Drawing.Size(152, 22);
            this.menuAPropos_APropos.Text = "A propos";
            this.menuAPropos_APropos.Click += new System.EventHandler(this.evenement_Click);
            // 
            // boutonColore1
            // 
            this.boutonColore1.CouleurDroite = System.Drawing.Color.DarkBlue;
            this.boutonColore1.CouleurGauche = System.Drawing.Color.LightGreen;
            this.boutonColore1.Location = new System.Drawing.Point(14, 31);
            this.boutonColore1.Name = "boutonColore1";
            this.boutonColore1.Size = new System.Drawing.Size(745, 72);
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
            this.userControl11.Location = new System.Drawing.Point(14, 108);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(536, 338);
            this.userControl11.TabIndex = 2;
            this.userControl11.TabStop = false;
            // 
            // listViewPoints
            // 
            this.listViewPoints.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
                {this.columnHeaderNom, this.columnHeaderTaille, this.columnHeaderDateCreation});
            this.listViewPoints.FullRowSelect = true;
            this.listViewPoints.HideSelection = false;
            this.listViewPoints.Location = new System.Drawing.Point(556, 108);
            this.listViewPoints.Name = "listViewPoints";
            this.listViewPoints.Size = new System.Drawing.Size(203, 337);
            this.listViewPoints.TabIndex = 3;
            this.listViewPoints.UseCompatibleStateImageBehavior = false;
            this.listViewPoints.View = System.Windows.Forms.View.Details;
            this.listViewPoints.ItemSelectionChanged +=
                new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this
                    .listViewPoints_ItemSelectionChanged);
            // 
            // columnHeaderNom
            // 
            this.columnHeaderNom.Text = "Nom";
            this.columnHeaderNom.Width = 72;
            // 
            // columnHeaderTaille
            // 
            this.columnHeaderTaille.Text = "X";
            // 
            // columnHeaderDateCreation
            // 
            this.columnHeaderDateCreation.Text = "Y";
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(556, 453);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(98, 33);
            this.buttonAjouter.TabIndex = 4;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(490, 460);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(60, 23);
            this.textBoxX.TabIndex = 5;
            // 
            // labelX
            // 
            this.labelX.Location = new System.Drawing.Point(463, 460);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(21, 23);
            this.labelX.TabIndex = 6;
            this.labelX.Text = "X : ";
            // 
            // labelY
            // 
            this.labelY.Location = new System.Drawing.Point(463, 489);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(21, 23);
            this.labelY.TabIndex = 8;
            this.labelY.Text = "Y : ";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(490, 489);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(60, 23);
            this.textBoxY.TabIndex = 7;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(661, 453);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(98, 33);
            this.buttonSupprimer.TabIndex = 9;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // FicPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 523);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.listViewPoints);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.boutonColore1);
            this.Controls.Add(this.menuStripMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStripMenu;
            this.Name = "FicPrincipal";
            this.Text = "Manipulations diverses";
            this.menuStripMenu.ResumeLayout(false);
            this.menuStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.userControl11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMenu;
        private System.Windows.Forms.ToolStripMenuItem menuControle;
        private System.Windows.Forms.ToolStripMenuItem menuAPropos;
        private Bac2Q2Controles.BoutonColore boutonColore1;
        private Bac2Q2UserControlGraphique.UserControl1 userControl11;
        private System.Windows.Forms.ColumnHeader columnHeaderDateCreation;
        private System.Windows.Forms.ColumnHeader columnHeaderTaille;
        private System.Windows.Forms.ColumnHeader columnHeaderNom;
        private System.Windows.Forms.ListView listViewPoints;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.ToolStripMenuItem menuAPropos_APropos;
        private System.Windows.Forms.ToolStripMenuItem menuApplications_Navigateur;
        private System.Windows.Forms.ToolStripMenuItem menuApplications_Horloge;
        private System.Windows.Forms.ToolStripMenuItem menuApplication;
        private System.Windows.Forms.ToolStripMenuItem menuApplication_Spirographe;
        private System.Windows.Forms.ToolStripMenuItem menuApplications_Spirographe2;
        private System.Windows.Forms.ToolStripMenuItem menuControles_ClavierSouris;
        private System.Windows.Forms.ToolStripMenuItem menuControle_Editeur;
        private System.Windows.Forms.ToolStripMenuItem menuControle_Liste;
        private System.Windows.Forms.ToolStripMenuItem menuControle_Progression;
    }
}