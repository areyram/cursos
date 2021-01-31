using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using notepad.Properties;

namespace notepad
{
    public partial class NoteForm : Form
    {
        private bool isDirty;

        public NoteForm()
        {
            InitializeComponent();
        }

        private void NoteForm_Load(object sender, System.EventArgs e)
        {
            IsDirty = false;
        }

        public string FileName
        {
            get { return Text; }
            set { Text = value; }
        }

        public string Document
        {
            get { return txtDocument.Text; }
            set { txtDocument.Text = value; }
        }

        public int LineCount
        {
            get { return txtDocument.Lines.Length; }
        }

        public int WordCount
        {
            get { return new Regex(@"\w+").Matches(txtDocument.Text).Count; }
        }

        public int CharCount
        {
            get { return txtDocument.Text.Length; }
        }

        public bool IsDirty
        {
            get { return isDirty; }
            set
            {
                isDirty = value;
                Icon = isDirty ? Resources.yellow_ball : Resources.blue_ball;
            }
        }

        public void Undo()
        {
            txtDocument.Undo();
        }

        public void Cut()
        {
            txtDocument.Cut();
        }

        public void Copy()
        {
            txtDocument.Copy();
        }

        public void Paste()
        {
            txtDocument.Paste();
        }

        public void SelectAll()
        {
            txtDocument.SelectAll();
        }

        private void txtDocument_TextChanged(object sender, System.EventArgs e)
        {
            IsDirty = true;
        }

        private void NoteForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsDirty)
            {
                if (MessageBox.Show("Se perderán los cambios", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    e.Cancel = true;
            }
        }

        public void LoadDocument()
        {
            Document = File.ReadAllText(FileName);
            IsDirty = false;
        }

        public void SaveDocument()
        {
            File.WriteAllText(FileName, Document);
            IsDirty = false;
        }
    }
}