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
    public partial class PDFs : Form
    {
        public PDFs()
        {
            InitializeComponent();
        }

        private void PDFs_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select your PDF file";
            openFileDialog1.Filter = "PDF Files (*.PDF)|*.PDF";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                axAcroPDF1.src = openFileDialog1.FileName;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Videos video = new Videos();
            video.ShowDialog();
            this.Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            oldcur11 oldcurr = new oldcur11();
            oldcurr.ShowDialog();
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
