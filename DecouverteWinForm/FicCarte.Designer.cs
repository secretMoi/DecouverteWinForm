using System.ComponentModel;

namespace DecouverteWinForm
{
    partial class FicCarte
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
            this.webBrowserCarte = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserCarte
            // 
            this.webBrowserCarte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserCarte.Location = new System.Drawing.Point(0, 0);
            this.webBrowserCarte.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserCarte.Name = "webBrowserCarte";
            this.webBrowserCarte.Size = new System.Drawing.Size(933, 519);
            this.webBrowserCarte.TabIndex = 0;
            // 
            // FicCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.webBrowserCarte);
            this.Name = "FicCarte";
            this.Text = "Position";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserCarte;
    }
}