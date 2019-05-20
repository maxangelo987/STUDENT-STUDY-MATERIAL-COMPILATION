using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Elective
{
    public partial class LogIn : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public LogIn()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Desktop\Elective\Users.accdb;
Persist Security Info=False;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
                
                
                connection.Open();
                
                connection.Close();
     
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from LogInData where username='"+ user_name.Text + "' and password='"+ pass_word.Text +"'";

            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            if (count == 1)
            {
                MessageBox.Show("Username and password is correct");
                connection.Close();
                connection.Dispose();
                this.Hide();
               
                MainApp mainn = new MainApp();
                mainn.ShowDialog();
                this.Close();
            }
            else
            {
                if (count > 1)
                {
                    MessageBox.Show("Duplicate Username and password");
                }
                else
                {
                    MessageBox.Show("Username and password is incorrect");
                }
            }
            connection.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
