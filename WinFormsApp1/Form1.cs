using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private User user;
        public Form1()
        {
            InitializeComponent();
            user = new User();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user.Name = NameTxt.Text;
            user.Tel = Telephone.Text;
            user.Address = AddressTxt.Text;

            SaveUserToDatabase(user);

            ClearForm();

        }

        private void ClearForm()
        {
            NameTxt.Text = "";
            Telephone.Text = "";
            AddressTxt.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            user.Birthday = Birthday.Value;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           user.Sex = listBox1.SelectedItem.ToString();
        }

        private void Birthday_ValueChanged(object sender, EventArgs e)
        {
            user.Birthday = Birthday.Value;
        }


        private void SaveUserToDatabase(User user)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "Database.txt"), true))
            {
                outputFile.WriteLine(user.ToString());
            }
        }
    }
}
