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
using System.IO;

namespace Elective
{
    public partial class MainApp : Form
    {
        private OleDbConnection connection = new OleDbConnection();


        
        public MainApp()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Philiam John\Documents\Visual Studio 2017\Elective\Users.accdb;
Persist Security Info=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           
            oldcur11 old11 = new oldcur11();
            old11.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            newcur newcurr = new newcur();
            newcurr.ShowDialog();
            this.Close();
        }
    }
}
