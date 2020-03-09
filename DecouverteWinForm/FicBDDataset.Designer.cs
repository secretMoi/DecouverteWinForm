namespace DecouverteWinForm
{
    partial class FicBDDataset
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
			this.components = new System.ComponentModel.Container();
			this.labelIdentifiant = new System.Windows.Forms.Label();
			this.textBoxIdentifiant = new System.Windows.Forms.TextBox();
			this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSetPerso = new DecouverteWinForm.DataSetPerso();
			this.textBoxPrenom = new System.Windows.Forms.TextBox();
			this.labelPrenom = new System.Windows.Forms.Label();
			this.textBoxNom = new System.Windows.Forms.TextBox();
			this.labelNom = new System.Windows.Forms.Label();
			this.labelDateNaissance = new System.Windows.Forms.Label();
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.buttonPremier = new System.Windows.Forms.Button();
			this.buttonPrecedent = new System.Windows.Forms.Button();
			this.buttonDernier = new System.Windows.Forms.Button();
			this.buttonSuivant = new System.Windows.Forms.Button();
			this.labelPosition = new System.Windows.Forms.Label();
			this.buttonConfirmer = new System.Windows.Forms.Button();
			this.buttonAnnuler = new System.Windows.Forms.Button();
			this.buttonEditer = new System.Windows.Forms.Button();
			this.buttonAjouter = new System.Windows.Forms.Button();
			this.buttonSupprimer = new System.Windows.Forms.Button();
			this.dataGridViewClient = new System.Windows.Forms.DataGridView();
			this.nUMCLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.clientTableAdapter = new DecouverteWinForm.DataSetPersoTableAdapters.ClientTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetPerso)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// labelIdentifiant
			// 
			this.labelIdentifiant.AutoSize = true;
			this.labelIdentifiant.Location = new System.Drawing.Point(12, 9);
			this.labelIdentifiant.Name = "labelIdentifiant";
			this.labelIdentifiant.Size = new System.Drawing.Size(53, 13);
			this.labelIdentifiant.TabIndex = 0;
			this.labelIdentifiant.Text = "Identifiant";
			// 
			// textBoxIdentifiant
			// 
			this.textBoxIdentifiant.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "NUMCLI", true));
			this.textBoxIdentifiant.Location = new System.Drawing.Point(12, 25);
			this.textBoxIdentifiant.Name = "textBoxIdentifiant";
			this.textBoxIdentifiant.ReadOnly = true;
			this.textBoxIdentifiant.Size = new System.Drawing.Size(240, 20);
			this.textBoxIdentifiant.TabIndex = 1;
			// 
			// clientBindingSource
			// 
			this.clientBindingSource.DataMember = "Client";
			this.clientBindingSource.DataSource = this.dataSetPerso;
			this.clientBindingSource.CurrentChanged += new System.EventHandler(this.ClientBindingSource_CurrentChanged);
			// 
			// dataSetPerso
			// 
			this.dataSetPerso.DataSetName = "DataSetPerso";
			this.dataSetPerso.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// textBoxPrenom
			// 
			this.textBoxPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "PRE", true));
			this.textBoxPrenom.Location = new System.Drawing.Point(12, 76);
			this.textBoxPrenom.Name = "textBoxPrenom";
			this.textBoxPrenom.Size = new System.Drawing.Size(240, 20);
			this.textBoxPrenom.TabIndex = 3;
			// 
			// labelPrenom
			// 
			this.labelPrenom.AutoSize = true;
			this.labelPrenom.Location = new System.Drawing.Point(12, 60);
			this.labelPrenom.Name = "labelPrenom";
			this.labelPrenom.Size = new System.Drawing.Size(43, 13);
			this.labelPrenom.TabIndex = 2;
			this.labelPrenom.Text = "Prénom";
			// 
			// textBoxNom
			// 
			this.textBoxNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "NOM", true));
			this.textBoxNom.Location = new System.Drawing.Point(12, 134);
			this.textBoxNom.Name = "textBoxNom";
			this.textBoxNom.Size = new System.Drawing.Size(240, 20);
			this.textBoxNom.TabIndex = 5;
			// 
			// labelNom
			// 
			this.labelNom.AutoSize = true;
			this.labelNom.Location = new System.Drawing.Point(12, 118);
			this.labelNom.Name = "labelNom";
			this.labelNom.Size = new System.Drawing.Size(29, 13);
			this.labelNom.TabIndex = 4;
			this.labelNom.Text = "Nom";
			// 
			// labelDateNaissance
			// 
			this.labelDateNaissance.AutoSize = true;
			this.labelDateNaissance.Location = new System.Drawing.Point(9, 172);
			this.labelDateNaissance.Name = "labelDateNaissance";
			this.labelDateNaissance.Size = new System.Drawing.Size(96, 13);
			this.labelDateNaissance.TabIndex = 6;
			this.labelDateNaissance.Text = "Date de naissance";
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientBindingSource, "NAI", true));
			this.dateTimePicker.Location = new System.Drawing.Point(12, 199);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(240, 20);
			this.dateTimePicker.TabIndex = 7;
			// 
			// buttonPremier
			// 
			this.buttonPremier.Location = new System.Drawing.Point(12, 237);
			this.buttonPremier.Name = "buttonPremier";
			this.buttonPremier.Size = new System.Drawing.Size(35, 35);
			this.buttonPremier.TabIndex = 10;
			this.buttonPremier.Text = "|<";
			this.buttonPremier.UseVisualStyleBackColor = true;
			this.buttonPremier.Click += new System.EventHandler(this.ButtonPremier_Click);
			// 
			// buttonPrecedent
			// 
			this.buttonPrecedent.Location = new System.Drawing.Point(53, 237);
			this.buttonPrecedent.Name = "buttonPrecedent";
			this.buttonPrecedent.Size = new System.Drawing.Size(35, 35);
			this.buttonPrecedent.TabIndex = 11;
			this.buttonPrecedent.Text = "<";
			this.buttonPrecedent.UseVisualStyleBackColor = true;
			this.buttonPrecedent.Click += new System.EventHandler(this.ButtonPrecedent_Click);
			// 
			// buttonDernier
			// 
			this.buttonDernier.Location = new System.Drawing.Point(217, 237);
			this.buttonDernier.Name = "buttonDernier";
			this.buttonDernier.Size = new System.Drawing.Size(35, 35);
			this.buttonDernier.TabIndex = 12;
			this.buttonDernier.Text = ">|";
			this.buttonDernier.UseVisualStyleBackColor = true;
			this.buttonDernier.Click += new System.EventHandler(this.ButtonDernier_Click);
			// 
			// buttonSuivant
			// 
			this.buttonSuivant.Location = new System.Drawing.Point(176, 237);
			this.buttonSuivant.Name = "buttonSuivant";
			this.buttonSuivant.Size = new System.Drawing.Size(35, 35);
			this.buttonSuivant.TabIndex = 13;
			this.buttonSuivant.Text = ">";
			this.buttonSuivant.UseVisualStyleBackColor = true;
			this.buttonSuivant.Click += new System.EventHandler(this.ButtonSuivant_Click);
			// 
			// labelPosition
			// 
			this.labelPosition.BackColor = System.Drawing.SystemColors.ControlDark;
			this.labelPosition.Location = new System.Drawing.Point(94, 237);
			this.labelPosition.Name = "labelPosition";
			this.labelPosition.Size = new System.Drawing.Size(76, 35);
			this.labelPosition.TabIndex = 14;
			this.labelPosition.Text = "0/0";
			this.labelPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonConfirmer
			// 
			this.buttonConfirmer.Location = new System.Drawing.Point(12, 278);
			this.buttonConfirmer.Name = "buttonConfirmer";
			this.buttonConfirmer.Size = new System.Drawing.Size(76, 23);
			this.buttonConfirmer.TabIndex = 15;
			this.buttonConfirmer.Text = "Confirmer";
			this.buttonConfirmer.UseVisualStyleBackColor = true;
			this.buttonConfirmer.Click += new System.EventHandler(this.ButtonConfirmer_Click);
			// 
			// buttonAnnuler
			// 
			this.buttonAnnuler.Location = new System.Drawing.Point(176, 278);
			this.buttonAnnuler.Name = "buttonAnnuler";
			this.buttonAnnuler.Size = new System.Drawing.Size(76, 23);
			this.buttonAnnuler.TabIndex = 16;
			this.buttonAnnuler.Text = "Annuler";
			this.buttonAnnuler.UseVisualStyleBackColor = true;
			this.buttonAnnuler.Click += new System.EventHandler(this.ButtonAnnuler_Click);
			// 
			// buttonEditer
			// 
			this.buttonEditer.Location = new System.Drawing.Point(12, 307);
			this.buttonEditer.Name = "buttonEditer";
			this.buttonEditer.Size = new System.Drawing.Size(76, 23);
			this.buttonEditer.TabIndex = 17;
			this.buttonEditer.Text = "Editer";
			this.buttonEditer.UseVisualStyleBackColor = true;
			this.buttonEditer.Click += new System.EventHandler(this.ButtonEditer_Click);
			// 
			// buttonAjouter
			// 
			this.buttonAjouter.Location = new System.Drawing.Point(94, 307);
			this.buttonAjouter.Name = "buttonAjouter";
			this.buttonAjouter.Size = new System.Drawing.Size(76, 23);
			this.buttonAjouter.TabIndex = 18;
			this.buttonAjouter.Text = "Ajouter";
			this.buttonAjouter.UseVisualStyleBackColor = true;
			this.buttonAjouter.Click += new System.EventHandler(this.ButtonAjouter_Click);
			// 
			// buttonSupprimer
			// 
			this.buttonSupprimer.Location = new System.Drawing.Point(176, 307);
			this.buttonSupprimer.Name = "buttonSupprimer";
			this.buttonSupprimer.Size = new System.Drawing.Size(76, 23);
			this.buttonSupprimer.TabIndex = 19;
			this.buttonSupprimer.Text = "Supprimer";
			this.buttonSupprimer.UseVisualStyleBackColor = true;
			this.buttonSupprimer.Click += new System.EventHandler(this.ButtonSupprimer_Click);
			// 
			// dataGridViewClient
			// 
			this.dataGridViewClient.AllowUserToAddRows = false;
			this.dataGridViewClient.AllowUserToDeleteRows = false;
			this.dataGridViewClient.AutoGenerateColumns = false;
			this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nUMCLIDataGridViewTextBoxColumn,
            this.nOMDataGridViewTextBoxColumn,
            this.pREDataGridViewTextBoxColumn,
            this.nAIDataGridViewTextBoxColumn});
			this.dataGridViewClient.DataSource = this.clientBindingSource;
			this.dataGridViewClient.Location = new System.Drawing.Point(258, 9);
			this.dataGridViewClient.Name = "dataGridViewClient";
			this.dataGridViewClient.ReadOnly = true;
			this.dataGridViewClient.RowHeadersVisible = false;
			this.dataGridViewClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewClient.Size = new System.Drawing.Size(405, 176);
			this.dataGridViewClient.TabIndex = 20;
			// 
			// nUMCLIDataGridViewTextBoxColumn
			// 
			this.nUMCLIDataGridViewTextBoxColumn.DataPropertyName = "NUMCLI";
			this.nUMCLIDataGridViewTextBoxColumn.HeaderText = "NUMCLI";
			this.nUMCLIDataGridViewTextBoxColumn.Name = "nUMCLIDataGridViewTextBoxColumn";
			this.nUMCLIDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nOMDataGridViewTextBoxColumn
			// 
			this.nOMDataGridViewTextBoxColumn.DataPropertyName = "NOM";
			this.nOMDataGridViewTextBoxColumn.HeaderText = "NOM";
			this.nOMDataGridViewTextBoxColumn.Name = "nOMDataGridViewTextBoxColumn";
			this.nOMDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// pREDataGridViewTextBoxColumn
			// 
			this.pREDataGridViewTextBoxColumn.DataPropertyName = "PRE";
			this.pREDataGridViewTextBoxColumn.HeaderText = "PRE";
			this.pREDataGridViewTextBoxColumn.Name = "pREDataGridViewTextBoxColumn";
			this.pREDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nAIDataGridViewTextBoxColumn
			// 
			this.nAIDataGridViewTextBoxColumn.DataPropertyName = "NAI";
			this.nAIDataGridViewTextBoxColumn.HeaderText = "NAI";
			this.nAIDataGridViewTextBoxColumn.Name = "nAIDataGridViewTextBoxColumn";
			this.nAIDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(258, 191);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(405, 139);
			this.dataGridView2.TabIndex = 21;
			// 
			// clientTableAdapter
			// 
			this.clientTableAdapter.ClearBeforeFill = true;
			// 
			// FicBDDataset
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(664, 334);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.dataGridViewClient);
			this.Controls.Add(this.buttonSupprimer);
			this.Controls.Add(this.buttonAjouter);
			this.Controls.Add(this.buttonEditer);
			this.Controls.Add(this.buttonAnnuler);
			this.Controls.Add(this.buttonConfirmer);
			this.Controls.Add(this.labelPosition);
			this.Controls.Add(this.buttonSuivant);
			this.Controls.Add(this.buttonDernier);
			this.Controls.Add(this.buttonPrecedent);
			this.Controls.Add(this.buttonPremier);
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.labelDateNaissance);
			this.Controls.Add(this.textBoxNom);
			this.Controls.Add(this.labelNom);
			this.Controls.Add(this.textBoxPrenom);
			this.Controls.Add(this.labelPrenom);
			this.Controls.Add(this.textBoxIdentifiant);
			this.Controls.Add(this.labelIdentifiant);
			this.Name = "FicBDDataset";
			this.Text = "FicBDDataset";
			this.Load += new System.EventHandler(this.FicBDDataset_Load);
			((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSetPerso)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIdentifiant;
        private System.Windows.Forms.TextBox textBoxIdentifiant;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelDateNaissance;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonPremier;
        private System.Windows.Forms.Button buttonPrecedent;
        private System.Windows.Forms.Button buttonDernier;
        private System.Windows.Forms.Button buttonSuivant;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Button buttonConfirmer;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonEditer;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DataSetPerso dataSetPerso;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DataSetPersoTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMCLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAIDataGridViewTextBoxColumn;
    }
}