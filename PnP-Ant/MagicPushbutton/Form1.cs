using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ventus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //NO
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtField1.Text))
            {
                MessageBox.Show("Please enter Field 1");
                return;
            }
            var cn = new SqlConnection("connectionstring");
            cn.Open();
            var cmd = new SqlCommand("EntrySave", cn) { CommandType = CommandType.StoredProcedure };
            cmd.Parameters.AddWithValue("@Field1", txtField1.Text);
            cmd.Parameters.AddWithValue("@Field2", txtField2.Text);
            cmd.Parameters.AddWithValue("@Field3", txtField3.Text);
            cmd.ExecuteNonQuery();
        }

        //YES
        private void btnSave2_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;
            DAC.Entry.Save(Collect());
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtField1.Text))
            {
                MessageBox.Show("Please enter Field 1");
                return false;
            }
            return true;
        }

        private BE.Entry Collect()
        {
            return new BE.Entry
            {
                Field1 = txtField1.Text,
                Field2 = txtField2.Text,
                Field3 = txtField3.Text
            };
        }
    }

        #region Hide

    internal class DAC
    {
        public class Entry
        {
            public static void Save(BE.Entry entry)
            {
                //TODO:
            }
        }
    }

    internal class BE
    {
        internal class Entry
        {
            internal string Field1 { get; set; }
            internal string Field2 { get; set; }
            internal string Field3 { get; set; }
        }
    }

    #endregion
}
