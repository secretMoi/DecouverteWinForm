namespace DecouverteWinForm
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxDemarrage = new System.Windows.Forms.PictureBox();
            this.buttonPousser = new System.Windows.Forms.Button();
            this.buttonEntrer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxDemarrage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Découverte de C#";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxDemarrage
            // 
            this.pictureBoxDemarrage.Image = global::DecouverteWinForm.Properties.Resources.fond;
            this.pictureBoxDemarrage.Location = new System.Drawing.Point(12, 54);
            this.pictureBoxDemarrage.Name = "pictureBoxDemarrage";
            this.pictureBoxDemarrage.Size = new System.Drawing.Size(367, 160);
            this.pictureBoxDemarrage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDemarrage.TabIndex = 1;
            this.pictureBoxDemarrage.TabStop = false;
            // 
            // buttonPousser
            // 
            this.buttonPousser.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonPousser.Location = new System.Drawing.Point(12, 220);
            this.buttonPousser.Name = "buttonPousser";
            this.buttonPousser.Size = new System.Drawing.Size(161, 33);
            this.buttonPousser.TabIndex = 2;
            this.buttonPousser.Text = "Pousser";
            this.buttonPousser.UseVisualStyleBackColor = false;
            this.buttonPousser.Click += new System.EventHandler(this.buttonPousser_Click);
            // 
            // buttonEntrer
            // 
            this.buttonEntrer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonEntrer.Location = new System.Drawing.Point(218, 220);
            this.buttonEntrer.Name = "buttonEntrer";
            this.buttonEntrer.Size = new System.Drawing.Size(161, 33);
            this.buttonEntrer.TabIndex = 3;
            this.buttonEntrer.Text = "Entrer";
            this.buttonEntrer.UseVisualStyleBackColor = false;
            this.buttonEntrer.Click += new System.EventHandler(this.buttonEntrer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 267);
            this.Controls.Add(this.buttonEntrer);
            this.Controls.Add(this.buttonPousser);
            this.Controls.Add(this.pictureBoxDemarrage);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Bienvenue, Welcome !";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxDemarrage)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxDemarrage;
        private System.Windows.Forms.Button buttonPousser;
        private System.Windows.Forms.Button buttonEntrer;
    }
}