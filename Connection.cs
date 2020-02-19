using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using J_RFID;
using System.IO.Ports;

namespace WindowsFormsApplication1
{
    public partial class Connection : Form
    {
       
        private Form1 m_Form1;

        RFIDAPI NFC_API = new RFIDAPI(); 
        int Err = 0;
        string EPC = "", Cardtype = "0";


        public Connection(Form1 form1)
        {
            InitializeComponent();
            m_Form1 = form1;
        }

        public string OpenPortText
        {
            get
            {
                return comportcomboBox.Text;
            }
        }


        

        private void Connection_Load(object sender, EventArgs e)
        {
            string[] strAryCom = null;

            comportcomboBox.Items.Clear();
            comportcomboBox.Text = "";

            strAryCom = SerialPort.GetPortNames();

            for (int i = 0; i < strAryCom.Length; i++)
            {
                comportcomboBox.Items.Add((object)strAryCom[i]);
            }
            if (comportcomboBox.Items.Count > 0 && comportcomboBox.Text == "") comportcomboBox.Text = comportcomboBox.Items[0].ToString();
        }

        private void comportcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void connectbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (connectbutton.Text == "Connect")
                {

                    Err = NFC_API.UHC_OpenReader(comportcomboBox.Text);
                    if (Err != 0)
                    {
                        openportlistBox.Items.Add("Open COM Err " + Err);
                        return;
                        //Response.Redirect("Form1.cs");
                        
                    }



                    string Str = "";
                    Err = NFC_API.UHF_FwVersion(out Str);
                    openportlistBox.Items.Add("Firmware Version : " + Str);

                    Err = NFC_API.UHF_ReaderID(out Str);
                    openportlistBox.Items.Add("Reader ID : " + Str);

                    openportlistBox.Items.Add("Connected");

                    this.Close();

                    //Connection obj = new Connection();
                    //obj.Show();
                   
                    connectbutton.Text = "Disconnect";
                    comportcomboBox.Enabled = false;

                    //button40.Enabled = true;
                    //button41.Enabled = true;
                    //button42.Enabled = true;
                    //button43.Enabled = true;
                    //////button7.Enabled = true;
                    //button8.Enabled = true;
                    //button9.Enabled = true;
                    //button22.Enabled = true;
                    connectbutton.Enabled = true;
                }
                else if (connectbutton.Text == "Disconnect")
                {


                    connectbutton.Text = "Connect";
                    NFC_API.UHF_CloseReader(comportcomboBox.Text);
                    comportcomboBox.Enabled = true;
                    openportlistBox.Items.Clear();
                    //button40.Enabled = false;
                    //button41.Enabled = false;
                    //button42.Enabled = false;
                    //button43.Enabled = false;

                    //button8.Enabled = false;
                    //button9.Enabled = false;
                    //button22.Enabled = false;
                    connectbutton.Enabled = true;

                }
            }
            catch
            {
                NFC_API.UHF_CloseReader(comportcomboBox.Text);
            }
            ////try
            ////{
            ////    m_Form1.connectbackgroundWorker.RunWorkerAsync(connectbutton.Text);
            ////}

            ////catch (Exception ex)
            ////{
            ////    m_Form1.functioncallStatusLabel.Text = ex.Message;
            ////}
            
        }

        private void openportbutton_Click(object sender, EventArgs e)
        {
            string[] strAryCom = null;

            comportcomboBox.Items.Clear();
            comportcomboBox.Text = "";

            strAryCom = SerialPort.GetPortNames();

            for (int i = 0; i < strAryCom.Length; i++)
            {
                comportcomboBox.Items.Add((object)strAryCom[i]);
            }
            if (comportcomboBox.Items.Count > 0 && comportcomboBox.Text == "") comportcomboBox.Text = comportcomboBox.Items[0].ToString();

        }

        private void openportlistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comportcomboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string[] strAryCom = null;

        //    comportcomboBox.Items.Clear();
        //    comportcomboBox.Text = "";

        //    for (int i = 0; i < strAryCom.Length; i++)
        //    {
        //        comportcomboBox.Items.Add((object)strAryCom[i]);
        //    }
        //    if (comportcomboBox.Items.Count > 0 && comportcomboBox.Text == "") comportcomboBox.Text = comportcomboBox.Items[0].ToString();

        //}


        }
              
        }
    

