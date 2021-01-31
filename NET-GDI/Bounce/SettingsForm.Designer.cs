namespace Ventus
{
    partial class SettingsForm
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
            this.nudN = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudRadius = new System.Windows.Forms.NumericUpDown();
            this.nudGravity = new System.Windows.Forms.NumericUpDown();
            this.nudRestitution = new System.Windows.Forms.NumericUpDown();
            this.nudFriction = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGravity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRestitution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFriction)).BeginInit();
            this.SuspendLayout();
            // 
            // nudN
            // 
            this.nudN.Location = new System.Drawing.Point(148, 7);
            this.nudN.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudN.Name = "nudN";
            this.nudN.Size = new System.Drawing.Size(65, 20);
            this.nudN.TabIndex = 0;
            this.nudN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of balls";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Radius";
            // 
            // nudRadius
            // 
            this.nudRadius.Location = new System.Drawing.Point(148, 33);
            this.nudRadius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRadius.Name = "nudRadius";
            this.nudRadius.Size = new System.Drawing.Size(65, 20);
            this.nudRadius.TabIndex = 0;
            this.nudRadius.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudGravity
            // 
            this.nudGravity.DecimalPlaces = 1;
            this.nudGravity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudGravity.Location = new System.Drawing.Point(148, 59);
            this.nudGravity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudGravity.Name = "nudGravity";
            this.nudGravity.Size = new System.Drawing.Size(65, 20);
            this.nudGravity.TabIndex = 0;
            this.nudGravity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudRestitution
            // 
            this.nudRestitution.DecimalPlaces = 1;
            this.nudRestitution.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudRestitution.Location = new System.Drawing.Point(148, 85);
            this.nudRestitution.Name = "nudRestitution";
            this.nudRestitution.Size = new System.Drawing.Size(65, 20);
            this.nudRestitution.TabIndex = 0;
            this.nudRestitution.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudFriction
            // 
            this.nudFriction.DecimalPlaces = 1;
            this.nudFriction.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudFriction.Location = new System.Drawing.Point(148, 111);
            this.nudFriction.Name = "nudFriction";
            this.nudFriction.Size = new System.Drawing.Size(65, 20);
            this.nudFriction.TabIndex = 0;
            this.nudFriction.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gravity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Restitution";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Friction";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(29, 149);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(161, 149);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 185);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudFriction);
            this.Controls.Add(this.nudRestitution);
            this.Controls.Add(this.nudGravity);
            this.Controls.Add(this.nudRadius);
            this.Controls.Add(this.nudN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGravity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRestitution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFriction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudRadius;
        private System.Windows.Forms.NumericUpDown nudGravity;
        private System.Windows.Forms.NumericUpDown nudRestitution;
        private System.Windows.Forms.NumericUpDown nudFriction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}