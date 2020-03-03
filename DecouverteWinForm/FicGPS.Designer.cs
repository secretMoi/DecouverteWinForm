using System.ComponentModel;

namespace DecouverteWinForm
{
    partial class FicGPS
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
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.buttonConnecter = new System.Windows.Forms.Button();
            this.textBoxLongitude = new System.Windows.Forms.TextBox();
            this.textBoxLatitude = new System.Windows.Forms.TextBox();
            this.buttonBoucler = new System.Windows.Forms.Button();
            this.buttonAfficher = new System.Windows.Forms.Button();
            this.timerChrono = new System.Windows.Forms.Timer(this.components);
            this.serialPortGPS = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Items.AddRange(new object[] {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6"});
            this.comboBoxCOM.Location = new System.Drawing.Point(12, 12);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(206, 23);
            this.comboBoxCOM.TabIndex = 0;
            // 
            // buttonConnecter
            // 
            this.buttonConnecter.Location = new System.Drawing.Point(12, 42);
            this.buttonConnecter.Name = "buttonConnecter";
            this.buttonConnecter.Size = new System.Drawing.Size(206, 42);
            this.buttonConnecter.TabIndex = 1;
            this.buttonConnecter.Text = "Connecter";
            this.buttonConnecter.UseVisualStyleBackColor = true;
            this.buttonConnecter.Click += new System.EventHandler(this.buttonConnecter_Click);
            // 
            // textBoxLongitude
            // 
            this.textBoxLongitude.Location = new System.Drawing.Point(12, 89);
            this.textBoxLongitude.Name = "textBoxLongitude";
            this.textBoxLongitude.Size = new System.Drawing.Size(206, 23);
            this.textBoxLongitude.TabIndex = 2;
            // 
            // textBoxLatitude
            // 
            this.textBoxLatitude.Location = new System.Drawing.Point(12, 122);
            this.textBoxLatitude.Name = "textBoxLatitude";
            this.textBoxLatitude.Size = new System.Drawing.Size(206, 23);
            this.textBoxLatitude.TabIndex = 3;
            // 
            // buttonBoucler
            // 
            this.buttonBoucler.Location = new System.Drawing.Point(12, 165);
            this.buttonBoucler.Name = "buttonBoucler";
            this.buttonBoucler.Size = new System.Drawing.Size(206, 42);
            this.buttonBoucler.TabIndex = 4;
            this.buttonBoucler.Text = "Débuter lecture";
            this.buttonBoucler.UseVisualStyleBackColor = true;
            this.buttonBoucler.Click += new System.EventHandler(this.buttonBoucler_Click);
            // 
            // buttonAfficher
            // 
            this.buttonAfficher.Location = new System.Drawing.Point(12, 213);
            this.buttonAfficher.Name = "buttonAfficher";
            this.buttonAfficher.Size = new System.Drawing.Size(206, 42);
            this.buttonAfficher.TabIndex = 5;
            this.buttonAfficher.Text = "Afficher";
            this.buttonAfficher.UseVisualStyleBackColor = true;
            this.buttonAfficher.Click += new System.EventHandler(this.buttonAfficher_Click);
            // 
            // timerChrono
            // 
            this.timerChrono.Tick += new System.EventHandler(this.timerChrono_Tick);
            // 
            // FicGPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 267);
            this.Controls.Add(this.buttonAfficher);
            this.Controls.Add(this.buttonBoucler);
            this.Controls.Add(this.textBoxLatitude);
            this.Controls.Add(this.textBoxLongitude);
            this.Controls.Add(this.buttonConnecter);
            this.Controls.Add(this.comboBoxCOM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FicGPS";
            this.Text = "FicGPS";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.Button buttonAfficher;
        private System.Windows.Forms.Button buttonBoucler;
        private System.Windows.Forms.TextBox textBoxLatitude;
        private System.Windows.Forms.TextBox textBoxLongitude;
        private System.Windows.Forms.Button buttonConnecter;
        private System.Windows.Forms.Timer timerChrono;
        private System.IO.Ports.SerialPort serialPortGPS;
    }
}