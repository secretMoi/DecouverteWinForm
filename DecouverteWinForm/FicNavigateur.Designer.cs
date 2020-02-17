using System.ComponentModel;

namespace DecouverteWinForm
{
    partial class FicNavigateur
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(FicNavigateur));
            this.toolStripCommande = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonQuitter = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButtonApparence = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItemPetiteIcone = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemGrandeIcone = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemListe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMessage = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageListRepertoire = new System.Windows.Forms.ImageList(this.components);
            this.splitContainerDivision = new System.Windows.Forms.SplitContainer();
            this.treeViewRepertoire = new System.Windows.Forms.TreeView();
            this.listViewFichier = new System.Windows.Forms.ListView();
            this.columnHeaderNom = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderTaille = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDateCreation = new System.Windows.Forms.ColumnHeader();
            this.columnHeaderDateModification = new System.Windows.Forms.ColumnHeader();
            this.imageListFichierGrand = new System.Windows.Forms.ImageList(this.components);
            this.imageListFichierPetit = new System.Windows.Forms.ImageList(this.components);
            this.toolStripCommande.SuspendLayout();
            this.statusStripMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainerDivision)).BeginInit();
            this.splitContainerDivision.Panel1.SuspendLayout();
            this.splitContainerDivision.Panel2.SuspendLayout();
            this.splitContainerDivision.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripCommande
            // 
            this.toolStripCommande.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.toolStripButtonQuitter, this.toolStripSplitButtonApparence});
            this.toolStripCommande.Location = new System.Drawing.Point(0, 0);
            this.toolStripCommande.Name = "toolStripCommande";
            this.toolStripCommande.Size = new System.Drawing.Size(846, 25);
            this.toolStripCommande.TabIndex = 0;
            this.toolStripCommande.Text = "toolStrip1";
            // 
            // toolStripButtonQuitter
            // 
            this.toolStripButtonQuitter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonQuitter.Image =
                ((System.Drawing.Image) (resources.GetObject("toolStripButtonQuitter.Image")));
            this.toolStripButtonQuitter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonQuitter.Name = "toolStripButtonQuitter";
            this.toolStripButtonQuitter.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonQuitter.Text = "toolStripButton1";
            this.toolStripButtonQuitter.Click += new System.EventHandler(this.ToolStripButtonQuitter_Click);
            // 
            // toolStripSplitButtonApparence
            // 
            this.toolStripSplitButtonApparence.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButtonApparence.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.toolStripMenuItemPetiteIcone, this.toolStripMenuItemGrandeIcone, this.toolStripMenuItemListe,
                this.toolStripMenuItemDetail
            });
            this.toolStripSplitButtonApparence.Image =
                ((System.Drawing.Image) (resources.GetObject("toolStripSplitButtonApparence.Image")));
            this.toolStripSplitButtonApparence.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonApparence.Name = "toolStripSplitButtonApparence";
            this.toolStripSplitButtonApparence.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButtonApparence.Text = "toolStripSplitButton1";
            // 
            // toolStripMenuItemPetiteIcone
            // 
            this.toolStripMenuItemPetiteIcone.Name = "toolStripMenuItemPetiteIcone";
            this.toolStripMenuItemPetiteIcone.Size = new System.Drawing.Size(144, 22);
            this.toolStripMenuItemPetiteIcone.Text = "Petite Icône";
            this.toolStripMenuItemPetiteIcone.Click += new System.EventHandler(this.ToolStripMenuItemPetiteIcone_Click);
            // 
            // toolStripMenuItemGrandeIcone
            // 
            this.toolStripMenuItemGrandeIcone.Name = "toolStripMenuItemGrandeIcone";
            this.toolStripMenuItemGrandeIcone.Size = new System.Drawing.Size(144, 22);
            this.toolStripMenuItemGrandeIcone.Text = "Grande icône";
            this.toolStripMenuItemGrandeIcone.Click += new System.EventHandler(this.ToolStripMenuItemGrandeIcone_Click);
            // 
            // toolStripMenuItemListe
            // 
            this.toolStripMenuItemListe.Name = "toolStripMenuItemListe";
            this.toolStripMenuItemListe.Size = new System.Drawing.Size(144, 22);
            this.toolStripMenuItemListe.Text = "Liste";
            this.toolStripMenuItemListe.Click += new System.EventHandler(this.ToolStripMenuItemListe_Click);
            // 
            // toolStripMenuItemDetail
            // 
            this.toolStripMenuItemDetail.Name = "toolStripMenuItemDetail";
            this.toolStripMenuItemDetail.Size = new System.Drawing.Size(144, 22);
            this.toolStripMenuItemDetail.Text = "Détail";
            this.toolStripMenuItemDetail.Click += new System.EventHandler(this.ToolStripMenuItemDetail_Click);
            // 
            // statusStripMessage
            // 
            this.statusStripMessage.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
                {this.toolStripStatusLabelMessage});
            this.statusStripMessage.Location = new System.Drawing.Point(0, 510);
            this.statusStripMessage.Name = "statusStripMessage";
            this.statusStripMessage.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStripMessage.Size = new System.Drawing.Size(846, 22);
            this.statusStripMessage.TabIndex = 1;
            this.statusStripMessage.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMessage
            // 
            this.toolStripStatusLabelMessage.Name = "toolStripStatusLabelMessage";
            this.toolStripStatusLabelMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // imageListRepertoire
            // 
            this.imageListRepertoire.ImageStream =
                ((System.Windows.Forms.ImageListStreamer) (resources.GetObject("imageListRepertoire.ImageStream")));
            this.imageListRepertoire.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListRepertoire.Images.SetKeyName(0, "WEFloppy.bmp");
            this.imageListRepertoire.Images.SetKeyName(1, "WEOrdi.bmp");
            this.imageListRepertoire.Images.SetKeyName(2, "WERepertoire.bmp");
            this.imageListRepertoire.Images.SetKeyName(3, "WERepertoireActif.bmp");
            this.imageListRepertoire.Images.SetKeyName(4, "WEPoubelle.bmp");
            // 
            // splitContainerDivision
            // 
            this.splitContainerDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDivision.Location = new System.Drawing.Point(0, 25);
            this.splitContainerDivision.Name = "splitContainerDivision";
            // 
            // splitContainerDivision.Panel1
            // 
            this.splitContainerDivision.Panel1.Controls.Add(this.treeViewRepertoire);
            // 
            // splitContainerDivision.Panel2
            // 
            this.splitContainerDivision.Panel2.Controls.Add(this.listViewFichier);
            this.splitContainerDivision.Size = new System.Drawing.Size(846, 485);
            this.splitContainerDivision.SplitterDistance = 199;
            this.splitContainerDivision.SplitterWidth = 5;
            this.splitContainerDivision.TabIndex = 2;
            // 
            // treeViewRepertoire
            // 
            this.treeViewRepertoire.ImageIndex = 0;
            this.treeViewRepertoire.ImageList = this.imageListRepertoire;
            this.treeViewRepertoire.Location = new System.Drawing.Point(0, 0);
            this.treeViewRepertoire.Name = "treeViewRepertoire";
            this.treeViewRepertoire.SelectedImageIndex = 0;
            this.treeViewRepertoire.Size = new System.Drawing.Size(201, 474);
            this.treeViewRepertoire.TabIndex = 0;
            this.treeViewRepertoire.AfterSelect +=
                new System.Windows.Forms.TreeViewEventHandler(this.treeViewRepertoire_AfterSelect);
            // 
            // listViewFichier
            // 
            this.listViewFichier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
            {
                this.columnHeaderNom, this.columnHeaderTaille, this.columnHeaderDateCreation,
                this.columnHeaderDateModification
            });
            this.listViewFichier.FullRowSelect = true;
            this.listViewFichier.HideSelection = false;
            this.listViewFichier.LargeImageList = this.imageListFichierGrand;
            this.listViewFichier.Location = new System.Drawing.Point(3, 0);
            this.listViewFichier.Name = "listViewFichier";
            this.listViewFichier.Size = new System.Drawing.Size(635, 474);
            this.listViewFichier.SmallImageList = this.imageListFichierPetit;
            this.listViewFichier.TabIndex = 0;
            this.listViewFichier.UseCompatibleStateImageBehavior = false;
            this.listViewFichier.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNom
            // 
            this.columnHeaderNom.Text = "Nom";
            this.columnHeaderNom.Width = 300;
            // 
            // columnHeaderTaille
            // 
            this.columnHeaderTaille.Text = "Taille";
            this.columnHeaderTaille.Width = 75;
            // 
            // columnHeaderDateCreation
            // 
            this.columnHeaderDateCreation.Text = "Création";
            this.columnHeaderDateCreation.Width = 75;
            // 
            // columnHeaderDateModification
            // 
            this.columnHeaderDateModification.Text = "Modification";
            this.columnHeaderDateModification.Width = 75;
            // 
            // imageListFichierGrand
            // 
            this.imageListFichierGrand.ImageStream =
                ((System.Windows.Forms.ImageListStreamer) (resources.GetObject("imageListFichierGrand.ImageStream")));
            this.imageListFichierGrand.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListFichierGrand.Images.SetKeyName(0, "WELVGrandeIcone.bmp");
            // 
            // imageListFichierPetit
            // 
            this.imageListFichierPetit.ImageStream =
                ((System.Windows.Forms.ImageListStreamer) (resources.GetObject("imageListFichierPetit.ImageStream")));
            this.imageListFichierPetit.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListFichierPetit.Images.SetKeyName(0, "WELVPetiteIcone.bmp");
            // 
            // FicNavigateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 532);
            this.Controls.Add(this.splitContainerDivision);
            this.Controls.Add(this.statusStripMessage);
            this.Controls.Add(this.toolStripCommande);
            this.Name = "FicNavigateur";
            this.Text = "Explorateur de fichiers";
            this.Load += new System.EventHandler(this.FicNavigateur_Load);
            this.toolStripCommande.ResumeLayout(false);
            this.toolStripCommande.PerformLayout();
            this.statusStripMessage.ResumeLayout(false);
            this.statusStripMessage.PerformLayout();
            this.splitContainerDivision.Panel1.ResumeLayout(false);
            this.splitContainerDivision.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.splitContainerDivision)).EndInit();
            this.splitContainerDivision.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripCommande;
        private System.Windows.Forms.StatusStrip statusStripMessage;
        private System.Windows.Forms.ToolStripButton toolStripButtonQuitter;
        private System.Windows.Forms.ImageList imageListRepertoire;
        private System.Windows.Forms.SplitContainer splitContainerDivision;
        private System.Windows.Forms.TreeView treeViewRepertoire;
        private System.Windows.Forms.ListView listViewFichier;
        private System.Windows.Forms.ImageList imageListFichierPetit;
        private System.Windows.Forms.ImageList imageListFichierGrand;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonApparence;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPetiteIcone;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGrandeIcone;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemListe;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDetail;
        private System.Windows.Forms.ColumnHeader columnHeaderNom;
        private System.Windows.Forms.ColumnHeader columnHeaderTaille;
        private System.Windows.Forms.ColumnHeader columnHeaderDateCreation;
        private System.Windows.Forms.ColumnHeader columnHeaderDateModification;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMessage;
    }
}