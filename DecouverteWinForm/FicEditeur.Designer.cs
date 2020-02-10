using System.ComponentModel;
using DecouverteWinForm.core;

namespace DecouverteWinForm
{
    partial class FicEditeur
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(FicEditeur));
            this.menuStripCommande = new System.Windows.Forms.MenuStrip();
            this.menuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFichierNouveau = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFichierOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFichierEnregistrer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFichierQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditerCopier = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditerCouper = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditerColler = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormater = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormaterJustifier = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormaterJustifierGauche = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormaterJustifierDroite = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormaterJustifierCentre = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormaterCaractere = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormaterCaractereGras = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormaterCaractereItalique = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormaterCaractereSouligne = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormaterCaractereBarre = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormaterPolice = new System.Windows.Forms.ToolStripMenuItem();
            this.panelCommande = new System.Windows.Forms.Panel();
            this.pictureBoxQuitter = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnregistrer = new System.Windows.Forms.PictureBox();
            this.pictureBoxOuvrir = new System.Windows.Forms.PictureBox();
            this.pictureBoxNouveau = new System.Windows.Forms.PictureBox();
            this.richTextBoxTexte = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.menuStripCommande.SuspendLayout();
            this.panelCommande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxQuitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxEnregistrer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxOuvrir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxNouveau)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripCommande
            // 
            this.menuStripCommande.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.menuFichier, this.mEditer, this.menuFormater});
            this.menuStripCommande.Location = new System.Drawing.Point(0, 0);
            this.menuStripCommande.Name = "menuStripCommande";
            this.menuStripCommande.Size = new System.Drawing.Size(933, 24);
            this.menuStripCommande.TabIndex = 0;
            this.menuStripCommande.Text = "menuStrip1";
            // 
            // menuFichier
            // 
            this.menuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.menuFichierNouveau, this.toolStripMenuItem1, this.menuFichierOuvrir, this.menuFichierEnregistrer,
                this.toolStripMenuItem2, this.menuFichierQuitter
            });
            this.menuFichier.Name = "menuFichier";
            this.menuFichier.Size = new System.Drawing.Size(54, 20);
            this.menuFichier.Text = "Fichier";
            // 
            // menuFichierNouveau
            // 
            this.menuFichierNouveau.Name = "menuFichierNouveau";
            this.menuFichierNouveau.Size = new System.Drawing.Size(130, 22);
            this.menuFichierNouveau.Text = "Nouveau";
            this.menuFichierNouveau.Click += new System.EventHandler(this.menuFichierNouveau_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(127, 6);
            // 
            // menuFichierOuvrir
            // 
            this.menuFichierOuvrir.Name = "menuFichierOuvrir";
            this.menuFichierOuvrir.Size = new System.Drawing.Size(130, 22);
            this.menuFichierOuvrir.Text = "Ouvrir";
            this.menuFichierOuvrir.Click += new System.EventHandler(this.menuFichierOuvrir_Click);
            // 
            // menuFichierEnregistrer
            // 
            this.menuFichierEnregistrer.Name = "menuFichierEnregistrer";
            this.menuFichierEnregistrer.Size = new System.Drawing.Size(130, 22);
            this.menuFichierEnregistrer.Text = "Enregistrer";
            this.menuFichierEnregistrer.Click += new System.EventHandler(this.menuFichierEnregistrer_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(127, 6);
            // 
            // menuFichierQuitter
            // 
            this.menuFichierQuitter.Name = "menuFichierQuitter";
            this.menuFichierQuitter.Size = new System.Drawing.Size(130, 22);
            this.menuFichierQuitter.Text = "Quitter";
            this.menuFichierQuitter.Click += new System.EventHandler(this.menuFichierQuitter_Click);
            // 
            // mEditer
            // 
            this.mEditer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.menuEditerCopier, this.menuEditerCouper, this.menuEditerColler});
            this.mEditer.Name = "mEditer";
            this.mEditer.Size = new System.Drawing.Size(49, 20);
            this.mEditer.Text = "Editer";
            // 
            // menuEditerCopier
            // 
            this.menuEditerCopier.Name = "menuEditerCopier";
            this.menuEditerCopier.Size = new System.Drawing.Size(113, 22);
            this.menuEditerCopier.Text = "Copier";
            this.menuEditerCopier.Click += new System.EventHandler(this.menuEditerCopier_Click);
            // 
            // menuEditerCouper
            // 
            this.menuEditerCouper.Name = "menuEditerCouper";
            this.menuEditerCouper.Size = new System.Drawing.Size(113, 22);
            this.menuEditerCouper.Text = "Couper";
            this.menuEditerCouper.Click += new System.EventHandler(this.menuEditerCouper_Click);
            // 
            // menuEditerColler
            // 
            this.menuEditerColler.Name = "menuEditerColler";
            this.menuEditerColler.Size = new System.Drawing.Size(113, 22);
            this.menuEditerColler.Text = "Coller";
            this.menuEditerColler.Click += new System.EventHandler(this.menuEditerColler_Click);
            // 
            // menuFormater
            // 
            this.menuFormater.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.menuFormaterJustifier, this.menuFormaterCaractere, this.menuFormaterPolice});
            this.menuFormater.Name = "menuFormater";
            this.menuFormater.Size = new System.Drawing.Size(67, 20);
            this.menuFormater.Text = "Formater";
            // 
            // menuFormaterJustifier
            // 
            this.menuFormaterJustifier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.menuFormaterJustifierGauche, this.menuFormaterJustifierDroite, this.menuFormaterJustifierCentre});
            this.menuFormaterJustifier.Name = "menuFormaterJustifier";
            this.menuFormaterJustifier.Size = new System.Drawing.Size(124, 22);
            this.menuFormaterJustifier.Text = "Justifier";
            // 
            // menuFormaterJustifierGauche
            // 
            this.menuFormaterJustifierGauche.Name = "menuFormaterJustifierGauche";
            this.menuFormaterJustifierGauche.Size = new System.Drawing.Size(114, 22);
            this.menuFormaterJustifierGauche.Text = "Gauche";
            this.menuFormaterJustifierGauche.Click += new System.EventHandler(this.menuFormaterJustifierGauche_Click);
            // 
            // menuFormaterJustifierDroite
            // 
            this.menuFormaterJustifierDroite.Name = "menuFormaterJustifierDroite";
            this.menuFormaterJustifierDroite.Size = new System.Drawing.Size(114, 22);
            this.menuFormaterJustifierDroite.Text = "Droite";
            this.menuFormaterJustifierDroite.Click += new System.EventHandler(this.menuFormaterJustifierDroite_Click);
            // 
            // menuFormaterJustifierCentre
            // 
            this.menuFormaterJustifierCentre.Name = "menuFormaterJustifierCentre";
            this.menuFormaterJustifierCentre.Size = new System.Drawing.Size(114, 22);
            this.menuFormaterJustifierCentre.Text = "Centré";
            this.menuFormaterJustifierCentre.Click += new System.EventHandler(this.menuFormaterJustifierCentre_Click);
            // 
            // menuFormaterCaractere
            // 
            this.menuFormaterCaractere.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.menuFormaterCaractereGras, this.menuFormaterCaractereItalique, this.menuFormaterCaractereSouligne,
                this.menuFormaterCaractereBarre
            });
            this.menuFormaterCaractere.Name = "menuFormaterCaractere";
            this.menuFormaterCaractere.Size = new System.Drawing.Size(124, 22);
            this.menuFormaterCaractere.Text = "Caractère";
            // 
            // menuFormaterCaractereGras
            // 
            this.menuFormaterCaractereGras.Name = "menuFormaterCaractereGras";
            this.menuFormaterCaractereGras.Size = new System.Drawing.Size(120, 22);
            this.menuFormaterCaractereGras.Text = "Gras";
            this.menuFormaterCaractereGras.Click += new System.EventHandler(this.menuFormaterCaractereGras_Click);
            // 
            // menuFormaterCaractereItalique
            // 
            this.menuFormaterCaractereItalique.Name = "menuFormaterCaractereItalique";
            this.menuFormaterCaractereItalique.Size = new System.Drawing.Size(120, 22);
            this.menuFormaterCaractereItalique.Text = "Italique";
            this.menuFormaterCaractereItalique.Click += new System.EventHandler(this.menuFormaterPoliceItalique_Click);
            // 
            // menuFormaterCaractereSouligne
            // 
            this.menuFormaterCaractereSouligne.Name = "menuFormaterCaractereSouligne";
            this.menuFormaterCaractereSouligne.Size = new System.Drawing.Size(120, 22);
            this.menuFormaterCaractereSouligne.Text = "Souligné";
            this.menuFormaterCaractereSouligne.Click +=
                new System.EventHandler(this.menuFormaterCaractereSouligne_Click);
            // 
            // menuFormaterCaractereBarre
            // 
            this.menuFormaterCaractereBarre.Name = "menuFormaterCaractereBarre";
            this.menuFormaterCaractereBarre.Size = new System.Drawing.Size(120, 22);
            this.menuFormaterCaractereBarre.Text = "Barré";
            this.menuFormaterCaractereBarre.Click += new System.EventHandler(this.menuFormaterCaractereBarre_Click);
            // 
            // menuFormaterPolice
            // 
            this.menuFormaterPolice.Name = "menuFormaterPolice";
            this.menuFormaterPolice.Size = new System.Drawing.Size(124, 22);
            this.menuFormaterPolice.Text = "Police";
            this.menuFormaterPolice.Click += new System.EventHandler(this.menuFormaterPolice_Click);
            // 
            // panelCommande
            // 
            this.panelCommande.Controls.Add(this.pictureBoxQuitter);
            this.panelCommande.Controls.Add(this.pictureBoxEnregistrer);
            this.panelCommande.Controls.Add(this.pictureBoxOuvrir);
            this.panelCommande.Controls.Add(this.pictureBoxNouveau);
            this.panelCommande.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCommande.Location = new System.Drawing.Point(0, 24);
            this.panelCommande.Name = "panelCommande";
            this.panelCommande.Size = new System.Drawing.Size(933, 32);
            this.panelCommande.TabIndex = 1;
            // 
            // pictureBoxQuitter
            // 
            this.pictureBoxQuitter.Image = ((System.Drawing.Image) (resources.GetObject("pictureBoxQuitter.Image")));
            this.pictureBoxQuitter.Location = new System.Drawing.Point(101, 3);
            this.pictureBoxQuitter.Name = "pictureBoxQuitter";
            this.pictureBoxQuitter.Size = new System.Drawing.Size(27, 27);
            this.pictureBoxQuitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQuitter.TabIndex = 3;
            this.pictureBoxQuitter.TabStop = false;
            this.pictureBoxQuitter.Click += new System.EventHandler(this.menuFichierQuitter_Click);
            // 
            // pictureBoxEnregistrer
            // 
            this.pictureBoxEnregistrer.Image =
                ((System.Drawing.Image) (resources.GetObject("pictureBoxEnregistrer.Image")));
            this.pictureBoxEnregistrer.Location = new System.Drawing.Point(69, 3);
            this.pictureBoxEnregistrer.Name = "pictureBoxEnregistrer";
            this.pictureBoxEnregistrer.Size = new System.Drawing.Size(27, 27);
            this.pictureBoxEnregistrer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEnregistrer.TabIndex = 2;
            this.pictureBoxEnregistrer.TabStop = false;
            this.pictureBoxEnregistrer.Click += new System.EventHandler(this.menuFichierEnregistrer_Click);
            // 
            // pictureBoxOuvrir
            // 
            this.pictureBoxOuvrir.Image = ((System.Drawing.Image) (resources.GetObject("pictureBoxOuvrir.Image")));
            this.pictureBoxOuvrir.Location = new System.Drawing.Point(36, 3);
            this.pictureBoxOuvrir.Name = "pictureBoxOuvrir";
            this.pictureBoxOuvrir.Size = new System.Drawing.Size(27, 27);
            this.pictureBoxOuvrir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOuvrir.TabIndex = 1;
            this.pictureBoxOuvrir.TabStop = false;
            this.pictureBoxOuvrir.Click += new System.EventHandler(this.menuFichierOuvrir_Click);
            // 
            // pictureBoxNouveau
            // 
            this.pictureBoxNouveau.Image = ((System.Drawing.Image) (resources.GetObject("pictureBoxNouveau.Image")));
            this.pictureBoxNouveau.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxNouveau.Name = "pictureBoxNouveau";
            this.pictureBoxNouveau.Size = new System.Drawing.Size(27, 27);
            this.pictureBoxNouveau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNouveau.TabIndex = 0;
            this.pictureBoxNouveau.TabStop = false;
            this.pictureBoxNouveau.Click += new System.EventHandler(this.menuFichierNouveau_Click);
            // 
            // richTextBoxTexte
            // 
            this.richTextBoxTexte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxTexte.Location = new System.Drawing.Point(0, 56);
            this.richTextBoxTexte.Name = "richTextBoxTexte";
            this.richTextBoxTexte.Size = new System.Drawing.Size(933, 463);
            this.richTextBoxTexte.TabIndex = 2;
            this.richTextBoxTexte.Text = "";
            this.richTextBoxTexte.TextChanged += new System.EventHandler(this.richTextBoxTexte_TextChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // FicEditeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.richTextBoxTexte);
            this.Controls.Add(this.panelCommande);
            this.Controls.Add(this.menuStripCommande);
            this.MainMenuStrip = this.menuStripCommande;
            this.Name = "FicEditeur";
            this.Text = "Traitement de texte";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FicEditeur_FormClosing);
            this.menuStripCommande.ResumeLayout(false);
            this.menuStripCommande.PerformLayout();
            this.panelCommande.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxQuitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxEnregistrer)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxOuvrir)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxNouveau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelCommande;
        private System.Windows.Forms.MenuStrip menuStripCommande;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.RichTextBox richTextBoxTexte;
        private System.Windows.Forms.ToolStripMenuItem menuFormaterCaractere;
        private System.Windows.Forms.ToolStripMenuItem menuFormaterPolice;
        private System.Windows.Forms.ToolStripMenuItem menuFormaterJustifierCentre;
        private System.Windows.Forms.ToolStripMenuItem menuFormaterJustifierDroite;
        private System.Windows.Forms.ToolStripMenuItem menuFormaterJustifierGauche;
        private System.Windows.Forms.ToolStripMenuItem menuFormaterJustifier;
        private System.Windows.Forms.ToolStripMenuItem menuFormater;
        private System.Windows.Forms.ToolStripMenuItem menuEditerColler;
        private System.Windows.Forms.ToolStripMenuItem menuEditerCouper;
        private System.Windows.Forms.ToolStripMenuItem menuEditerCopier;
        private System.Windows.Forms.ToolStripMenuItem mEditer;
        private System.Windows.Forms.ToolStripMenuItem menuFichierQuitter;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuFichierEnregistrer;
        private System.Windows.Forms.ToolStripMenuItem menuFichierOuvrir;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuFichierNouveau;
        private System.Windows.Forms.ToolStripMenuItem menuFichier;
        private System.Windows.Forms.ToolStripMenuItem menuFormaterCaractereGras;
        private System.Windows.Forms.ToolStripMenuItem menuFormaterCaractereBarre;
        private System.Windows.Forms.ToolStripMenuItem menuFormaterCaractereSouligne;
        private System.Windows.Forms.ToolStripMenuItem menuFormaterCaractereItalique;
        private System.Windows.Forms.PictureBox pictureBoxNouveau;
        private System.Windows.Forms.PictureBox pictureBoxOuvrir;
        private System.Windows.Forms.PictureBox pictureBoxEnregistrer;
        private System.Windows.Forms.PictureBox pictureBoxQuitter;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}