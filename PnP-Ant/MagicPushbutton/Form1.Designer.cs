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
            this.btnSave1 = new System.Windows.Forms.Button();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtField1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtField2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtField3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave1
            // 
            this.btnSave1.Location = new System.Drawing.Point(35, 189);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(106, 47);
            this.btnSave1.TabIndex = 0;
            this.btnSave1.Text = "Save";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(210, 189);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(106, 47);
            this.btnSave2.TabIndex = 1;
            this.btnSave2.Text = "Save";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Field 1";
            // 
            // txtField1
            // 
            this.txtField1.Location = new System.Drawing.Point(35, 50);
            this.txtField1.Name = "txtField1";
            this.txtField1.Size = new System.Drawing.Size(281, 22);
            this.txtField1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Field 2";
            // 
            // txtField2
            // 
            this.txtField2.Location = new System.Drawing.Point(35, 95);
            this.txtField2.Name = "txtField2";
            this.txtField2.Size = new System.Drawing.Size(281, 22);
            this.txtField2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Field 3";
            // 
            // txtField3
            // 
            this.txtField3.Location = new System.Drawing.Point(35, 140);
            this.txtField3.Name = "txtField3";
            this.txtField3.Size = new System.Drawing.Size(281, 22);
            this.txtField3.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 267);
            this.Controls.Add(this.txtField3);
            this.Controls.Add(this.txtField2);
            this.Controls.Add(this.txtField1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave2);
            this.Controls.Add(this.btnSave1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtField1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtField2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtField3;
    }
}

