using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using J_RFID;


namespace WindowsFormsApplication1
{
    public partial class WriteForm : Form
    {
        private Form1 m_Form1;

        RFIDAPI NFC_API = new RFIDAPI();
        int Err = 0;
        ulong[] TAG_Count = new ulong[500];
        string EPC = "", Cardtype = "0";
        ulong EPC_Count = 0;

        string[] UID_ID = new string[500];
        ulong[] UID_Count = new ulong[500];
        internal G20 m_G20;
        Int64 Tim4out = 0;


        public WriteForm()
        {
            InitializeComponent();
        }

        private void WriteForm_Load(object sender, EventArgs e)
        {

        }

        private void writebutton_Click(object sender, EventArgs e)
        {
            string data = datawritetextBox.Text, tmp = "";
            switch (data.Length)
            {
                case 0:
                    data = "0000";
                    break;
                case 1:
                    data = "000" + data;
                    break;
                case 2:
                    data = "00" + data;
                    break;
                case 3:
                    data = "0" + data;
                    break;

            }
            Err = NFC_API.UHF_WBlock(writecomboBox.SelectedIndex.ToString(), blockwritetextBox.Text, data, out tmp);

            
            

            listBox1.Items.Add("Write : " + tmp);
            listBox1.TopIndex = listBox1.Items.Count.GetHashCode() - 1;


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
                //readingcomboBox.Enabled = true;
                //readbutton.Text = "START";
            }
            string outstr = "";
            if (multiepccheckBox.Checked == true)
                Err = NFC_API.UHF_GetMultiEPC(comboBox2.Text, out outstr);
            else
                Err = NFC_API.UHF_GetEPC(comboBox2.Text, out outstr);
            //Err = NFC_API.UHF_RBlock("8", "", "2", out outstr);
            //Err = NFC_API.UHF_GetEPC(comboBox2.Text, out outstr);



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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void blockwritetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void writeblocllabel_Click(object sender, EventArgs e)
        {

        }

        private void epctagtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string outstr = "";
            if (multiepccheckBox.Checked == true)
                Err = NFC_API.UHF_GetMultiEPC(comboBox2.Text, out outstr);
            else
                Err = NFC_API.UHF_GetEPC(comboBox2.Text, out outstr);
            //Err = NFC_API.UHF_RBlock("8", "", "2", out outstr);
            //Err = NFC_API.UHF_GetEPC(comboBox2.Text, out outstr);

            //Err = NFC_API.UHF_RBlock("4", "1", "2", out outstr);

            //Block 
            //Input 10 chars
            //string block = blockwritetextBox.Text;
            //string existingtxt24 = epctagtextBox.Text;
            //int splitblock = 0;
            //if(block == "3")
            //    splitblock=5;
            //if(block == "4")
            //    splitblock=9;
            //if(block == "

            //string split1 = existingtxt24.Substring(splitblock, (splitblock - 24);

            //outstr = split1;
            //

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
        }
    }

}
    
    
