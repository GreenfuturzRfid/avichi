namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.readbutton = new System.Windows.Forms.Button();
            this.clearReportscheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.readerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mappingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setRFPowerLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readRFPowerLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setRFRegulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readRFRegulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datacontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.readToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.writeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startreadingcomboBox = new System.Windows.Forms.ComboBox();
            this.multiepccheckBox = new System.Windows.Forms.CheckBox();
            this.epctagtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalTagLabel = new System.Windows.Forms.Label();
            this.totalTagValueLabel = new System.Windows.Forms.Label();
            this.pollingtimecombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inventorylist = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.datacontextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // readbutton
            // 
            this.readbutton.Location = new System.Drawing.Point(12, 44);
            this.readbutton.Name = "readbutton";
            this.readbutton.Size = new System.Drawing.Size(90, 38);
            this.readbutton.TabIndex = 3;
            this.readbutton.Text = "Start";
            this.readbutton.UseVisualStyleBackColor = false;
            this.readbutton.Click += new System.EventHandler(this.readbutton_Click);
            // 
            // clearReportscheckBox
            // 
            this.clearReportscheckBox.AutoSize = true;
            this.clearReportscheckBox.Location = new System.Drawing.Point(521, 58);
            this.clearReportscheckBox.Name = "clearReportscheckBox";
            this.clearReportscheckBox.Size = new System.Drawing.Size(87, 17);
            this.clearReportscheckBox.TabIndex = 6;
            this.clearReportscheckBox.Text = "ClearReports";
            this.clearReportscheckBox.UseVisualStyleBackColor = true;
            this.clearReportscheckBox.CheckedChanged += new System.EventHandler(this.clearReportscheckBox_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readerToolStripMenuItem,
            this.configToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(619, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // readerToolStripMenuItem
            // 
            this.readerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem});
            this.readerToolStripMenuItem.Name = "readerToolStripMenuItem";
            this.readerToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.readerToolStripMenuItem.Text = "&Reader";
            this.readerToolStripMenuItem.Click += new System.EventHandler(this.readerToolStripMenuItem_Click);
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.connectionToolStripMenuItem.Text = "Connection";
            this.connectionToolStripMenuItem.Click += new System.EventHandler(this.connectionToolStripMenuItem_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readToolStripMenuItem,
            this.writeToolStripMenuItem,
            this.mappingToolStripMenuItem,
            this.setRFPowerLevelToolStripMenuItem,
            this.readRFPowerLevelToolStripMenuItem,
            this.setRFRegulationToolStripMenuItem,
            this.readRFRegulationToolStripMenuItem});
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.configToolStripMenuItem.Text = "&Config";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click_2);
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.readToolStripMenuItem.Text = "Read";
            this.readToolStripMenuItem.Click += new System.EventHandler(this.readToolStripMenuItem_Click);
            // 
            // writeToolStripMenuItem
            // 
            this.writeToolStripMenuItem.Name = "writeToolStripMenuItem";
            this.writeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.writeToolStripMenuItem.Text = "Write";
            this.writeToolStripMenuItem.Click += new System.EventHandler(this.writeToolStripMenuItem_Click);
            // 
            // mappingToolStripMenuItem
            // 
            this.mappingToolStripMenuItem.Name = "mappingToolStripMenuItem";
            this.mappingToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.mappingToolStripMenuItem.Text = "Mapping";
            this.mappingToolStripMenuItem.Click += new System.EventHandler(this.mappingToolStripMenuItem_Click);
            // 
            // setRFPowerLevelToolStripMenuItem
            // 
            this.setRFPowerLevelToolStripMenuItem.Name = "setRFPowerLevelToolStripMenuItem";
            this.setRFPowerLevelToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.setRFPowerLevelToolStripMenuItem.Text = "SetRFPowerLevel";
            this.setRFPowerLevelToolStripMenuItem.Click += new System.EventHandler(this.setRFPowerLevelToolStripMenuItem_Click);
            // 
            // readRFPowerLevelToolStripMenuItem
            // 
            this.readRFPowerLevelToolStripMenuItem.Name = "readRFPowerLevelToolStripMenuItem";
            this.readRFPowerLevelToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.readRFPowerLevelToolStripMenuItem.Text = "ReadRFPowerLevel";
            this.readRFPowerLevelToolStripMenuItem.Click += new System.EventHandler(this.readRFPowerLevelToolStripMenuItem_Click);
            // 
            // setRFRegulationToolStripMenuItem
            // 
            this.setRFRegulationToolStripMenuItem.Name = "setRFRegulationToolStripMenuItem";
            this.setRFRegulationToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.setRFRegulationToolStripMenuItem.Text = "SetRFRegulation";
            this.setRFRegulationToolStripMenuItem.Click += new System.EventHandler(this.setRFRegulationToolStripMenuItem_Click);
            // 
            // readRFRegulationToolStripMenuItem
            // 
            this.readRFRegulationToolStripMenuItem.Name = "readRFRegulationToolStripMenuItem";
            this.readRFRegulationToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.readRFRegulationToolStripMenuItem.Text = "ReadRFRegulation";
            this.readRFRegulationToolStripMenuItem.Click += new System.EventHandler(this.readRFRegulationToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // datacontextMenuStrip
            // 
            this.datacontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readToolStripMenuItem1,
            this.writeToolStripMenuItem1});
            this.datacontextMenuStrip.Name = "contextMenuStrip1";
            this.datacontextMenuStrip.Size = new System.Drawing.Size(103, 48);
            this.datacontextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.datacontextMenuStrip_Opening);
            // 
            // readToolStripMenuItem1
            // 
            this.readToolStripMenuItem1.Name = "readToolStripMenuItem1";
            this.readToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.readToolStripMenuItem1.Text = "Read";
            this.readToolStripMenuItem1.Click += new System.EventHandler(this.readToolStripMenuItem1_Click);
            // 
            // writeToolStripMenuItem1
            // 
            this.writeToolStripMenuItem1.Name = "writeToolStripMenuItem1";
            this.writeToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.writeToolStripMenuItem1.Text = "Write";
            this.writeToolStripMenuItem1.Click += new System.EventHandler(this.writeToolStripMenuItem1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startreadingcomboBox
            // 
            this.startreadingcomboBox.FormattingEnabled = true;
            this.startreadingcomboBox.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100",
            "200",
            "300"});
            this.startreadingcomboBox.Location = new System.Drawing.Point(117, 54);
            this.startreadingcomboBox.Name = "startreadingcomboBox";
            this.startreadingcomboBox.Size = new System.Drawing.Size(53, 21);
            this.startreadingcomboBox.TabIndex = 15;
            this.startreadingcomboBox.Text = "100";
            // 
            // multiepccheckBox
            // 
            this.multiepccheckBox.AutoSize = true;
            this.multiepccheckBox.Location = new System.Drawing.Point(260, 35);
            this.multiepccheckBox.Name = "multiepccheckBox";
            this.multiepccheckBox.Size = new System.Drawing.Size(72, 17);
            this.multiepccheckBox.TabIndex = 16;
            this.multiepccheckBox.Text = "Multi EPC";
            this.multiepccheckBox.UseVisualStyleBackColor = true;
            this.multiepccheckBox.CheckedChanged += new System.EventHandler(this.multiepccheckBox_CheckedChanged);
            // 
            // epctagtextBox
            // 
            this.epctagtextBox.Location = new System.Drawing.Point(260, 54);
            this.epctagtextBox.Name = "epctagtextBox";
            this.epctagtextBox.Size = new System.Drawing.Size(231, 20);
            this.epctagtextBox.TabIndex = 17;
            this.epctagtextBox.TextChanged += new System.EventHandler(this.epctagtextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "www.greenfuturz.com";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // totalTagLabel
            // 
            this.totalTagLabel.BackColor = System.Drawing.Color.Lime;
            this.totalTagLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTagLabel.Location = new System.Drawing.Point(446, 100);
            this.totalTagLabel.Name = "totalTagLabel";
            this.totalTagLabel.Size = new System.Drawing.Size(162, 229);
            this.totalTagLabel.TabIndex = 23;
            this.totalTagLabel.Text = "                Total Tags";
            this.totalTagLabel.Click += new System.EventHandler(this.totalTagLabel_Click);
            // 
            // totalTagValueLabel
            // 
            this.totalTagValueLabel.BackColor = System.Drawing.Color.Lime;
            this.totalTagValueLabel.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTagValueLabel.Location = new System.Drawing.Point(457, 179);
            this.totalTagValueLabel.Name = "totalTagValueLabel";
            this.totalTagValueLabel.Size = new System.Drawing.Size(113, 111);
            this.totalTagValueLabel.TabIndex = 25;
            this.totalTagValueLabel.Text = "0";
            this.totalTagValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalTagValueLabel.Click += new System.EventHandler(this.totalTagValueLabel_Click_1);
            // 
            // pollingtimecombobox
            // 
            this.pollingtimecombobox.DropDownWidth = 105;
            this.pollingtimecombobox.ItemHeight = 13;
            this.pollingtimecombobox.Items.AddRange(new object[] {
            "300",
            "500",
            "1000",
            "10000",
            "30000",
            "60000"});
            this.pollingtimecombobox.Location = new System.Drawing.Point(185, 54);
            this.pollingtimecombobox.Name = "pollingtimecombobox";
            this.pollingtimecombobox.Size = new System.Drawing.Size(58, 21);
            this.pollingtimecombobox.TabIndex = 79;
            this.pollingtimecombobox.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Timeout";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "PollingTime";
            // 
            // inventorylist
            // 
            this.inventorylist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.inventorylist.GridLines = true;
            this.inventorylist.Location = new System.Drawing.Point(12, 100);
            this.inventorylist.Name = "inventorylist";
            this.inventorylist.Size = new System.Drawing.Size(419, 229);
            this.inventorylist.TabIndex = 82;
            this.inventorylist.UseCompatibleStateImageBehavior = false;
            this.inventorylist.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SNO";
            this.columnHeader1.Width = 44;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "EPC ID";
            this.columnHeader2.Width = 257;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "TagCount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 366);
            this.Controls.Add(this.inventorylist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pollingtimecombobox);
            this.Controls.Add(this.totalTagValueLabel);
            this.Controls.Add(this.totalTagLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.epctagtextBox);
            this.Controls.Add(this.multiepccheckBox);
            this.Controls.Add(this.startreadingcomboBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.clearReportscheckBox);
            this.Controls.Add(this.readbutton);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "G20 UHF Desktop Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.datacontextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readbutton;
        private System.Windows.Forms.CheckBox clearReportscheckBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem readerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setRFPowerLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readRFPowerLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip datacontextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem writeToolStripMenuItem1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox startreadingcomboBox;
        private System.Windows.Forms.CheckBox multiepccheckBox;
        private System.Windows.Forms.TextBox epctagtextBox;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalTagLabel;
        private System.Windows.Forms.Label totalTagValueLabel;
        internal System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setRFRegulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readRFRegulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mappingToolStripMenuItem;
        private System.Windows.Forms.ComboBox pollingtimecombobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView inventorylist;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

