using Ventus.Controls;

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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.gradientButton2 = new GradientButton();
            this.gradientButton1 = new GradientButton();
            this.progressPie = new ProgressPie();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressPie});
            this.statusStrip.Location = new System.Drawing.Point(0, 140);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(284, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // gradientButton2
            // 
            this.gradientButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gradientButton2.Location = new System.Drawing.Point(85, 80);
            this.gradientButton2.Name = "gradientButton2";
            this.gradientButton2.Size = new System.Drawing.Size(120, 23);
            this.gradientButton2.TabIndex = 1;
            this.gradientButton2.Text = "Stop";
            this.gradientButton2.UseVisualStyleBackColor = true;
            this.gradientButton2.Click += new System.EventHandler(this.gradientButton2_Click);
            // 
            // gradientButton1
            // 
            this.gradientButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gradientButton1.Location = new System.Drawing.Point(85, 33);
            this.gradientButton1.Name = "gradientButton1";
            this.gradientButton1.Size = new System.Drawing.Size(120, 23);
            this.gradientButton1.TabIndex = 1;
            this.gradientButton1.Text = "Start";
            this.gradientButton1.UseVisualStyleBackColor = true;
            this.gradientButton1.Click += new System.EventHandler(this.gradientButton1_Click);
            // 
            // progressPie
            // 
            this.progressPie.BackColor = System.Drawing.Color.Gainsboro;
            this.progressPie.ForeColor = System.Drawing.Color.Red;
            this.progressPie.Name = "progressPie";
            this.progressPie.Value = 25;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.gradientButton2);
            this.Controls.Add(this.gradientButton1);
            this.Controls.Add(this.statusStrip);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.StatusStrip statusStrip;
        private ProgressPie progressPie;
        private GradientButton gradientButton1;
        private GradientButton gradientButton2;
    }
}

