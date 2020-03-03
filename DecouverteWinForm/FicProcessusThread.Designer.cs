using System.ComponentModel;

namespace DecouverteWinForm
{
    partial class FicProcessusThread
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
            this.listBoxConsole = new System.Windows.Forms.ListBox();
            this.buttonProcessus1 = new System.Windows.Forms.Button();
            this.buttonProcessus2 = new System.Windows.Forms.Button();
            this.buttonProcessus3 = new System.Windows.Forms.Button();
            this.buttonThread1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxConsole
            // 
            this.listBoxConsole.FormattingEnabled = true;
            this.listBoxConsole.ItemHeight = 15;
            this.listBoxConsole.Location = new System.Drawing.Point(12, 12);
            this.listBoxConsole.Name = "listBoxConsole";
            this.listBoxConsole.Size = new System.Drawing.Size(319, 214);
            this.listBoxConsole.TabIndex = 0;
            // 
            // buttonProcessus1
            // 
            this.buttonProcessus1.Location = new System.Drawing.Point(12, 232);
            this.buttonProcessus1.Name = "buttonProcessus1";
            this.buttonProcessus1.Size = new System.Drawing.Size(100, 23);
            this.buttonProcessus1.TabIndex = 1;
            this.buttonProcessus1.Text = "Processus V1";
            this.buttonProcessus1.UseVisualStyleBackColor = true;
            this.buttonProcessus1.Click += new System.EventHandler(this.buttonProcessus1_Click);
            // 
            // buttonProcessus2
            // 
            this.buttonProcessus2.Location = new System.Drawing.Point(118, 232);
            this.buttonProcessus2.Name = "buttonProcessus2";
            this.buttonProcessus2.Size = new System.Drawing.Size(107, 23);
            this.buttonProcessus2.TabIndex = 2;
            this.buttonProcessus2.Text = "Processus V2";
            this.buttonProcessus2.UseVisualStyleBackColor = true;
            this.buttonProcessus2.Click += new System.EventHandler(this.buttonProcessus2_Click);
            // 
            // buttonProcessus3
            // 
            this.buttonProcessus3.Location = new System.Drawing.Point(231, 232);
            this.buttonProcessus3.Name = "buttonProcessus3";
            this.buttonProcessus3.Size = new System.Drawing.Size(100, 23);
            this.buttonProcessus3.TabIndex = 3;
            this.buttonProcessus3.Text = "Processus V3";
            this.buttonProcessus3.UseVisualStyleBackColor = true;
            this.buttonProcessus3.Click += new System.EventHandler(this.buttonProcessus3_Click);
            // 
            // buttonThread1
            // 
            this.buttonThread1.Location = new System.Drawing.Point(12, 286);
            this.buttonThread1.Name = "buttonThread1";
            this.buttonThread1.Size = new System.Drawing.Size(136, 23);
            this.buttonThread1.TabIndex = 4;
            this.buttonThread1.Text = "Thread version 1";
            this.buttonThread1.UseVisualStyleBackColor = true;
            this.buttonThread1.Click += new System.EventHandler(this.buttonThread1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Processus V3";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FicProcessusThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 318);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonThread1);
            this.Controls.Add(this.buttonProcessus3);
            this.Controls.Add(this.buttonProcessus2);
            this.Controls.Add(this.buttonProcessus1);
            this.Controls.Add(this.listBoxConsole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FicProcessusThread";
            this.Text = "FicProcessusThread";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EcranProcessusThread_FormClosing);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button buttonProcessus1;
        private System.Windows.Forms.ListBox listBoxConsole;
        private System.Windows.Forms.Button buttonProcessus2;
        private System.Windows.Forms.Button buttonProcessus3;
        private System.Windows.Forms.Button buttonThread1;
        private System.Windows.Forms.Button button2;
    }
}