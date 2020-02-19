using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using J_RFID;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApplication1
{

    public partial class MappingForm : Form
    {

        private Form1 m_Form1;
        public string rfidup;

        RFIDAPI NFC_API = new RFIDAPI();
        int Err = 0;
        ulong[] TAG_Count = new ulong[500];
        string EPC = "", Cardtype = "0";
        ulong EPC_Count = 0;

        string[] UID_ID = new string[500];
        ulong[] UID_Count = new ulong[500];
        internal G20 m_G20;
        Int64 Tim4out = 0;

        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        public MappingForm()
        {
            InitializeComponent();
        }

        private void mappingcheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (mappingcheckBox.Checked)
            {
                listBox1.Visible = true;
                button3.Visible = true;
                textBox1.Visible = true;
                dataGridView1.Visible = true;
                //openFileDialog1();

            }

            dataGridView1.Columns.Clear();
            for (int num = 0; num < 500; num++)
            {

                if (UID_ID[num] != null)
                {
                    if (UID_ID[num] != null)

                        if (UID_Count[num] == 0)
                            UID_Count[num] = 1;
                    ulong val = UID_Count[num];
                    rfidup = UID_ID[num];
                    //epctagtextBox.Text = UID_ID[num];
                    ListViewItem item = new ListViewItem();
                    ListViewItem.ListViewSubItem subItem;


                    string test = Convert.ToString(val);

                    string select = "select min(sno) as sno from Gtable where Flg=1";
                    SqlConnection connectionString1 = new SqlConnection("Data Source=DESKTOP-QQ08PLJ\\GREEN;Initial Catalog=G20;User ID=sa;Password=tiger@1234");
                    SqlCommand cmd2 = new SqlCommand(select, connectionString1);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    ada.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {


                        string no = dt.Rows[0]["sno"].ToString();
                        //string qry = "update Gtable set rfid='" + rfidup + "',Flg='0' where sno='" + no + "'";
                        //string qry = "update Gtable set rfid='" + rfidup + "'' where sno='" + no + "'";
                        string qry = "update Gtable set rfid=' " + rfidup + "' where sno='" + no + "'";

                        SqlConnection connectionString = new SqlConnection("Data Source=DESKTOP-QQ08PLJ\\GREEN;Initial Catalog=G20;User ID=sa;Password=tiger@1234");
                        SqlCommand cmd1 = new SqlCommand(qry, connectionString);
                        connectionString.Open();
                        int k = cmd1.ExecuteNonQuery();
                        connectionString.Close();
                        string select1 = "select SNO,REFNO,RFID from Gtable";
                        SqlConnection connectionString2 = new SqlConnection("Data Source=DESKTOP-QQ08PLJ\\GREEN;Initial Catalog=G20;User ID=sa;Password=tiger@1234");
                        SqlCommand cmd3 = new SqlCommand(select1, connectionString2);
                        SqlDataAdapter ada1 = new SqlDataAdapter(cmd3);
                        DataTable dtss = new DataTable();
                        ada1.Fill(dtss);
                        if (dtss.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dtss;
                            label3.Text = dtss.Rows.Count.ToString();

                        }


                        else
                        {

                        }

                    }
                    else
                    {

                    }
                    // dataGridView1.Columns.Add(RFID);
                    //inventorylist.Items.Add(item);
                    subItem = new ListViewItem.ListViewSubItem(item, rfidup);
                    item.SubItems.Add(subItem);
                    subItem = new ListViewItem.ListViewSubItem(item, test);
                    item.SubItems.Add(subItem);


                    //totalTagLabel.Visible = true;
                    //int tagcount = num + 1;
                    //totalTagValueLabel.Text = Convert.ToString(tagcount);

                }


                else
                {
                    listBox1.Visible = true;
                    button3.Visible = false;
                    textBox1.Visible = true;
                    dataGridView1.Visible = true;
                   
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (readbutton.Text == "START")
            {

                UID_ID = new string[500];
                UID_Count = new ulong[500];

                EPC = "";
                EPC_Count = 0;
                timer1.Enabled = true;

                readbutton.Text = "STOP";
                // label5.Visible = false;

                //label6.Visible = false;
                Tim4out = 0;

            }
            else
            {
                ////checkBox15.Enabled = true;
                //checkBox14.Enabled = true;
                //// comboBox3.Enabled = true;
                // comboBox4.Enabled = true;
                timer1.Enabled = false;
                readbutton.Text = "START";
            }

        }

        private void multiepccheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            readbutton.Visible = true;
            mappingcheckBox.Visible = true;
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

            //this.dataGridView1.Size = new Size(500,250);
            string qrywww = "truncate table Gtable";

            SqlConnection connectionString11 = new SqlConnection("Data Source=DESKTOP-QQ08PLJ\\GREEN;Initial Catalog=G20;User ID=sa;Password=tiger@1234");
            SqlCommand cmd11 = new SqlCommand(qrywww, connectionString11);
            connectionString11.Open();
            int kk = cmd11.ExecuteNonQuery();
            connectionString11.Close();
            string filePath = openFileDialog1.FileName;
            string extension = Path.GetExtension(filePath);
            string header = rbHeaderYes.Checked ? "YES" : "NO";
            string conStr, sheetName;

            conStr = string.Empty;
            switch (extension)
            {

                case ".xls": //Excel 97-03
                    conStr = string.Format(Excel03ConString, filePath, header);
                    break;

                case ".xlsx": //Excel 07
                    conStr = string.Format(Excel07ConString, filePath, header);
                    break;
            }

            //Get the name of the First Sheet.
            using (OleDbConnection con = new OleDbConnection(conStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    con.Open();
                    DataTable dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                    con.Close();
                }
            }

            //Read Data from the First Sheet.
            using (OleDbConnection con = new OleDbConnection(conStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    using (OleDbDataAdapter oda = new OleDbDataAdapter())
                    {
                        DataTable dt = new DataTable();
                        cmd.CommandText = "SELECT * From [" + sheetName + "]";
                        cmd.Connection = con;
                        con.Open();
                        oda.SelectCommand = cmd;
                        oda.Fill(dt);
                        con.Close();

                        foreach (DataRow dr in dt.Rows)
                        {
                            string SNO = dr["SNO"].ToString();
                            string REFNO = dr["REFNO"].ToString();
                            string RFID = dr["RFID"].ToString();

                            string qry = "insert into Gtable(SNO,REFNO,RFID) values ('" + SNO + "','" + REFNO + "','" + RFID + "')";

                            SqlConnection connectionString = new SqlConnection("Data Source=DESKTOP-QQ08PLJ\\GREEN;Initial Catalog=G20;User ID=sa;Password=tiger@1234");
                            SqlCommand cmd1 = new SqlCommand(qry, connectionString);
                            connectionString.Open();
                            int k = cmd1.ExecuteNonQuery();
                            connectionString.Close();


                        }
                      


                        string select = "select * from Gtable";
                        SqlConnection connectionString1 = new SqlConnection("Data Source=DESKTOP-QQ08PLJ\\GREEN;Initial Catalog=G20;User ID=sa;Password=tiger@1234");
                        SqlCommand cmd2 = new SqlCommand(select, connectionString1);
                        SqlDataAdapter ada = new SqlDataAdapter(cmd2);
                        DataTable ds = new DataTable();
                        ada.Fill(ds);

                        if (dt.Rows.Count > 0)
                        {

                            dataGridView1.DataSource = dt;
                            label3.Text = dt.Rows.Count.ToString();
                           

                        }
                        else
                        {

                        }
                        


                        //Populate DataGridView.
                        // dataGridView1.DataSource = dt;

                        
                    }
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tim4out = Tim4out + 10 + Convert.ToInt64(comboBox2.Text);
            Int64 tmp = 10;
            Tim4out = 0;

            if (Tim4out >= tmp)
            {
                timer1.Enabled = false;
                multiepccheckBox.Enabled = true;
                //readingcomboBox.Enabled = true;
                //readbutton.Text = "START";
            }
            string outstr = "";
            if (multiepccheckBox.Checked == true)
                Err = NFC_API.UHF_GetMultiEPC(comboBox2.Text, out outstr);
            else
                Err = NFC_API.UHF_GetEPC(comboBox2.Text, out outstr);

            if (Err == 0)
            {
                for (int len = 0; len < outstr.Length; len = len + 24)
                {
                    for (int num = 0; num < 500; num++)
                    {
                        if (UID_ID[num] == outstr.Substring(len, 24))
                        {
                            UID_Count[num] = UID_Count[num] + 1;
                            break;
                        }
                        if (UID_ID[num] == null)
                        {
                            UID_ID[num] = outstr.Substring(len, 24);
                            break;
                        }

                    }
                }

                listBox1.Items.Clear();
                for (int num = 0; num < 500; num++)
                {
                    
                    if (UID_ID[num] != null)
                    {
                        if (UID_ID[num] != null)

                            if (UID_Count[num] == 0)
                                UID_Count[num] = 1;
                        // rfidup = UID_ID[num];

                        textBox1.Text = UID_ID[num];

                        listBox1.Items.Add(UID_ID[num] + " " + UID_Count[num]);
                        //totaltagvaluelabel.Visible = true;
                        int tagcount = num + 1;
                        //totaltagvaluelabel.Text = Convert.ToString(tagcount);
                    }
                }
            }


            else
            {
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ////this.dataGridView1.Size = new Size(500, 500);
            //DataGridViewColumn column = dataGridView1.Columns[0];
            //column.Width = 160;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox1.Text = "";
            UID_ID = new string[500];
            UID_Count = new ulong[500];
            EPC = "";
            EPC_Count = 0;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MappingForm_Load(object sender, EventArgs e)
        {
            readbutton.Visible = false;
            mappingcheckBox.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //if (mappingcheckBox.Checked)
            //{
            //    listBox1.Visible = true;
            //    button3.Visible = true;
            //    textBox1.Visible = true;
            //    dataGridView1.Visible = true;
            //    //openFileDialog1();

            //}

            //dataGridView1.Columns.Clear();
            //for (int num = 0; num < 500; num++)
            //{

            //    if (UID_ID[num] != null)
            //    {
            //        if (UID_ID[num] != null)

            //            if (UID_Count[num] == 0)
            //                UID_Count[num] = 1;
            //        ulong val = UID_Count[num];
            //        rfidup = UID_ID[num];
            //        //epctagtextBox.Text = UID_ID[num];
            //        ListViewItem item = new ListViewItem();
            //        ListViewItem.ListViewSubItem subItem;


            //        string test = Convert.ToString(val);

            //        string select = "select min(sno) as sno from Gtable where Flg=1";
            //        SqlConnection connectionString1 = new SqlConnection("Data Source=DESKTOP-QQ08PLJ\\GREEN;Initial Catalog=G20;User ID=sa;Password=tiger@1234");
            //        SqlCommand cmd2 = new SqlCommand(select, connectionString1);
            //        SqlDataAdapter ada = new SqlDataAdapter(cmd2);
            //        DataTable dt = new DataTable();
            //        ada.Fill(dt);

            //        if (dt.Rows.Count > 0)
            //        {


            //            string no = dt.Rows[0]["sno"].ToString();
            //            //string qry = "update Gtable set rfid='" + rfidup + "',Flg='0' where sno='" + no + "'";
            //            string qry = "update Gtable set rfid='" + rfidup + "'' where sno='" + no + "'";


            //            SqlConnection connectionString = new SqlConnection("Data Source=DESKTOP-QQ08PLJ\\GREEN;Initial Catalog=G20;User ID=sa;Password=tiger@1234");
            //            SqlCommand cmd1 = new SqlCommand(qry, connectionString);
            //            connectionString.Open();
            //            int k = cmd1.ExecuteNonQuery();
            //            connectionString.Close();
            //            string select1 = "select SNO,REFNO,RFID from Gtable";
            //            SqlConnection connectionString2 = new SqlConnection("Data Source=DESKTOP-QQ08PLJ\\GREEN;Initial Catalog=G20;User ID=sa;Password=tiger@1234");
            //            SqlCommand cmd3 = new SqlCommand(select1, connectionString2);
            //            SqlDataAdapter ada1 = new SqlDataAdapter(cmd3);
            //            DataTable dtss = new DataTable();
            //            ada1.Fill(dtss);
            //            if (dtss.Rows.Count > 0)
            //            {
            //                dataGridView1.DataSource = dtss;
            //                label3.Text = dtss.Rows.Count.ToString();

            //            }


            //            else
            //            {

            //            }

            //        }
            //        else
            //        {

            //        }
            //        // dataGridView1.Columns.Add(RFID);
            //        //inventorylist.Items.Add(item);
            //        subItem = new ListViewItem.ListViewSubItem(item, rfidup);
            //        item.SubItems.Add(subItem);
            //        subItem = new ListViewItem.ListViewSubItem(item, test);
            //        item.SubItems.Add(subItem);


            //        //totalTagLabel.Visible = true;
            //        //int tagcount = num + 1;
            //        //totalTagValueLabel.Text = Convert.ToString(tagcount);

            //    }


            //    else
            //    {
            //        listBox1.Visible = true;
            //        button3.Visible = false;
            //        textBox1.Visible = true;
            //        dataGridView1.Visible = true;
            //    }
            //}
        }

        private void readbutton_Click(object sender, EventArgs e)
        {
            if (readbutton.Text == "START")
            {

                UID_ID = new string[500];
                UID_Count = new ulong[500];

                EPC = "";
                EPC_Count = 0;
                timer1.Enabled = true;

                readbutton.Text = "STOP";
                // label5.Visible = false;

                //label6.Visible = false;
                Tim4out = 0;

            }
            else
            {
                ////checkBox15.Enabled = true;
                //checkBox14.Enabled = true;
                //// comboBox3.Enabled = true;
                // comboBox4.Enabled = true;
                timer1.Enabled = false;
                readbutton.Text = "START";
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (mappingcheckBox.Checked)
            {
                listBox1.Visible = true;
                button3.Visible = true;
                textBox1.Visible = true;
                dataGridView1.Visible = true;
                //openFileDialog1();

            }

            dataGridView1.Columns.Clear();
            for (int num = 0; num < 500; num++)
            {

                if (UID_ID[num] != null)
                {
                    if (UID_ID[num] != null)

                        if (UID_Count[num] == 0)
                            UID_Count[num] = 1;
                    ulong val = UID_Count[num];
                    rfidup = UID_ID[num];
                    //rfidup=UID_ID[num + 1];
                    //epctagtextBox.Text = UID_ID[num];
                    
                    ListViewItem item = new ListViewItem();
                    ListViewItem.ListViewSubItem subItem;


                    string test = Convert.ToString(val);

                    string select11 = "select SNO,REFNO,RFID from Gtable";
                    SqlConnection connectionString2 = new SqlConnection("Data Source=DESKTOP-QQ08PLJ\\GREEN;Initial Catalog=G20;User ID=sa;Password=tiger@1234");
                    SqlCommand cmd31 = new SqlCommand(select11, connectionString2);
                    SqlDataAdapter ada11 = new SqlDataAdapter(cmd31);
                    DataTable dtss1 = new DataTable();
                    ada11.Fill(dtss1);
                    if (dtss1.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dtss1;
                        label3.Text = dtss1.Rows.Count.ToString();
                    }


                    string select = "select min(sno) as sno from Gtable where Flg=1";
                    SqlConnection connectionString1 = new SqlConnection("Data Source=DESKTOP-QQ08PLJ\\GREEN;Initial Catalog=G20;User ID=sa;Password=tiger@1234");
                    SqlCommand cmd2 = new SqlCommand(select, connectionString1);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    ada.Fill(dt);


                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-QQ08PLJ\\GREEN;Initial Catalog=G20;User ID=sa;Password=tiger@1234");
                    DataSet ds = new DataSet();
    
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    cmd.Connection = con;
                    string qry = " select * from Gtable where rfid='' order by sno asc";
                    adapter = new SqlDataAdapter(qry, con);
                    
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        string sno = ds.Tables[0].Rows[0]["SNO"].ToString();

                        SqlConnection con1 = new SqlConnection("Data Source=DESKTOP-QQ08PLJ\\GREEN;Initial Catalog=G20;User ID=sa;Password=tiger@1234");
                        foreach (DataGridViewRow row in this.dataGridView1.Rows)
                        {

                            DataSet ds1 = new DataSet();
                            con1.Open();
                            SqlCommand cmdd1 = new SqlCommand();
                            SqlDataAdapter adapter1 = new SqlDataAdapter();
                            cmdd1.Connection = con1;
                            
                            
                            string qryy = "select * from Gtable where rfid='" + rfidup + "' order by sno asc";
                            
                            adapter1 = new SqlDataAdapter(qryy, con1);
                            adapter1.Fill(ds1);
                            dataGridView1.DataSource = ds1.Tables[0];
                            if (ds1.Tables[0].Rows.Count > 0)
                            {
                                sno = ds1.Tables[0].Rows[0]["SNO"].ToString();
                                con1.Close();
                            }

                            else
                            {
                                string no = dt.Rows[0]["sno"].ToString();
                                
                                string qry1 = "update Gtable set rfid='" + rfidup + "',Flg='0' where sno='" + no + "'";
                                //string qry1 = "update Gtable set rfid='" + rfidup + "' where sno='" + no + "'";

                                SqlConnection connectionString = new SqlConnection("Data Source=DESKTOP-QQ08PLJ\\GREEN;Initial Catalog=G20;User ID=sa;Password=tiger@1234");
                                SqlCommand cmd1 = new SqlCommand(qry1, connectionString);
                                connectionString.Open();
                                int k = cmd1.ExecuteNonQuery();
                                connectionString.Close();
                                string select1 = "select SNO,REFNO,RFID from Gtable";
                                SqlConnection connectionString21 = new SqlConnection("Data Source=DESKTOP-QQ08PLJ\\GREEN;Initial Catalog=G20;User ID=sa;Password=tiger@1234");
                                SqlCommand cmd3 = new SqlCommand(select1, connectionString21);
                                SqlDataAdapter ada1 = new SqlDataAdapter(cmd3);
                                DataTable dtss = new DataTable();
                                ada1.Fill(dtss);


                                if (dtss.Rows.Count > 0)
                                {
                                    dataGridView1.DataSource = dtss;
                                    label3.Text = dtss.Rows.Count.ToString();


                                }
                                else
                                {


                                }
                                con1.Close();

                            }
                            //else
                            //{

                            //}

                            // dataGridView1.Columns.Add(RFID);
                            //inventorylist.Items.Add(item);
                            subItem = new ListViewItem.ListViewSubItem(item, rfidup);
                            item.SubItems.Add(subItem);
                            subItem = new ListViewItem.ListViewSubItem(item, test);
                            item.SubItems.Add(subItem);


                            //totalTagLabel.Visible = true;
                            //int tagcount = num + 1;
                            //totalTagValueLabel.Text = Convert.ToString(tagcount);

                        }
                    }


                    else
                    {
                        listBox1.Visible = true;
                        button3.Visible = false;
                        textBox1.Visible = true;
                        dataGridView1.Visible = true;
                    }
                }


            }
            if (mappingcheckBox.Checked)
            {
                listBox1.Visible = true;
                button3.Visible = true;
                textBox1.Visible = true;
                dataGridView1.Visible = true;
                //openFileDialog1();

            }

            dataGridView1.Columns.Clear();
            for (int num = 0; num < 500; num++)
            {

                
                if (UID_ID[num] != null)
                {
                    if (UID_ID[num] != null)

                        if (UID_Count[num] == 0)
                            UID_Count[num] = 1;
                    ulong val = UID_Count[num];
                    rfidup = UID_ID[num];
                    //epctagtextBox.Text = UID_ID[num];
                    ListViewItem item = new ListViewItem();
                    ListViewItem.ListViewSubItem subItem;


                    string test = Convert.ToString(val);

                    string select = "select min(sno) as sno from Gtable where Flg=1";
                    SqlConnection connectionString1 = new SqlConnection("Data Source=DESKTOP-QQ08PLJ\\GREEN;Initial Catalog=G20;User ID=sa;Password=tiger@1234");
                    SqlCommand cmd2 = new SqlCommand(select, connectionString1);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    ada.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {


                        string no = dt.Rows[0]["sno"].ToString();
                        //string qry = "update Gtable set rfid='" + rfidup + "',Flg='0' where sno='" + no + "'";
                        string qry = "update Gtable set rfid='" + rfidup + "'' where sno='" + no + "'";


                        SqlConnection connectionString = new SqlConnection("Data Source=DESKTOP-QQ08PLJ\\GREEN;Initial Catalog=G20;User ID=sa;Password=tiger@1234");
                        SqlCommand cmd4 = new SqlCommand(qry, connectionString);
                        connectionString.Open();
                        //int kk = cmd4.ExecuteNonQuery();
                        connectionString.Close();
                        string select2 = "select SNO,REFNO,RFID from Gtable";
                        SqlConnection connectionString2 = new SqlConnection("Data Source=DESKTOP-QQ08PLJ\\GREEN;Initial Catalog=G20;User ID=sa;Password=tiger@1234");
                        SqlCommand cmd3 = new SqlCommand(select2, connectionString2);
                        SqlDataAdapter ada11 = new SqlDataAdapter(cmd3);
                        DataTable dtss1 = new DataTable();
                        ada11.Fill(dtss1);
                        if (dtss1.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dtss1;
                            label3.Text = dtss1.Rows.Count.ToString();

                        }


                        else
                        {

                        }

                    }
                    else
                    {

                    }
                    // dataGridView1.Columns.Add(RFID);
                    //inventorylist.Items.Add(item);
                    subItem = new ListViewItem.ListViewSubItem(item, rfidup);
                    item.SubItems.Add(subItem);
                    subItem = new ListViewItem.ListViewSubItem(item, test);
                    item.SubItems.Add(subItem);


                    //totalTagLabel.Visible = true;
                    //int tagcount = num + 1;
                    //totalTagValueLabel.Text = Convert.ToString(tagcount);

                }


                else
                {
                    listBox1.Visible = true;
                    button3.Visible = false;
                    textBox1.Visible = true;
                    dataGridView1.Visible = true;
                }
            }
        }



        private void rbHeaderNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            string qry = "Delete from Gtable";

            SqlConnection connectionString = new SqlConnection("Data Source=DESKTOP-QQ08PLJ\\GREEN;Initial Catalog=G20;User ID=sa;Password=tiger@1234");
            SqlCommand cmd1 = new SqlCommand(qry, connectionString);
            connectionString.Open();
            int k = cmd1.ExecuteNonQuery();
            connectionString.Close();
            string select1 = "select sno,refno,rfid from Gtable";
            SqlConnection connectionString2 = new SqlConnection("Data Source=DESKTOP-QQ08PLJ\\GREEN;Initial Catalog=G20;User ID=sa;Password=tiger@1234");
            SqlCommand cmd3 = new SqlCommand(select1, connectionString2);
            SqlDataAdapter ada1 = new SqlDataAdapter(cmd3);
            DataTable dtss = new DataTable();
            ada1.Fill(dtss);

            if (dtss.Rows.Count > 0)
            {
                dataGridView1.DataSource = dtss;
                label3.Text = dtss.Rows.Count.ToString();

            }
            else
            {
                dataGridView1.DataSource = null;
                label3.Text = dtss.Rows.Count.ToString();

            }



        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            if (mappingcheckBox.Checked)
            {
                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                // see the excel sheet behind the program  
                app.Visible = true;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "Exported from gridview";
                // storing header part in Excel  
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // save the application  
                workbook.SaveAs("C:\\Program Files(x86)\\Default Company Name\\UHFREADER\\Export details.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application  
                app.Quit();
            }
            else
            {
                StreamWriter myOutputStream = new StreamWriter(@"C:\Program Files (x86)\Default Company Name\UHFREADER\Myfile.csv");

                foreach (string item in listBox1.Items)
                {
                    string[] lines1 = item.Split(' ');
                    //string stemp1 = lines1[0];
                    string stemp1 = lines1[6];

                    myOutputStream.WriteLine(stemp1.ToString());
                    //MessageBox.Show("Programs saved!");
                }
                myOutputStream.Close();
            }
        }
    }
}







