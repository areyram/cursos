namespace notepad
{
    partial class NoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteForm));
            this.txtDocument = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtDocument
            // 
            this.txtDocument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDocument.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocument.Location = new System.Drawing.Point(0, 0);
            this.txtDocument.Multiline = true;
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(284, 262);
            this.txtDocument.TabIndex = 0;
            this.txtDocument.TextChanged += new System.EventHandler(this.txtDocument_TextChanged);
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtDocument);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NoteForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NoteForm_FormClosing);
            this.Load += new System.EventHandler(this.NoteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDocument;
    }
}

