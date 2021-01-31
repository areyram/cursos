using System;
using System.Windows.Forms;

namespace notepad
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            mnuFileNew.Click += (o, e) => NewFile();
            mnuFileOpen.Click += (o, e) => OpenFile();
            mnuFileSave.Click += (o, e) => SaveFile();
            mnuFileSaveAs.Click += (o, e) => SaveFileAs();
            mnuFileProperties.Click += (o, e) => ShowFileProperties();
            mnuFileExit.Click += (o, e) => Close();
            mnuEditUndo.Click += (o, e) => WithActiveChild(f => f.Undo());
            mnuEditCut.Click += (o, e) => WithActiveChild(f => f.Cut());
            mnuEditCopy.Click += (o, e) => WithActiveChild(f => f.Copy());
            mnuEditPaste.Click += (o, e) => WithActiveChild(f => f.Paste());
            mnuEditSelectAll.Click += (o, e) => WithActiveChild(f => f.SelectAll());
            mnuViewToolbar.Click += (o, e) => toolStrip.Visible = mnuViewToolbar.Checked;
            mnuViewStatusBar.Click += (o, e) => statusStrip.Visible = mnuViewStatusBar.Checked;
            mnuWindowCascade.Click += (o, e) => LayoutMdi(MdiLayout.Cascade);
            mnuWindowVertical.Click += (o, e) => LayoutMdi(MdiLayout.TileVertical);
            mnuWindowHorizontal.Click += (o, e) => LayoutMdi(MdiLayout.TileHorizontal);
            mnuWindowCloseAll.Click += (sender, args) => CloseAll();
            btnFileNew.Click += (o, e) => NewFile();
            btnFileOpen.Click += (o, e) => OpenFile();
            btnFileSave.Click += (o, e) => SaveFile();
        }

        private void NewFile()
        {
            var form = new NoteForm
            {
                MdiParent = this,
                IsDirty = false,
                FileName = string.Empty
            };
            form.Show();
        }

        private void OpenFile()
        {
            var openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                CheckFileExists = true,
                Multiselect = true
            };
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                foreach (var fileName in openFileDialog.FileNames)
                {
                    var form = new NoteForm
                    {
                        MdiParent = this,
                        FileName = fileName
                    };
                    form.LoadDocument();
                    form.Show();
                }
            }
        }

        private void SaveFile()
        {
            WithActiveChild(f =>
            {
                if (!string.IsNullOrEmpty(f.FileName))
                    f.SaveDocument();
                else
                    SaveFileAs();
            });
        }

        private void SaveFileAs()
        {
            WithActiveChild(f =>
            {
                var saveFileDialog = new SaveFileDialog
                {
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                    Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
                    OverwritePrompt = true
                };
                if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    f.FileName = saveFileDialog.FileName;
                    f.SaveDocument();
                }
            });
        }

        private void ShowFileProperties()
        {
            WithActiveChild(f =>
                MessageBox.Show(string.Format("{1} lines{0}{2} words{0}{3} characters.",
                    Environment.NewLine, f.LineCount, f.WordCount, f.CharCount),
                    "Document Properties", MessageBoxButtons.OK, MessageBoxIcon.Information));
        }

        private void CloseAll()
        {
            foreach (var childForm in MdiChildren)
                childForm.Close();
        }

        private void WithActiveChild(Action<NoteForm> action)
        {
            var form = ActiveMdiChild as NoteForm;
            if (form != null)
                action(form);
        }
    }
}
