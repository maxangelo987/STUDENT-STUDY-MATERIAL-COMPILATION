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
    public partial class Videos : Form
    {
       
        public Videos()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            PDFs pdf = new PDFs();
            pdf.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            newcur newcurr = new newcur();
            newcurr.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            oldcur11 oldcurr = new oldcur11();
            oldcurr.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select your Video or Audio file";
            openFileDialog1.Filter = "Video/Audio Files (*.MP4;*.M4V;*.MP4V;*.3G2;*.3GP2;*.3GP;*.3GPP;*.AVI;*.AAC;*.ADT;*.ADTS;*.M4A;*.FLAC;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U)|*.MP4;*.M4V;*.MP4V;*.3G2;*.3GP2;*.3GP;*.3GPP;*.AVI;*.AAC;*.ADT;*.ADTS;*.M4A;*.FLAC;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            }
        }
    }
}
