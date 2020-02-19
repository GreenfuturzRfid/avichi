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
    public partial class SetRFPower : Form
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

        public SetRFPower()
        {
            InitializeComponent();
        }

        private void setRFPowerLevelbutton_Click(object sender, EventArgs e)
        {
           
            Err = NFC_API.UHF_SetPowerlevel(textBox1.Text);
            if (Err == 0)
                listBox1.Items.Add("Set Power OK");
            else
                listBox1.Items.Add("Err : " + Err);

            listBox1.TopIndex = listBox1.Items.Count.GetHashCode() - 1;
        
        }

        private void setregulationbutton_Click(object sender, EventArgs e)
        {
            //int Select = comboBox1.SelectedIndex;
            //switch (Select)
            //{
            //    case 0:
            //        Err = NFC_API.UHF_SetRegulation("01");
            //        break;
            //    case 1:
            //        Err = NFC_API.UHF_SetRegulation("02");
            //        break;
            //    case 2:
            //        Err = NFC_API.UHF_SetRegulation("03");
            //        break;
            //    case 3:
            //        Err = NFC_API.UHF_SetRegulation("04");
            //        break;
            //    case 4:
            //        Err = NFC_API.UHF_SetRegulation("05");
            //        break;
            //    default:
            //        return;
            //}

            if (Err == 0)
                listBox1.Items.Add("Set OK");
            else
                listBox1.Items.Add("Set fail");

            listBox1.TopIndex = listBox1.Items.Count.GetHashCode() - 1;

        }

        private void readregulationbutton_Click(object sender, EventArgs e)
        {
            string outstr = "";
            Err = NFC_API.UHF_GetRegulation(out outstr);
            if (Err == 0)
                listBox1.Items.Add(outstr);
            else
                listBox1.Items.Add("Err : " + Err);

            listBox1.TopIndex = listBox1.Items.Count.GetHashCode() - 1;
        }

        private void SetRFPower_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
            
         

            

        }
    }
