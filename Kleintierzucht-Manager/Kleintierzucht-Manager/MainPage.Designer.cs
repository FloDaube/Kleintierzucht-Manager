namespace Kleintierzucht_Manager
{
    partial class MainPage
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
            this.panel_MenuLeft = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.panel_MenuLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_MenuLeft
            // 
            this.panel_MenuLeft.Controls.Add(this.panel_Logo);
            this.panel_MenuLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_MenuLeft.Location = new System.Drawing.Point(0, 0);
            this.panel_MenuLeft.Name = "panel_MenuLeft";
            this.panel_MenuLeft.Size = new System.Drawing.Size(250, 450);
            this.panel_MenuLeft.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(250, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 37);
            this.panel2.TabIndex = 1;
            // 
            // panel_Logo
            // 
            this.panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(250, 100);
            this.panel_Logo.TabIndex = 0;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_MenuLeft);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.panel_MenuLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_MenuLeft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_Logo;
    }
}