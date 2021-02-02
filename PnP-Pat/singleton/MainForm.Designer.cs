namespace singleton
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegular = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSingleton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMain});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mnuMain
            // 
            this.mnuMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegular,
            this.mnuSingleton});
            this.mnuMain.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(48, 20);
            this.mnuMain.Text = "Open";
            // 
            // mnuRegular
            // 
            this.mnuRegular.Image = ((System.Drawing.Image)(resources.GetObject("mnuRegular.Image")));
            this.mnuRegular.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuRegular.Name = "mnuRegular";
            this.mnuRegular.Size = new System.Drawing.Size(155, 22);
            this.mnuRegular.Text = "Regular Form";
            this.mnuRegular.Click += new System.EventHandler(this.mnuRegular_Click);
            // 
            // mnuSingleton
            // 
            this.mnuSingleton.Image = ((System.Drawing.Image)(resources.GetObject("mnuSingleton.Image")));
            this.mnuSingleton.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuSingleton.Name = "mnuSingleton";
            this.mnuSingleton.Size = new System.Drawing.Size(155, 22);
            this.mnuSingleton.Text = "Singleton Form";
            this.mnuSingleton.Click += new System.EventHandler(this.mnuSingleton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuRegular;
        private System.Windows.Forms.ToolStripMenuItem mnuSingleton;
        private System.Windows.Forms.ToolTip toolTip;
    }
}



