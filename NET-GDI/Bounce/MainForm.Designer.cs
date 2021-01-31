namespace Ventus
{
    sealed partial class MainForm
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
            this.animate = new System.Windows.Forms.Timer(this.components);
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuConfigure = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // animate
            // 
            this.animate.Interval = 10;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConfigure});
            this.menu.Name = "contextMenuStrip1";
            this.menu.Size = new System.Drawing.Size(128, 26);
            // 
            // mnuConfigure
            // 
            this.mnuConfigure.Name = "mnuConfigure";
            this.mnuConfigure.Size = new System.Drawing.Size(127, 22);
            this.mnuConfigure.Text = "Configure";
            this.mnuConfigure.Click += new System.EventHandler(this.mnuConfigure_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.ContextMenuStrip = this.menu;
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "MainForm";
            this.Text = "Bounce";
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer animate;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mnuConfigure;
    }
}

