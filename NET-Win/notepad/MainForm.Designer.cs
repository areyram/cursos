namespace notepad
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
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.tss3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.tss4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tss5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnFileNew = new System.Windows.Forms.ToolStripButton();
            this.btnFileOpen = new System.Windows.Forms.ToolStripButton();
            this.btnFileSave = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuView,
            this.mnuWindow});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.mnuWindow;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.mnuFileOpen,
            this.tss1,
            this.mnuFileSave,
            this.mnuFileSaveAs,
            this.toolStripMenuItem1,
            this.mnuFileProperties,
            this.tss3,
            this.mnuFileExit});
            this.mnuFile.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Image = ((System.Drawing.Image)(resources.GetObject("mnuFileNew.Image")));
            this.mnuFileNew.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFileNew.Size = new System.Drawing.Size(152, 22);
            this.mnuFileNew.Text = "&New";
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("mnuFileOpen.Image")));
            this.mnuFileOpen.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFileOpen.Size = new System.Drawing.Size(152, 22);
            this.mnuFileOpen.Text = "&Open";
            // 
            // tss1
            // 
            this.tss1.Name = "tss1";
            this.tss1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Image = ((System.Drawing.Image)(resources.GetObject("mnuFileSave.Image")));
            this.mnuFileSave.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuFileSave.Size = new System.Drawing.Size(152, 22);
            this.mnuFileSave.Text = "&Save";
            // 
            // mnuFileSaveAs
            // 
            this.mnuFileSaveAs.Name = "mnuFileSaveAs";
            this.mnuFileSaveAs.Size = new System.Drawing.Size(152, 22);
            this.mnuFileSaveAs.Text = "Save &As";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuFileProperties
            // 
            this.mnuFileProperties.Name = "mnuFileProperties";
            this.mnuFileProperties.Size = new System.Drawing.Size(152, 22);
            this.mnuFileProperties.Text = "Properties";
            // 
            // tss3
            // 
            this.tss3.Name = "tss3";
            this.tss3.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(152, 22);
            this.mnuFileExit.Text = "E&xit";
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditUndo,
            this.tss4,
            this.mnuEditCut,
            this.mnuEditCopy,
            this.mnuEditPaste,
            this.tss5,
            this.mnuEditSelectAll});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(39, 20);
            this.mnuEdit.Text = "&Edit";
            // 
            // mnuEditUndo
            // 
            this.mnuEditUndo.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuEditUndo.Name = "mnuEditUndo";
            this.mnuEditUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mnuEditUndo.Size = new System.Drawing.Size(164, 22);
            this.mnuEditUndo.Text = "&Undo";
            // 
            // tss4
            // 
            this.tss4.Name = "tss4";
            this.tss4.Size = new System.Drawing.Size(161, 6);
            // 
            // mnuEditCut
            // 
            this.mnuEditCut.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuEditCut.Name = "mnuEditCut";
            this.mnuEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuEditCut.Size = new System.Drawing.Size(164, 22);
            this.mnuEditCut.Text = "Cu&t";
            // 
            // mnuEditCopy
            // 
            this.mnuEditCopy.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuEditCopy.Name = "mnuEditCopy";
            this.mnuEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuEditCopy.Size = new System.Drawing.Size(164, 22);
            this.mnuEditCopy.Text = "&Copy";
            // 
            // mnuEditPaste
            // 
            this.mnuEditPaste.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuEditPaste.Name = "mnuEditPaste";
            this.mnuEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mnuEditPaste.Size = new System.Drawing.Size(164, 22);
            this.mnuEditPaste.Text = "&Paste";
            // 
            // tss5
            // 
            this.tss5.Name = "tss5";
            this.tss5.Size = new System.Drawing.Size(161, 6);
            // 
            // mnuEditSelectAll
            // 
            this.mnuEditSelectAll.Name = "mnuEditSelectAll";
            this.mnuEditSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuEditSelectAll.Size = new System.Drawing.Size(164, 22);
            this.mnuEditSelectAll.Text = "Select &All";
            // 
            // mnuView
            // 
            this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuViewToolbar,
            this.mnuViewStatusBar});
            this.mnuView.Name = "mnuView";
            this.mnuView.Size = new System.Drawing.Size(44, 20);
            this.mnuView.Text = "&View";
            // 
            // mnuViewToolbar
            // 
            this.mnuViewToolbar.Checked = true;
            this.mnuViewToolbar.CheckOnClick = true;
            this.mnuViewToolbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuViewToolbar.Name = "mnuViewToolbar";
            this.mnuViewToolbar.Size = new System.Drawing.Size(126, 22);
            this.mnuViewToolbar.Text = "&Toolbar";
            // 
            // mnuViewStatusBar
            // 
            this.mnuViewStatusBar.Checked = true;
            this.mnuViewStatusBar.CheckOnClick = true;
            this.mnuViewStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuViewStatusBar.Name = "mnuViewStatusBar";
            this.mnuViewStatusBar.Size = new System.Drawing.Size(126, 22);
            this.mnuViewStatusBar.Text = "&Status Bar";
            // 
            // mnuWindow
            // 
            this.mnuWindow.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuWindowCascade,
            this.mnuWindowVertical,
            this.mnuWindowHorizontal,
            this.mnuWindowCloseAll});
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Size = new System.Drawing.Size(68, 20);
            this.mnuWindow.Text = "&Windows";
            // 
            // mnuWindowCascade
            // 
            this.mnuWindowCascade.Name = "mnuWindowCascade";
            this.mnuWindowCascade.Size = new System.Drawing.Size(151, 22);
            this.mnuWindowCascade.Text = "&Cascade";
            // 
            // mnuWindowVertical
            // 
            this.mnuWindowVertical.Name = "mnuWindowVertical";
            this.mnuWindowVertical.Size = new System.Drawing.Size(151, 22);
            this.mnuWindowVertical.Text = "Tile &Vertical";
            // 
            // mnuWindowHorizontal
            // 
            this.mnuWindowHorizontal.Name = "mnuWindowHorizontal";
            this.mnuWindowHorizontal.Size = new System.Drawing.Size(151, 22);
            this.mnuWindowHorizontal.Text = "Tile &Horizontal";
            // 
            // mnuWindowCloseAll
            // 
            this.mnuWindowCloseAll.Name = "mnuWindowCloseAll";
            this.mnuWindowCloseAll.Size = new System.Drawing.Size(151, 22);
            this.mnuWindowCloseAll.Text = "C&lose All";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFileNew,
            this.btnFileOpen,
            this.btnFileSave});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(632, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // btnFileNew
            // 
            this.btnFileNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFileNew.Image = ((System.Drawing.Image)(resources.GetObject("btnFileNew.Image")));
            this.btnFileNew.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnFileNew.Name = "btnFileNew";
            this.btnFileNew.Size = new System.Drawing.Size(23, 22);
            this.btnFileNew.Text = "New";
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnFileOpen.Image")));
            this.btnFileOpen.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(23, 22);
            this.btnFileOpen.Text = "Open";
            // 
            // btnFileSave
            // 
            this.btnFileSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFileSave.Image = ((System.Drawing.Image)(resources.GetObject("btnFileSave.Image")));
            this.btnFileSave.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnFileSave.Name = "btnFileSave";
            this.btnFileSave.Size = new System.Drawing.Size(23, 22);
            this.btnFileSave.Text = "Save";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Status";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator tss1;
        private System.Windows.Forms.ToolStripSeparator tss3;
        private System.Windows.Forms.ToolStripSeparator tss4;
        private System.Windows.Forms.ToolStripSeparator tss5;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowHorizontal;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuEditUndo;
        private System.Windows.Forms.ToolStripMenuItem mnuEditCut;
        private System.Windows.Forms.ToolStripMenuItem mnuEditCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuEditPaste;
        private System.Windows.Forms.ToolStripMenuItem mnuEditSelectAll;
        private System.Windows.Forms.ToolStripMenuItem mnuView;
        private System.Windows.Forms.ToolStripMenuItem mnuViewToolbar;
        private System.Windows.Forms.ToolStripMenuItem mnuViewStatusBar;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowCascade;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowVertical;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowCloseAll;
        private System.Windows.Forms.ToolStripButton btnFileNew;
        private System.Windows.Forms.ToolStripButton btnFileOpen;
        private System.Windows.Forms.ToolStripButton btnFileSave;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileProperties;
    }
}



