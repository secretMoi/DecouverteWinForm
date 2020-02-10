using System.ComponentModel;

namespace DecouverteWinForm
{
    partial class FicSpirographe
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
                new System.ComponentModel.ComponentResourceManager(typeof(FicSpirographe));
            this.groupBoxParametres = new System.Windows.Forms.GroupBox();
            this.buttonTrait = new System.Windows.Forms.Button();
            this.buttonFond = new System.Windows.Forms.Button();
            this.buttonGo = new System.Windows.Forms.Button();
            this.trackBarProfondeur = new System.Windows.Forms.TrackBar();
            this.labelProfondeur = new System.Windows.Forms.Label();
            this.trackBarDensite = new System.Windows.Forms.TrackBar();
            this.labelDensite = new System.Windows.Forms.Label();
            this.trackBarSommets = new System.Windows.Forms.TrackBar();
            this.labelSommets = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.groupBoxParametres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.trackBarProfondeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBarDensite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBarSommets)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxParametres
            // 
            this.groupBoxParametres.Controls.Add(this.buttonTrait);
            this.groupBoxParametres.Controls.Add(this.buttonFond);
            this.groupBoxParametres.Controls.Add(this.buttonGo);
            this.groupBoxParametres.Controls.Add(this.trackBarProfondeur);
            this.groupBoxParametres.Controls.Add(this.labelProfondeur);
            this.groupBoxParametres.Controls.Add(this.trackBarDensite);
            this.groupBoxParametres.Controls.Add(this.labelDensite);
            this.groupBoxParametres.Controls.Add(this.trackBarSommets);
            this.groupBoxParametres.Controls.Add(this.labelSommets);
            this.groupBoxParametres.Location = new System.Drawing.Point(12, 12);
            this.groupBoxParametres.Name = "groupBoxParametres";
            this.groupBoxParametres.Size = new System.Drawing.Size(232, 321);
            this.groupBoxParametres.TabIndex = 0;
            this.groupBoxParametres.TabStop = false;
            this.groupBoxParametres.Text = "Paramètres";
            // 
            // buttonTrait
            // 
            this.buttonTrait.Image = ((System.Drawing.Image) (resources.GetObject("buttonTrait.Image")));
            this.buttonTrait.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTrait.Location = new System.Drawing.Point(6, 292);
            this.buttonTrait.Name = "buttonTrait";
            this.buttonTrait.Size = new System.Drawing.Size(104, 23);
            this.buttonTrait.TabIndex = 8;
            this.buttonTrait.Text = "Trait";
            this.buttonTrait.UseVisualStyleBackColor = true;
            this.buttonTrait.Click += new System.EventHandler(this.buttonTrait_Click);
            // 
            // buttonFond
            // 
            this.buttonFond.Image = ((System.Drawing.Image) (resources.GetObject("buttonFond.Image")));
            this.buttonFond.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFond.Location = new System.Drawing.Point(115, 292);
            this.buttonFond.Name = "buttonFond";
            this.buttonFond.Size = new System.Drawing.Size(110, 23);
            this.buttonFond.TabIndex = 7;
            this.buttonFond.Text = "Fond";
            this.buttonFond.UseVisualStyleBackColor = true;
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(6, 253);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(220, 23);
            this.buttonGo.TabIndex = 6;
            this.buttonGo.Text = "GO";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // trackBarProfondeur
            // 
            this.trackBarProfondeur.Location = new System.Drawing.Point(6, 202);
            this.trackBarProfondeur.Maximum = 80;
            this.trackBarProfondeur.Minimum = 20;
            this.trackBarProfondeur.Name = "trackBarProfondeur";
            this.trackBarProfondeur.Size = new System.Drawing.Size(220, 45);
            this.trackBarProfondeur.TabIndex = 5;
            this.trackBarProfondeur.TickFrequency = 5;
            this.trackBarProfondeur.Value = 40;
            // 
            // labelProfondeur
            // 
            this.labelProfondeur.Location = new System.Drawing.Point(6, 177);
            this.labelProfondeur.Name = "labelProfondeur";
            this.labelProfondeur.Size = new System.Drawing.Size(220, 23);
            this.labelProfondeur.TabIndex = 4;
            this.labelProfondeur.Text = "Profondeur de dessin (20 à 80)";
            // 
            // trackBarDensite
            // 
            this.trackBarDensite.Location = new System.Drawing.Point(6, 128);
            this.trackBarDensite.Maximum = 20;
            this.trackBarDensite.Minimum = 5;
            this.trackBarDensite.Name = "trackBarDensite";
            this.trackBarDensite.Size = new System.Drawing.Size(220, 45);
            this.trackBarDensite.TabIndex = 3;
            this.trackBarDensite.Value = 10;
            // 
            // labelDensite
            // 
            this.labelDensite.Location = new System.Drawing.Point(6, 102);
            this.labelDensite.Name = "labelDensite";
            this.labelDensite.Size = new System.Drawing.Size(220, 23);
            this.labelDensite.TabIndex = 2;
            this.labelDensite.Text = "Densité de dessin (5 à 20)";
            // 
            // trackBarSommets
            // 
            this.trackBarSommets.Location = new System.Drawing.Point(6, 55);
            this.trackBarSommets.Maximum = 8;
            this.trackBarSommets.Minimum = 3;
            this.trackBarSommets.Name = "trackBarSommets";
            this.trackBarSommets.Size = new System.Drawing.Size(220, 45);
            this.trackBarSommets.TabIndex = 1;
            this.trackBarSommets.Value = 5;
            // 
            // labelSommets
            // 
            this.labelSommets.Location = new System.Drawing.Point(6, 29);
            this.labelSommets.Name = "labelSommets";
            this.labelSommets.Size = new System.Drawing.Size(220, 23);
            this.labelSommets.TabIndex = 0;
            this.labelSommets.Text = "Nombre de sommets (3 à 8)";
            // 
            // FicSpirographe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 345);
            this.Controls.Add(this.groupBoxParametres);
            this.MinimumSize = new System.Drawing.Size(383, 384);
            this.Name = "FicSpirographe";
            this.Text = "Spirographe";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FicSpirographe_Paint);
            this.groupBoxParametres.ResumeLayout(false);
            this.groupBoxParametres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.trackBarProfondeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBarDensite)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.trackBarSommets)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label labelSommets;
        private System.Windows.Forms.TrackBar trackBarSommets;
        private System.Windows.Forms.Label labelDensite;
        private System.Windows.Forms.TrackBar trackBarDensite;
        private System.Windows.Forms.GroupBox groupBoxParametres;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button buttonTrait;
        private System.Windows.Forms.Label labelProfondeur;
        private System.Windows.Forms.TrackBar trackBarProfondeur;
        private System.Windows.Forms.Button buttonFond;
    }
}