using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using J_RFID;
using System.Collections;
using System.Threading;
using System.IO.Ports;



namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public string rfidup;

        RFIDAPI NFC_API = new RFIDAPI();
        internal Connection m_Connection;
        //internal RFIDReader m_ReaderAPI;
        internal G20 m_G20;
        internal bool m_IsConnected;
        private int m_SortColumn = -1;
        private uint m_TagTotalCount;

        int Err = 0;
        string[] UID_ID = new string[500];
        ulong[] UID_Count = new ulong[500];
        //string[] UID_Count = new string[500];
        //string[] memorybank = new string[500];
        string EPC = "", Cardtype = "0";
        ulong EPC_Count = 0;
        Int64 Tim4out = 0;
        //string strAryCom
        private static SerialPort sptCom2;

        public Form1()
        {
            InitializeComponent();

            m_Connection = new Connection(this);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //readbutton.Enabled = true;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openPortToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void totaltagslabel_Click(object sender, EventArgs e)
        {

        }

        private void readbutton_Click(object sender, EventArgs e)
        {

            if (readbutton.Text == "Start")
            {
                multiepccheckBox.Enabled = true;
                startreadingcomboBox.Enabled = true;
                UID_ID = new string[500];
                UID_Count = new ulong[500];
                //UID_Count = new string[500];

                EPC = "";
                EPC_Count = 0;
                timer1.Enabled = true;

                readbutton.Text = "Stop";
                totalTagValueLabel.Visible = true;

                Tim4out = 0;
            }
            else
            {
                // inventorylist.Items.Clear();
                multiepccheckBox.Enabled = true;
                timer1.Enabled = false;
                readbutton.Text = "Start";
            }

            //readbutton.Text = "Stop Reading";

        }


        //void inventoryList_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        //{
        //    if (e.Column != this.m_SortColumn)
        //    {
        //        m_SortColumn = e.Column;
        //        inventorylist.Sorting = SortOrder.Ascending;
        //    }
        //    else
        //    {
        //        if (inventorylist.Sorting == SortOrder.Ascending)
        //            inventorylist.Sorting = SortOrder.Descending;
        //        else

        //            inventorylist.Sorting = SortOrder.Ascending;
        //    }
        //    this.inventorylist.Sort();
        //    this.inventorylist.ListViewItemSorter = new ListViewItemComparer(e.Column, inventorylist.Sorting);

        //}

        private void inventorylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            //System.Windows.Forms.ColumnHeader columnHeader1 = new ColumnHeader();
            //System.Windows.Forms.ColumnHeader columnHeader2 = new ColumnHeader();
            //System.Windows.Forms.ColumnHeader columnHeader3 = new ColumnHeader();

            //columnHeader1.Text = "EPC ID ";
            //columnHeader2.Text = "Tag Count";
            ////columnHeader3.Text = "Availability";

            //inventorylist.Columns.Add(columnHeader1);
            //inventorylist.Columns.Add(columnHeader2);
            ////inventorylist.Columns.Add(columnHeader3);




        }

        private void configtoolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void configToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void clearReportscheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.totalTagValueLabel.Text = "0";
            this.inventorylist.Items.Clear();
            // this.m_TagTable.Clear();
            clearReportscheckBox.Checked = false;
            epctagtextBox.Text = "";
            totalTagValueLabel.Text = "0";


        }



        private void openPortToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }



        private void writeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            G20 obj = new G20();
            obj.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void writeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteForm obj = new WriteForm();
            obj.Show();
        }

        private void setRFPowerLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetRFPower obj = new SetRFPower();
            obj.Show();
        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_Connection.ShowDialog(this);


        }

        private void functionCallstatusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void readRFPowerLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetRFPower obj = new SetRFPower();
            obj.Show();
        }

        private void readerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            G20 obj = new G20();
            obj.Show();
        }





        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }



        private void datacontextMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }

        private void readToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void tagDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void configToolStripMenuItem_Click_2(object sender, EventArgs e)
        {

        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            Tim4out = Tim4out + 10 + Convert.ToInt64(startreadingcomboBox.Text);

            Int64 tmp = 10;
            if (pollingtimecombobox.Text != "--")
                tmp = Convert.ToInt64(pollingtimecombobox.Text);

            if (pollingtimecombobox.Text == "--")
                Tim4out = 0;


            if (Tim4out >= tmp)
            {
                timer1.Enabled = false;
                multiepccheckBox.Enabled = true;
                startreadingcomboBox.Enabled = true;
                //readbutton.Text = "Start";
            }
            string outstr = "";
            if (multiepccheckBox.Checked == true)
                Err = NFC_API.UHF_GetMultiEPC(startreadingcomboBox.Text, out outstr);
            else
                Err = NFC_API.UHF_GetEPC(startreadingcomboBox.Text, out outstr);

            if (Err == 0)
            {
                if (outstr.Length < 10)
                {
                    return;
                }

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

                inventorylist.Items.Clear();

                for (int num = 0; num < 500; num++)
                {

                    if (UID_ID[num] != null)
                    {
                        if (UID_ID[num] != null)

                            if (UID_Count[num] == 0)
                                UID_Count[num] = 1;
                        ulong val = UID_Count[num];
                        rfidup = UID_ID[num];
                        epctagtextBox.Text = UID_ID[num];


                        //inventorylist.Items.Add(num + 1 + " " + UID_ID[num] + "  " + UID_Count[num]);
                        //inventorylist.Items.Add(num + 1 + " EPC : " + UID_ID[num] + "  " + UID_Count[num]);


                        ListViewItem item = new ListViewItem();


                        ListViewItem.ListViewSubItem subItem;
                        string test = Convert.ToString(val);
                        inventorylist.Items.Add(item);


                        subItem = new ListViewItem.ListViewSubItem(item, rfidup);
                        item.SubItems.Add(subItem);
                        subItem = new ListViewItem.ListViewSubItem(item, test);
                        item.SubItems.Add(subItem);


                        totalTagLabel.Visible = true;
                        int tagcount = num + 1;
                        totalTagValueLabel.Text = Convert.ToString(tagcount);


                    }
                }
            }


            else
            {

            }
            //inventorylist.TopItem = inventorylist.Items.Count.GetHashCode() - 1;
        }



        private void connectBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs progressEventArgs)
        {
            m_Connection.connectbutton.Enabled = false;
        }

        private void connectBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs connectEventArgs)
        {
            if (m_Connection.connectbutton.Text == "CONNECT")
            {
                if (connectEventArgs.Result.ToString() == "Connect Succeed")
                {
                    m_Connection.connectbutton.Text = "Disconnect";
                    m_Connection.Close();
                    this.readbutton.Enabled = true;
                    this.readbutton.Text = "Start Reading";
                }
            }

            else if (m_Connection.connectbutton.Text == "Disconnect")
            {
                if (connectEventArgs.Result.ToString() == "Disconnect Succeed")
                {
                }
                this.Text = "WindowsFormsApplication";

            }
            //functioncallStatusLabel.Text = connectEventArgs.Result.ToString();
            m_Connection.connectbutton.Enabled = true;

        }

        private void totaltagvaluelabel_Click(object sender, EventArgs e)
        {

        }

        private void totalTagValueLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void setRFRegulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetRFPower obj = new SetRFPower();
            obj.Show();

        }

        private void readRFRegulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetRFPower obj = new SetRFPower();
            obj.Show();
        }

        private void inventorylist_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void totalTagLabel_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mappingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MappingForm obj = new MappingForm();
            obj.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Default Company Name\UHFREADER\UHF_GUI_Users_Guide V.3.pdf");
        }

        private void epctagtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void multiepccheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        public byte multiepccheckBox_CheckedChanged(string Time, out string outData)
        {

            outData = "";
            int startIndex = 0;
            int millisecondsTimeout = Convert.ToInt32(Time);
            int index = 0;
            try
            {
                byte[] buffer = new byte[] { 0x55, 13 };
                string str = "";
                sptCom2.Write(buffer, 0, 2);
                Thread.Sleep(millisecondsTimeout);
                str = sptCom2.ReadExisting();
                int num4 = 0;
                while (true)
                {
                    if (num4 >= str.Length)
                    {
                        break;
                    }
                    startIndex = str.IndexOf("U", startIndex);
                    index = str.IndexOf("U", (int)(startIndex + 1));
                    if ((startIndex > 0) && ((startIndex + 6) < str.Length))
                    {
                        this.Err = this.crc16(str.Substring(startIndex + 1, (index - 3) - (startIndex + 1)));
                        if (this.Err == 0)
                        {
                            outData = outData + str.Substring(startIndex + 1, (index - 3) - (startIndex + 5)) + ",";
                        }
                        startIndex = index;
                    }
                    if ((index + 6) > str.Length)
                    {
                        break;
                    }
                    num4++;
                }
                return 0;
            }
            catch
            {
                return 1;
            }
        }
        private int crc16(string CRC)
        {
            int num8;
            try
            {
                if (CRC.Length < 2)
                {
                    num8 = 1;
                }
                else
                {
                    byte[] buffer = new byte[CRC.Length / 2];
                    int index = 0;
                    int startIndex = 0;
                    while (true)
                    {
                        bool flag = startIndex < CRC.Length;
                        if (!flag)
                        {
                            int num3 = 0xffff;
                            int num4 = 0x1021;
                            int num5 = 0;
                            int num6 = 0;
                            if (buffer[0] == 0)
                            {
                                num5 = 8;
                                num6 = 1;
                            }
                            startIndex = num5;
                            int num7 = num6;
                            while (true)
                            {
                                flag = startIndex < (buffer.Length * 8);
                                if (!flag)
                                {
                                    num8 = ((num3 & 0xffff) != 0x1d0f) ? 1 : 0;
                                    break;
                                }
                                if ((startIndex % 8) == 0)
                                {
                                    num7++;
                                    num3 ^= (buffer[num7] << 8) & 0xff00;
                                }
                                if ((num3 & 0x8000) != 0)
                                {
                                    num3 = ((num3 << 1) & 0xfffe) ^ num4;
                                }
                                else
                                {
                                    num3 = (num3 << 1) & 0xfffe;
                                }
                                startIndex++;
                            }
                            break;
                        }
                        buffer[index] = (byte)Convert.ToInt32(CRC.Substring(startIndex, 2), 0x10);
                        index++;
                        startIndex += 2;
                    }
                }
            }
            catch
            {
                num8 = 1;
            }
            return num8;
        }



        }


    }

    




        
    
      