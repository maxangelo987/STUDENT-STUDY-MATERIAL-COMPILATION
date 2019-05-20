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
    public partial class oldcur11 : Form
    {
        private OleDbConnection DBConnection = new OleDbConnection();
        OleDbDataAdapter DataAdapter;
        DataTable LocalDataTable = new DataTable();

        int rowPos = 0;
        int rowNum = 0;
        Image FetchedImage;
        public oldcur11()
        {
            InitializeComponent();
            DBConnection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Desktop\Elective\Users.accdb;
Persist Security Info=False;";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }


        //--------------------------------------------------------------//
        //     JOBS THAT NEED TO BE DONE AS SOON AS FORM LOADS          //
        //--------------------------------------------------------------//
        private void oldcur11_Load(object sender, EventArgs e)
        {
            ConnectToDatabase();
        }

        
        //----------------------------------------------------------------------------//
        //<<<<<<<<------FUNCTION USED TO CONNECT TO DB---------------->>>>>>>>>>>>>>
        //----------------------------------------------------------------------------//
        private void ConnectToDatabase()
        {
            DBConnection.Open();
            if (comboBox1.Text == "Math 1")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Math1", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Math 2")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Math2", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Chem 1")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Chem1", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Comptech 1")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Comptech1", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Draw 1")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Draw1", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Engl 1")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Engl1", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Fil 1")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Fil1", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "NSTP 1")
            {
                DataAdapter = new OleDbDataAdapter("Select * From NSTP1", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "PE 1")
            {
                DataAdapter = new OleDbDataAdapter("Select * From PE1", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Comptech 2")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Comptech2", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Draw 2")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Draw2", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Engl 2")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Engl2", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Fil 2")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Fil2", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Math 0")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Math0", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Math 1A")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Math1A", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Math 3")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Math3", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "NSTP 2")
            {
                DataAdapter = new OleDbDataAdapter("Select * From NSTP2", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "PE 2")
            {
                DataAdapter = new OleDbDataAdapter("Select * From PE2", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Phys 1")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Phys1", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Comp 1")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Comp1", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Comptech 3")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Comptech3", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "CPE 211")
            {
                DataAdapter = new OleDbDataAdapter("Select * From CPE211", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "CS 311")
            {
                DataAdapter = new OleDbDataAdapter("Select * From CS311", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "ES 211")
            {
                DataAdapter = new OleDbDataAdapter("Select * From ES211", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Hum 1")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Hum1", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Math 4")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Math4", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "PE 3")
            {
                DataAdapter = new OleDbDataAdapter("Select * From PE3", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Phys 2")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Phys2", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Soc Sci 1")
            {
                DataAdapter = new OleDbDataAdapter("Select * From SocSci1", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Comptech 4")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Comptech4", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "CPE 221")
            {
                DataAdapter = new OleDbDataAdapter("Select * From CPE221", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Engl 3")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Engl3", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "ES 1")
            {
                DataAdapter = new OleDbDataAdapter("Select * From ES1", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Hum 2")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Hum2", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Math 5")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Math5", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Math 8")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Math8", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "PE 4")
            {
                DataAdapter = new OleDbDataAdapter("Select * From PE4", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Soc Sci 2")
            {
                DataAdapter = new OleDbDataAdapter("Select * From SocSci2", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "CPE 311")
            {
                DataAdapter = new OleDbDataAdapter("Select * From CPE311", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "CPE 312")
            {
                DataAdapter = new OleDbDataAdapter("Select * From CPE312", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "EE 311")
            {
                DataAdapter = new OleDbDataAdapter("Select * From EE311", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "EE 312")
            {
                DataAdapter = new OleDbDataAdapter("Select * From EE312", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "EE 313")
            {
                DataAdapter = new OleDbDataAdapter("Select * From EE313", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "ES 4")
            {
                DataAdapter = new OleDbDataAdapter("Select * From ES4", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Math 6")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Math6", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Mech 1A")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Mech1A", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "CPE 321")
            {
                DataAdapter = new OleDbDataAdapter("Select * From CPE321", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "CPE 323")
            {
                DataAdapter = new OleDbDataAdapter("Select * From CPE323", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "EE 321")
            {
                DataAdapter = new OleDbDataAdapter("Select * From EE321", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "EE 323")
            {
                DataAdapter = new OleDbDataAdapter("Select * From EE323", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "ES 2")
            {
                DataAdapter = new OleDbDataAdapter("Select * From ES2", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "ES 3")
            {
                DataAdapter = new OleDbDataAdapter("Select * From ES3", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Math 7")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Math7", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Mech 1B")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Mech1B", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Mech 2")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Mech2", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "CPE 411")
            {
                DataAdapter = new OleDbDataAdapter("Select * From CPE411", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "CPE 412")
            {
                DataAdapter = new OleDbDataAdapter("Select * From CPE412", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "CPE 413")
            {
                DataAdapter = new OleDbDataAdapter("Select * From CPE413", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "CPE 414")
            {
                DataAdapter = new OleDbDataAdapter("Select * From CPE414", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "CPE 415")
            {
                DataAdapter = new OleDbDataAdapter("Select * From CPE415", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "EE 322")
            {
                DataAdapter = new OleDbDataAdapter("Select * From EE322", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "EE 411")
            {
                DataAdapter = new OleDbDataAdapter("Select * From EE411", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "CPE 421")
            {
                DataAdapter = new OleDbDataAdapter("Select * From CPE421", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "CPE 422")
            {
                DataAdapter = new OleDbDataAdapter("Select * From CPE422", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "CPE 423")
            {
                DataAdapter = new OleDbDataAdapter("Select * From CPE423", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "CPE 424")
            {
                DataAdapter = new OleDbDataAdapter("Select * From CPE424", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "CPE 425")
            {
                DataAdapter = new OleDbDataAdapter("Select * From CPE425", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "CPE 426")
            {
                DataAdapter = new OleDbDataAdapter("Select * From CPE426", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Elective 1")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Elective1", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Research")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Research", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Soc Sci 3")
            {
                DataAdapter = new OleDbDataAdapter("Select * From SocSci3", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "CPE 511")
            {
                DataAdapter = new OleDbDataAdapter("Select * From CPE511", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "CPE 512")
            {
                DataAdapter = new OleDbDataAdapter("Select * From CPE512", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "CPE 513")
            {
                DataAdapter = new OleDbDataAdapter("Select * From CPE513", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "CPE 514")
            {
                DataAdapter = new OleDbDataAdapter("Select * From CPE514", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "CPE 515")
            {
                DataAdapter = new OleDbDataAdapter("Select * From CPE515", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "CPE 516")
            {
                DataAdapter = new OleDbDataAdapter("Select * From CPE516", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Elective 2")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Elective2", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "ME 1B")
            {
                DataAdapter = new OleDbDataAdapter("Select * From ME1B", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "CPE 521")
            {
                DataAdapter = new OleDbDataAdapter("Select * From CPE521", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "CPE 522")
            {
                DataAdapter = new OleDbDataAdapter("Select * From CPE522", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "CPE 523")
            {
                DataAdapter = new OleDbDataAdapter("Select * From CPE523", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "CPE 524")
            {
                DataAdapter = new OleDbDataAdapter("Select * From CPE524", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Elective 3")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Elective3", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Hum 3")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Hum3", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Rizal 1")
            {
                DataAdapter = new OleDbDataAdapter("Select * From Rizal1", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }
            if (comboBox1.Text == "Soc Sci 4")
            {
                DataAdapter = new OleDbDataAdapter("Select * From SocSci4", DBConnection);
                rowPos = 0;
                DataAdapter.Fill(LocalDataTable);
            }


            if (LocalDataTable.Rows.Count != 0)
            {
                rowPos = LocalDataTable.Rows.Count;
            }
        }

        private void RefreshDBConnection()
        {
            if(DBConnection.State.Equals(ConnectionState.Open))
            {
                DBConnection.Close();
                LocalDataTable.Clear();
                ConnectToDatabase();
                rowNum = 0;
                //rowPos = 0;
            }
        }
        //----------------------------------------------------------------------------//
        //<<<<<<<<------FUNCTIONS USED TO SAVE DATA TO DB---------------->>>>>>>>>>>>>>
        //----------------------------------------------------------------------------//
        private void btnBrowse_Click_1(object sender, EventArgs e)
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

        private void btnToDb_Click_1(object sender, EventArgs e)
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
                if (comboBox1.Text == "Math 1")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Math1 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Math 2")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Math2 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Chem 1")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Chem1 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Comptech 1")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Comptech1 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Draw 1")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Draw1 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Engl 1")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Engl1 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Fil 1")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Fil1 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "NSTP 1")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO NSTP1 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "PE 1")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO PE1 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if(comboBox1.Text == "Comptech 2")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Comptech2 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Draw 2")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Draw2 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Engl 2")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Engl2 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Fil 2")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Fil2 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Math 0")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Math0 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Math 1A")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Math1A (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Math 3")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Math3 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "NSTP 2")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO NSTP2 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "PE 2")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO PE2 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Phys 1")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Phys1 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Comp 1")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Comp1 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Comptech 3")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Comptech3 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "CPE 211")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO CPE211 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "CS 311")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO CS311 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "ES 211")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO ES211 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Hum 1")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Hum1 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Math 4")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Math4 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "PE 3")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO PE3 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Phys 2")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Phys2 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Soc Sci 1")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO SocSci1 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Comptech 4")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Comptech4 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "CPE 221")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO CPE221 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Engl 3")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Engl3 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "ES 1")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO ES1 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Hum 2")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Hum2 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Math 5")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Math5 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Math 8")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Math8 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "PE 4")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO PE4 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Soc Sci 2")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO SocSci2 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "CPE 311")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO CPE311 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "CPE 312")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO CPE312 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "EE 311")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO EE311 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "EE 312")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO EE312 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "EE 313")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO EE313 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "ES 4")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO ES44 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Math 6")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Math6 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Mech 1A")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Mech1A (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "CPE 321")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO CPE321 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "CPE 323")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO CPE323 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "EE 321")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO EE321 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "EE 323")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO EE323 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "ES 2")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO ES2 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "ES 3")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO ES3 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Math 7")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Math7 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Mech 1B") 
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Mech1B (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Mech 2")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Mech2 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "CPE 411")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO CPE411 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "CPE 412")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO CPE412 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "CPE 413")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO CPE413 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "CPE 414")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO CPE414 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "CPE 415")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO CPE415 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "EE 322")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO EE322 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "EE 411")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO EE411 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "CPE 421")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO CPE421 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "CPE 422")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO CPE422 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "CPE 423")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO CPE423 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "CPE 424")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO CPE424 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "CPE 425")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO CPE425 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "CPE 426")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO CPE426 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Elective 1")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Elective1 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Research")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Research (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Soc Sci 3")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO SocSci3 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "CPE 511")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO CPE511 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "CPE 512")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO CPE512 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "CPE 513")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO CPE513 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "CPE 514")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO CPE514 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "CPE 515")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO CPE515 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "CPE 516")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO CPE516 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Elective 2")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Elective2 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "ME 1B")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO ME1B (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "CPE 521")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO CPE521 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "CPE 522")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO CPE522 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "CPE 523")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO CPE523 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "CPE 524")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO CPE524 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Elective 3")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Elective3 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Hum 3")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Hum3 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Rizal 1")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO Rizal1 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
                if (comboBox1.Text == "Soc Sci 4")
                {
                    OleDbCommand OledbInsert = new OleDbCommand("Insert INTO SocSci4 (ID,Img,Filename) VALUES('" + rowPos.ToString() + "',@MyImg,'" + imgfilename.Text.ToString() + "')", DBConnection);
                    OleDbParameter imageParameter = OledbInsert.Parameters.AddWithValue("@Img", SqlDbType.Binary);
                    imageParameter.Value = ImageAsBytes;
                    imageParameter.Size = ImageAsBytes.Length;

                    int rowsAffected = OledbInsert.ExecuteNonQuery();
                    MessageBox.Show("Data Stored successfully in " + rowsAffected.ToString() + " Row");
                    rowPos++;
                }
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




        //----------------------------------------------------------------------------//
        //<<<<<<<<------FUNCTIONS TO READ DATA FROM DB TO PICTURE BOX-------->>>>>>>>>
        //----------------------------------------------------------------------------//
        private void btnToPB_Click(object sender, EventArgs e)
        {
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


        private Image ReadImageFromDB()
        {
            if (rowNum >= 0)
            {
                if (comboBox1.Text == "Math 1")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Math1 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Math 2")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Math2 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Chem 1")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Chem1 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Comptech 1")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Comptech1 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Draw 1")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Draw1 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Engl 1")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Engl1 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Fil 1")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Comptech1 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "NSTP 1")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from NSTP1 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "PE 1")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from PE1 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Comptech 2")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Comptech2 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Draw 2")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Draw2 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Engl 2")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Engl2 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Fil 2")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Fil2 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Math 0")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Math0 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Math 1A")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Math1A where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Math 3")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Math3 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "NSTP 2")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from NSTP2 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "PE 2")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from PE2 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Phys 1")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Phys1 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Comp 1")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Comp1 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Comptech 3")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Comptech3 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "CPE 211")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from CPE211 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "CS 311")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from CS311 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "ES 211")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from ES211 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Hum 1")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Hum1 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Math 4")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Math4 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "PE 3")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from PE3 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Phys 2")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Phys2 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Soc Sci 1")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from SocSci1 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Comptech 4")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Comptech4 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "CPE 221")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from CPE221 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Engl 3")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Engl3 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "ES 1")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from ES1 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Hum 2")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Hum2 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Math 5")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Math5 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Math 8")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Math8 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "PE 4")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from PE4 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Soc Sci 2")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from SocSci2 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "CPE 311")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from CPE311 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "CPE 312")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from CPE312 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "EE 311")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from EE311 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "EE 312")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from EE312 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "EE 313")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from EE313 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "ES 4")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from ES4 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Math 6")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Math6 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Mech 1A")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Mech1A where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "CPE 321")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from CPE321 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "CPE 323")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from CPE323 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "EE 321")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from EE321 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "EE 323")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from EE323 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "ES 2")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from ES2 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "ES 3")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from ES3 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Math 7")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Math7 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Mech 1B")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Mech1B where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Mech 2")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Mech2 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "CPE 411")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from CPE411 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "CPE 412")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from CPE412 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "CPE 413")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from CPE413 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "CPE 414")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from CPE414 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "CPE 415")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from CPE415 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "EE 322")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from EE322 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "EE 411")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from EE411 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "CPE 421")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from CPE421 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "CPE 422")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from CPE422 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "CPE 423")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from CPE423 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "CPE 424")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from CPE424 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "CPE 425")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from CPE425 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "CPE 426")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from CPE426 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Elective 1")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Elective1 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Research")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Research where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Soc Sci 3")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from SocSci3 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "CPE 511")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from CPE511 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "CPE 512")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from CPE512 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "CPE 513")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from CPE513 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "CPE 514")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from CPE514 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "CPE 515")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from CPE515 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "CPE 516")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from CPE516 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Elective 2")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Elective2 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "ME 1B")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from ME1B where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "CPE 521")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from CPE521 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "CPE 522")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from CPE522 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "CPE 523")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from CPE523 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "CPE 524")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from CPE524 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Elective 3")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Elective3 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Hum 3")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Hum3 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Rizal 1")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from Rizal1 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
                }
                if (comboBox1.Text == "Soc Sci 4")
                {
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = DBConnection;
                    string query = "select * from SocSci4 where [ID]=" + rowNum + "";
                    command.CommandText = query;

                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        imgfilename.Text = reader["Filename"].ToString();
                    }
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnToDb.Enabled = false;
            if (rowNum == LocalDataTable.Rows.Count-1)
            {
                 MessageBox.Show("You have reached the Last Image.");
                btnDEL.Enabled = true;
            }
            else
            {
                if (rowNum == LocalDataTable.Rows.Count-2)
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


        //----------------------------------------------------------------------------//
        //<<<<<<<<------FUNCTIONS TO DELETE DATA FROM DB TO PICTURE BOX-------->>>>>>>>>
        //----------------------------------------------------------------------------//

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
               catch(Exception ex)
                {
                MessageBox.Show(ex.ToString());
                }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FetchedImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox2.Image = FetchedImage;
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

        private void imgfilename_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            if (comboBox2.Text == "1st Year - 1st Semester")
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = DBConnection;
                string query = "select * from 11";
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
                string query = "select * from 12";
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
                string query = "select * from 21";
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
                string query = "select * from 22";
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
                string query = "select * from 31";
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
                string query = "select * from 32";
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
                string query = "select * from 41";
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
                string query = "select * from 42";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["Subjects"].ToString());
                }
            }
            if (comboBox2.Text == "5th Year - 1st Semester")
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = DBConnection;
                string query = "select * from 51";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["Subjects"].ToString());
                }
            }
            if (comboBox2.Text == "5th Year - 2nd Semester")
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = DBConnection;
                string query = "select * from 52";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["Subjects"].ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            newcur newcurr = new newcur();
            newcurr.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "1st Year - 1st Semester")
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = DBConnection;
                string query = "select * from 11 where Subjects='" + comboBox1.Text + "'";
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
                string query = "select * from 12 where Subjects='" + comboBox1.Text + "'";
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
                string query = "select * from 21 where Subjects='" + comboBox1.Text + "'";
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
                string query = "select * from 22 where Subjects='" + comboBox1.Text + "'";
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
                string query = "select * from 31 where Subjects='" + comboBox1.Text + "'";
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
                string query = "select * from 32 where Subjects='" + comboBox1.Text + "'";
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
                string query = "select * from 41 where Subjects='" + comboBox1.Text + "'";
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
                string query = "select * from 42 where Subjects='" + comboBox1.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = reader["Desc"].ToString();
                }
            }
            if (comboBox2.Text == "5th Year - 1st Semester")
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = DBConnection;
                string query = "select * from 51 where Subjects='" + comboBox1.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = reader["Desc"].ToString();
                }
            }
            if (comboBox2.Text == "5th Year - 2nd Semester")
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = DBConnection;
                string query = "select * from 52 where Subjects='" + comboBox1.Text + "'";
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
