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
    public partial class newcur : Form
    {
        private OleDbConnection DBConnection = new OleDbConnection();
        OleDbDataAdapter DataAdapter;
        DataTable LocalDataTable = new DataTable();

        int rowPos = 0;
        int rowNum = 0;
        int first = 0;
        Image FetchedImage;
        public newcur()
        {
            InitializeComponent();
            DBConnection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Desktop\Elective\Users.accdb;
Persist Security Info=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            oldcur11 oldcurr = new oldcur11();
            oldcurr.ShowDialog();
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            PDFs pdf = new PDFs();
            pdf.ShowDialog();
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Videos video = new Videos();
            video.ShowDialog();
            this.Close();
        }

        private void ConnectToDatabase()
        {
            DBConnection.Open();
            if (first > 0)
            {
               
                DataAdapter = new OleDbDataAdapter("SELECT * FROM " + comboBox1.Text + "", DBConnection);
                rowPos = 0;

                DataAdapter.Fill(LocalDataTable);
            }
            first++;
            if (LocalDataTable.Rows.Count != 0)
            {
                rowPos = LocalDataTable.Rows.Count;
            }
        }

        private void RefreshDBConnection()
        {
            if (DBConnection.State.Equals(ConnectionState.Open))
            {
                DBConnection.Close();
                LocalDataTable.Clear();
                ConnectToDatabase();
                rowNum = 0;
                //rowPos = 0;
            }
        }

        private void btnToPB_Click(object sender, EventArgs e)
        {
            RefreshDBConnection();

            rowNum = 0;
            pictureBox2.Image = ReadImageFromDB();
            btnPrev.Enabled = true;
            btnNext.Enabled = true;
            btnToDb.Enabled = false;
            try
            {
                string str = comboBox1.Text;
                str = str.Replace(" ", String.Empty);
                OleDbCommand command = new OleDbCommand();
                command.Connection = DBConnection;
                string query = "SELECT Filename FROM " + str + "";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private byte[] ConvertImageToBytes(Image InputImage)
        {
            Bitmap BmpImage = new Bitmap(InputImage);
            MemoryStream Mystream = new MemoryStream();
            BmpImage.Save(Mystream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] ImageAsBytes = Mystream.ToArray();
            return ImageAsBytes;
        }

        private void StoreData(byte[] ImageAsBytes)
        {
            if (DBConnection.State.Equals(ConnectionState.Closed))
            {
                DBConnection.Open();
            }
            try
            {
                MessageBox.Show("Saving image at index: " + rowPos.ToString());
           
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO " + comboBox1.Text + " (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                MessageBox.Show(ex.StackTrace.ToString());
            }
            finally
            {
                RefreshDBConnection();
            }
        }

        private Image ReadImageFromDB()
        {
            if (rowNum >= 0)
            {
               
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "SELECT * FROM " + comboBox1.Text + " where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }

            }
            Image FetchedImg;

            if (rowNum >= 0)
            {
                byte[] FetchedImgBytes = (byte[])LocalDataTable.Rows[rowNum]["Img"];

                MemoryStream stream = new MemoryStream(FetchedImgBytes);

                FetchedImg = Image.FromStream(stream);
                FetchedImage = FetchedImg;
                return FetchedImg;
            }
            else
            {
                MessageBox.Show("there are no images in the database yet. please reconnect or add some images.");
                return null;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            btnToDb.Enabled = false;
            btnDEL.Enabled = false;
            if (rowNum == 0)
            {
                MessageBox.Show("This is the First Image.");
            }
            else
            {
                rowNum--;
                pictureBox2.Image = ReadImageFromDB();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnToDb.Enabled = false;
            if (rowNum == LocalDataTable.Rows.Count - 1)
            {
                MessageBox.Show("You have reached the Last Image.");
                btnDEL.Enabled = true;
            }
            else
            {
                if (rowNum == LocalDataTable.Rows.Count - 2)
                {
                    btnDEL.Enabled = true;
                    rowNum++;
                    pictureBox2.Image = ReadImageFromDB();
                }
                else
                {
                    btnDEL.Enabled = false;
                    rowNum++;
                    pictureBox2.Image = ReadImageFromDB();
                }
            }
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            try
            {
                LocalDataTable.Rows[rowNum].Delete();
                OleDbCommandBuilder CommandBuilder = new OleDbCommandBuilder(DataAdapter);
                MessageBox.Show("Erased Successfully");
                DataAdapter.Update(LocalDataTable);

                RefreshDBConnection();
                rowNum--;
                //        //pictureBox2.Image = ReadImageFromDB();
                RefreshDBConnection();

                rowNum = 0;
                pictureBox2.Image = ReadImageFromDB();
                btnPrev.Enabled = true;
                btnNext.Enabled = true;
                btnToDb.Enabled = false;
                //btnDEL.Enabled = true;

                string str = comboBox1.Text;
                str = str.Replace(" ", String.Empty);
                OleDbCommand command = new OleDbCommand();
                command.Connection = DBConnection;
                string query = "SELECT Filename FROM " + str + "";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnToDb_Click(object sender, EventArgs e)
        {
            StoreData(ConvertImageToBytes(pictureBox2.Image));
            btnToDb.Enabled = false;
            RefreshDBConnection();

            rowNum = 0;
            pictureBox2.Image = ReadImageFromDB();
            btnPrev.Enabled = true;
            btnNext.Enabled = true;
            btnToDb.Enabled = false;
            btnDEL.Enabled = false;

            string str = comboBox1.Text;
            str = str.Replace(" ", String.Empty);
            OleDbCommand command = new OleDbCommand();
            command.Connection = DBConnection;
            string query = "SELECT Filename FROM " + str + "";
            command.CommandText = query;

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenImagDlg = new OpenFileDialog();
            OpenImagDlg.Title = "Select your JPG image";
            OpenImagDlg.Filter = "JPG Images (*.JPG)|*.JPG";
            if (OpenImagDlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(OpenImagDlg.FileName);
                imgfilename.Text = Path.GetFileNameWithoutExtension(OpenImagDlg.FileName);
                btnToDb.Enabled = true;
            }
        }

        private void newcur_Load(object sender, EventArgs e)
        {
            ConnectToDatabase();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            if (comboBox2.Text == "1st Year - 1st Semester")
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = DBConnection;
                string query = "select * from 011";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["Subjects"].ToString());
                }
            }

            if (comboBox2.Text == "1st Year - 2nd Semester")
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = DBConnection;
                string query = "select * from 012";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["Subjects"].ToString());
                }
            }
            if (comboBox2.Text == "2nd Year - 1st Semester")
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = DBConnection;
                string query = "select * from 021";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["Subjects"].ToString());
                }
            }
            if (comboBox2.Text == "2nd Year - 2nd Semester")
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = DBConnection;
                string query = "select * from 022";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["Subjects"].ToString());
                }
            }
            if (comboBox2.Text == "3rd Year - 1st Semester")
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = DBConnection;
                string query = "select * from 031";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["Subjects"].ToString());
                }
            }
            if (comboBox2.Text == "3rd Year - 2nd Semester")
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = DBConnection;
                string query = "select * from 032";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["Subjects"].ToString());
                }
            }
            if (comboBox2.Text == "4th Year - 1st Semester")
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = DBConnection;
                string query = "select * from 041";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["Subjects"].ToString());
                }
            }
            if (comboBox2.Text == "4th Year - 2nd Semester")
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = DBConnection;
                string query = "select * from 042";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["Subjects"].ToString());
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "1st Year - 1st Semester")
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = DBConnection;
                string query = "select * from 011 where Subjects='" + comboBox1.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = reader["Desc"].ToString();
                }
            }

            if (comboBox2.Text == "1st Year - 2nd Semester")
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = DBConnection;
                string query = "select * from 012 where Subjects='" + comboBox1.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = reader["Desc"].ToString();
                }
            }
            if (comboBox2.Text == "2nd Year - 1st Semester")
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = DBConnection;
                string query = "select * from 021 where Subjects='" + comboBox1.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = reader["Desc"].ToString();
                }
            }
            if (comboBox2.Text == "2nd Year - 2nd Semester")
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = DBConnection;
                string query = "select * from 022 where Subjects='" + comboBox1.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = reader["Desc"].ToString();
                }
            }
            if (comboBox2.Text == "3rd Year - 1st Semester")
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = DBConnection;
                string query = "select * from 031 where Subjects='" + comboBox1.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = reader["Desc"].ToString();
                }
            }
            if (comboBox2.Text == "3rd Year - 2nd Semester")
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = DBConnection;
                string query = "select * from 032 where Subjects='" + comboBox1.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = reader["Desc"].ToString();
                }
            }
            if (comboBox2.Text == "4th Year - 1st Semester")
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = DBConnection;
                string query = "select * from 041 where Subjects='" + comboBox1.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = reader["Desc"].ToString();
                }
            }
            if (comboBox2.Text == "4th Year - 2nd Semester")
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = DBConnection;
                string query = "select * from 042 where Subjects='" + comboBox1.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = reader["Desc"].ToString();
                }
            }
            RefreshDBConnection();

            rowNum = 0;
            pictureBox2.Image = ReadImageFromDB();
            btnPrev.Enabled = true;
            btnNext.Enabled = true;
            btnToDb.Enabled = false;
            //btnDEL.Enabled = true;

            try
            {
                string str = comboBox1.Text;
                str = str.Replace(" ", String.Empty);
                OleDbCommand command = new OleDbCommand();
                command.Connection = DBConnection;
                string query = "SELECT Filename FROM " + str + "";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int gsearch = 0;
            int count = 0;
            string str = comboBox1.Text;
            str = str.Replace(" ", String.Empty);
            string filename = imgfilename.Text;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Filename"].Value.ToString().Contains(filename))
                    {
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = DBConnection;
                        string query = "select * from " + str + " where Filename='" + imgfilename.Text + "'";
                        command.CommandText = query;

                        OleDbDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            rowNum = int.Parse(reader["ID"].ToString());
                            gsearch++;
                            count++;
                        }
                        pictureBox2.Image = ReadImageFromDB();
                        break;
                    }
                }

                if (count == 0)
                {
                    MessageBox.Show("No such image in this subject");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No such image in this subject");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FetchedImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox2.Image = FetchedImage;
        }
       
    }
}
