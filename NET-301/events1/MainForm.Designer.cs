namespace Ventus
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
            this.mnuSample = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.sample1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sample2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sample3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuSample
            // 
            this.mnuSample.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sample1ToolStripMenuItem,
            this.sample2ToolStripMenuItem,
            this.sample3ToolStripMenuItem});
            this.mnuSample.Name = "mnuSample";
            this.mnuSample.Size = new System.Drawing.Size(58, 20);
            this.mnuSample.Text = "Sample";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSample});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // sample1ToolStripMenuItem
            // 
            this.sample1ToolStripMenuItem.Name = "sample1ToolStripMenuItem";
            this.sample1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sample1ToolStripMenuItem.Text = "Sample 1";
            this.sample1ToolStripMenuItem.Click += new System.EventHandler(this.sample1ToolStripMenuItem_Click);
            // 
            // sample2ToolStripMenuItem
            // 
            this.sample2ToolStripMenuItem.Name = "sample2ToolStripMenuItem";
            this.sample2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sample2ToolStripMenuItem.Text = "Sample 2";
            this.sample2ToolStripMenuItem.Click += new System.EventHandler(this.sample2ToolStripMenuItem_Click);
            // 
            // sample3ToolStripMenuItem
            // 
            this.sample3ToolStripMenuItem.Name = "sample3ToolStripMenuItem";
            this.sample3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sample3ToolStripMenuItem.Text = "Sample 3";
            this.sample3ToolStripMenuItem.Click += new System.EventHandler(this.sample3ToolStripMenuItem_Click);
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
            this.Text = "Sample";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuSample;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem sample1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sample2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sample3ToolStripMenuItem;

    }
}



