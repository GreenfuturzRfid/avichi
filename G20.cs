using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using J_RFID;
using System.IO;
using System.IO.Ports;

namespace WindowsFormsApplication1
{
    public partial class G20 : Form
    {
        private Form1 m_Form1;

        RFIDAPI NFC_API = new RFIDAPI();
        int Err = 0;

        ulong[] TAG_Count = new ulong[500];
        string EPC = "", Cardtype = "0";
        ulong EPC_Count = 0;

        string[] UID_ID = new string[500];
        ulong[] UID_Count = new ulong[500];
        
        Int64 Tim4out = 0;

        internal G20 m_G20;



        public G20()
        {
            InitializeComponent();

        }

        
        
        private void readRFPowerLevelbutton_Click(object sender, EventArgs e)
        {
            string outstr = "";
            Err = NFC_API.UHF_GetPowerlevel(out outstr);
            if (Err == 0)
                listBox1.Items.Add("Power : " + outstr);
            else
                listBox1.Items.Add("Err : " + Err);
            listBox1.TopIndex = listBox1.Items.Count.GetHashCode() - 1;
        }

        //private void readbutton_Click(object sender, EventArgs e)
        //{
        //    string data = "";
        //    Err = NFC_API.UHF_RBlock((lengthcomboBox1.SelectedIndex + 1).ToString(), usercomboBox1.SelectedIndex.ToString(), readblocktextBox.Text, out data);
        //    listBox1.Items.Add("Block : " + data);
        //    listBox1.TopIndex = listBox1.Items.Count.GetHashCode() - 1;
        
        //}

       

        private void G20_Load(object sender, EventArgs e)
        {
            string[] strAryCom = null;
           
            strAryCom = SerialPort.GetPortNames();

            //for (int i = 0; i < strAryCom.Length; i++)
            //{
            //    //lengthcomboBox1.Items.Add((object)strAryCom[i]);
            //}
            ////if (lengthcomboBox1.Items.Count > 0 && lengthcomboBox1.Text == "") lengthcomboBox1.Text = lengthcomboBox1.Items[0].ToString();

        }

        //private void lengthcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        //private void usercomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        private void datalabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "START")
            {

                UID_ID = new string[500];
                UID_Count = new ulong[500];

                EPC = "";
                EPC_Count = 0;
                timer1.Enabled = true;

                button1.Text = "STOP";
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
                button1.Text = "START";
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
                readingcomboBox.Enabled = true;
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
                        epctagtextBox.Text = UID_ID[num];

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

        private void clearbutton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            epctagtextBox.Text = " ";
            UID_ID = new string[500];
            UID_Count = new ulong[500];
            EPC = "";
            EPC_Count = 0;

        }

        private void multiepccheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void startreadingcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void readbutton_Click(object sender, EventArgs e)
        {
            
            string data = " ";
            Err = NFC_API.UHF_RBlock((readlengthcomboBox.SelectedIndex + 1).ToString(),  readingcomboBox.SelectedIndex.ToString(), readblockdatatextBox.Text, out data);
            listBox1.Items.Add("Block : " + data);
            listBox1.TopIndex = listBox1.Items.Count.GetHashCode() - 1;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void readingcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void readblockdatatextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


       


    }
}
