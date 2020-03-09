namespace DecouverteWinForm
{
    partial class FicBDCouches
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
			this.dataGridViewPersonne = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Afficher = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonAjouter = new System.Windows.Forms.Button();
			this.buttonSupprimer = new System.Windows.Forms.Button();
			this.buttonEditer = new System.Windows.Forms.Button();
			this.labelIdentifiant = new System.Windows.Forms.Label();
			this.textBoxIdentifiant = new System.Windows.Forms.TextBox();
			this.textBoxNom = new System.Windows.Forms.TextBox();
			this.labelNom = new System.Windows.Forms.Label();
			this.textBoxPrenom = new System.Windows.Forms.TextBox();
			this.labelPrenom = new System.Windows.Forms.Label();
			this.labelDateNaissance = new System.Windows.Forms.Label();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.buttonConfirmer = new System.Windows.Forms.Button();
			this.buttonAnnuler = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonne)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewPersonne
			// 
			this.dataGridViewPersonne.AllowUserToAddRows = false;
			this.dataGridViewPersonne.AllowUserToDeleteRows = false;
			this.dataGridViewPersonne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewPersonne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Afficher});
			this.dataGridViewPersonne.Location = new System.Drawing.Point(12, 12);
			this.dataGridViewPersonne.Name = "dataGridViewPersonne";
			this.dataGridViewPersonne.RowHeadersVisible = false;
			this.dataGridViewPersonne.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewPersonne.Size = new System.Drawing.Size(437, 224);
			this.dataGridViewPersonne.TabIndex = 0;
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// Afficher
			// 
			this.Afficher.DataPropertyName = "Afficher";
			this.Afficher.HeaderText = "Prénom et nom";
			this.Afficher.Name = "Afficher";
			this.Afficher.ReadOnly = true;
			this.Afficher.Width = 400;
			// 
			// buttonAjouter
			// 
			this.buttonAjouter.Location = new System.Drawing.Point(12, 242);
			this.buttonAjouter.Name = "buttonAjouter";
			this.buttonAjouter.Size = new System.Drawing.Size(96, 43);
			this.buttonAjouter.TabIndex = 1;
			this.buttonAjouter.Text = "Ajouter";
			this.buttonAjouter.UseVisualStyleBackColor = true;
			this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
			// 
			// buttonSupprimer
			// 
			this.buttonSupprimer.Location = new System.Drawing.Point(353, 242);
			this.buttonSupprimer.Name = "buttonSupprimer";
			this.buttonSupprimer.Size = new System.Drawing.Size(96, 43);
			this.buttonSupprimer.TabIndex = 2;
			this.buttonSupprimer.Text = "Supprimer";
			this.buttonSupprimer.UseVisualStyleBackColor = true;
			this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
			// 
			// buttonEditer
			// 
			this.buttonEditer.Location = new System.Drawing.Point(178, 242);
			this.buttonEditer.Name = "buttonEditer";
			this.buttonEditer.Size = new System.Drawing.Size(96, 43);
			this.buttonEditer.TabIndex = 3;
			this.buttonEditer.Text = "Editer";
			this.buttonEditer.UseVisualStyleBackColor = true;
			this.buttonEditer.Click += new System.EventHandler(this.buttonEditer_Click);
			// 
			// labelIdentifiant
			// 
			this.labelIdentifiant.AutoSize = true;
			this.labelIdentifiant.Location = new System.Drawing.Point(12, 310);
			this.labelIdentifiant.Name = "labelIdentifiant";
			this.labelIdentifiant.Size = new System.Drawing.Size(53, 13);
			this.labelIdentifiant.TabIndex = 4;
			this.labelIdentifiant.Text = "Identifiant";
			// 
			// textBoxIdentifiant
			// 
			this.textBoxIdentifiant.Location = new System.Drawing.Point(12, 326);
			this.textBoxIdentifiant.Name = "textBoxIdentifiant";
			this.textBoxIdentifiant.ReadOnly = true;
			this.textBoxIdentifiant.Size = new System.Drawing.Size(435, 20);
			this.textBoxIdentifiant.TabIndex = 5;
			// 
			// textBoxNom
			// 
			this.textBoxNom.Location = new System.Drawing.Point(12, 366);
			this.textBoxNom.Name = "textBoxNom";
			this.textBoxNom.Size = new System.Drawing.Size(435, 20);
			this.textBoxNom.TabIndex = 7;
			// 
			// labelNom
			// 
			this.labelNom.AutoSize = true;
			this.labelNom.Location = new System.Drawing.Point(12, 350);
			this.labelNom.Name = "labelNom";
			this.labelNom.Size = new System.Drawing.Size(29, 13);
			this.labelNom.TabIndex = 6;
			this.labelNom.Text = "Nom";
			// 
			// textBoxPrenom
			// 
			this.textBoxPrenom.Location = new System.Drawing.Point(12, 413);
			this.textBoxPrenom.Name = "textBoxPrenom";
			this.textBoxPrenom.Size = new System.Drawing.Size(435, 20);
			this.textBoxPrenom.TabIndex = 9;
			// 
			// labelPrenom
			// 
			this.labelPrenom.AutoSize = true;
			this.labelPrenom.Location = new System.Drawing.Point(12, 397);
			this.labelPrenom.Name = "labelPrenom";
			this.labelPrenom.Size = new System.Drawing.Size(43, 13);
			this.labelPrenom.TabIndex = 8;
			this.labelPrenom.Text = "Prenom";
			// 
			// labelDateNaissance
			// 
			this.labelDateNaissance.AutoSize = true;
			this.labelDateNaissance.Location = new System.Drawing.Point(12, 448);
			this.labelDateNaissance.Name = "labelDateNaissance";
			this.labelDateNaissance.Size = new System.Drawing.Size(96, 13);
			this.labelDateNaissance.TabIndex = 10;
			this.labelDateNaissance.Text = "Date de naissance";
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Location = new System.Drawing.Point(12, 464);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(435, 20);
			this.dateTimePicker.TabIndex = 11;
			// 
			// buttonConfirmer
			// 
			this.buttonConfirmer.Location = new System.Drawing.Point(12, 490);
			this.buttonConfirmer.Name = "buttonConfirmer";
			this.buttonConfirmer.Size = new System.Drawing.Size(96, 43);
			this.buttonConfirmer.TabIndex = 12;
			this.buttonConfirmer.Text = "Confirmer";
			this.buttonConfirmer.UseVisualStyleBackColor = true;
			this.buttonConfirmer.Click += new System.EventHandler(this.buttonConfirmer_Click);
			// 
			// buttonAnnuler
			// 
			this.buttonAnnuler.Location = new System.Drawing.Point(351, 490);
			this.buttonAnnuler.Name = "buttonAnnuler";
			this.buttonAnnuler.Size = new System.Drawing.Size(96, 43);
			this.buttonAnnuler.TabIndex = 13;
			this.buttonAnnuler.Text = "Annuler";
			this.buttonAnnuler.UseVisualStyleBackColor = true;
			this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
			// 
			// FicBDCouches
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(459, 540);
			this.Controls.Add(this.buttonAnnuler);
			this.Controls.Add(this.buttonConfirmer);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.labelDateNaissance);
			this.Controls.Add(this.textBoxPrenom);
			this.Controls.Add(this.labelPrenom);
			this.Controls.Add(this.textBoxNom);
			this.Controls.Add(this.labelNom);
			this.Controls.Add(this.textBoxIdentifiant);
			this.Controls.Add(this.labelIdentifiant);
			this.Controls.Add(this.buttonEditer);
			this.Controls.Add(this.buttonSupprimer);
			this.Controls.Add(this.buttonAjouter);
			this.Controls.Add(this.dataGridViewPersonne);
			this.Name = "FicBDCouches";
			this.Text = "Gestion BDD par couches";
			this.Load += new System.EventHandler(this.BDCouches_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonne)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPersonne;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonEditer;
        private System.Windows.Forms.Label labelIdentifiant;
        private System.Windows.Forms.TextBox textBoxIdentifiant;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label labelPrenom;
		private System.Windows.Forms.Label labelDateNaissance;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
		private System.Windows.Forms.Button buttonConfirmer;
		private System.Windows.Forms.Button buttonAnnuler;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Afficher;
	}
}