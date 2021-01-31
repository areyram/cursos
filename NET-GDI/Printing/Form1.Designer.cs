namespace Ventus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnZoomFit = new System.Windows.Forms.ToolStripButton();
            this.btnZoomIn = new System.Windows.Forms.ToolStripButton();
            this.btnZoomOut = new System.Windows.Forms.ToolStripButton();
            this.btnZoom100 = new System.Windows.Forms.ToolStripButton();
            this.printPreview = new System.Windows.Forms.PrintPreviewControl();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cboPage = new System.Windows.Forms.ToolStripDropDownButton();
            this.cboPage1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cboPage2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cboPage3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrint,
            this.toolStripSeparator1,
            this.btnZoomFit,
            this.btnZoomIn,
            this.btnZoomOut,
            this.btnZoom100,
            this.toolStripSeparator2,
            this.cboPage});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(478, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnPrint
            // 
            this.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(28, 28);
            this.btnPrint.Text = "toolStripButton1";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btnZoomFit
            // 
            this.btnZoomFit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomFit.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomFit.Image")));
            this.btnZoomFit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomFit.Name = "btnZoomFit";
            this.btnZoomFit.Size = new System.Drawing.Size(28, 28);
            this.btnZoomFit.Text = "toolStripButton2";
            this.btnZoomFit.Click += new System.EventHandler(this.btnZoomFit_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomIn.Image")));
            this.btnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(28, 28);
            this.btnZoomIn.Text = "toolStripButton3";
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomOut.Image")));
            this.btnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(28, 28);
            this.btnZoomOut.Text = "toolStripButton4";
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoom100
            // 
            this.btnZoom100.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoom100.Image = ((System.Drawing.Image)(resources.GetObject("btnZoom100.Image")));
            this.btnZoom100.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoom100.Name = "btnZoom100";
            this.btnZoom100.Size = new System.Drawing.Size(28, 28);
            this.btnZoom100.Text = "toolStripButton5";
            this.btnZoom100.Click += new System.EventHandler(this.btnZoom100_Click);
            // 
            // printPreview
            // 
            this.printPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printPreview.Location = new System.Drawing.Point(0, 31);
            this.printPreview.Name = "printPreview";
            this.printPreview.Size = new System.Drawing.Size(478, 532);
            this.printPreview.TabIndex = 2;
            this.printPreview.UseAntiAlias = true;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // cboPage
            // 
            this.cboPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cboPage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cboPage1,
            this.cboPage2,
            this.cboPage3});
            this.cboPage.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPage.Image = ((System.Drawing.Image)(resources.GetObject("cboPage.Image")));
            this.cboPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cboPage.Name = "cboPage";
            this.cboPage.Size = new System.Drawing.Size(31, 28);
            this.cboPage.Text = "1";
            // 
            // cboPage1
            // 
            this.cboPage1.Name = "cboPage1";
            this.cboPage1.Size = new System.Drawing.Size(152, 22);
            this.cboPage1.Text = "1";
            this.cboPage1.Click += new System.EventHandler(this.cboPage1_Click);
            // 
            // cboPage2
            // 
            this.cboPage2.Name = "cboPage2";
            this.cboPage2.Size = new System.Drawing.Size(152, 22);
            this.cboPage2.Text = "2";
            this.cboPage2.Click += new System.EventHandler(this.cboPage2_Click);
            // 
            // cboPage3
            // 
            this.cboPage3.Name = "cboPage3";
            this.cboPage3.Size = new System.Drawing.Size(152, 22);
            this.cboPage3.Text = "3";
            this.cboPage3.Click += new System.EventHandler(this.cboPage3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 563);
            this.Controls.Add(this.printPreview);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Print / Preview";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.PrintPreviewControl printPreview;
        private System.Windows.Forms.ToolStripButton btnZoomFit;
        private System.Windows.Forms.ToolStripButton btnZoomIn;
        private System.Windows.Forms.ToolStripButton btnZoomOut;
        private System.Windows.Forms.ToolStripButton btnZoom100;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton cboPage;
        private System.Windows.Forms.ToolStripMenuItem cboPage1;
        private System.Windows.Forms.ToolStripMenuItem cboPage2;
        private System.Windows.Forms.ToolStripMenuItem cboPage3;
    }
}

