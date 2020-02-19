namespace WindowsFormsApplication1
{
    partial class G20
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.multiepccheckBox = new System.Windows.Forms.CheckBox();
            this.clearbutton = new System.Windows.Forms.Button();
            this.readbutton = new System.Windows.Forms.Button();
            this.readblocklabel = new System.Windows.Forms.Label();
            this.readblockdatatextBox = new System.Windows.Forms.TextBox();
            this.readingcomboBox = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.readlengthcomboBox = new System.Windows.Forms.ComboBox();
            this.epctagtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(11, 152);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(338, 121);
            this.listBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(677, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 17;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // multiepccheckBox
            // 
            this.multiepccheckBox.AutoSize = true;
            this.multiepccheckBox.Location = new System.Drawing.Point(167, 22);
            this.multiepccheckBox.Name = "multiepccheckBox";
            this.multiepccheckBox.Size = new System.Drawing.Size(72, 17);
            this.multiepccheckBox.TabIndex = 19;
            this.multiepccheckBox.Text = "Multi EPC";
            this.multiepccheckBox.UseVisualStyleBackColor = true;
            this.multiepccheckBox.Visible = false;
            this.multiepccheckBox.CheckedChanged += new System.EventHandler(this.multiepccheckBox_CheckedChanged);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(260, 112);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(75, 23);
            this.clearbutton.TabIndex = 74;
            this.clearbutton.Text = "CLEAR";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // readbutton
            // 
            this.readbutton.Location = new System.Drawing.Point(135, 12);
            this.readbutton.Name = "readbutton";
            this.readbutton.Size = new System.Drawing.Size(214, 35);
            this.readbutton.TabIndex = 75;
            this.readbutton.Text = "READ";
            this.readbutton.UseVisualStyleBackColor = true;
            this.readbutton.Click += new System.EventHandler(this.readbutton_Click);
            // 
            // readblocklabel
            // 
            this.readblocklabel.AutoSize = true;
            this.readblocklabel.Location = new System.Drawing.Point(136, 79);
            this.readblocklabel.Name = "readblocklabel";
            this.readblocklabel.Size = new System.Drawing.Size(42, 13);
            this.readblocklabel.TabIndex = 76;
            this.readblocklabel.Text = "BLOCK";
            // 
            // readblockdatatextBox
            // 
            this.readblockdatatextBox.Location = new System.Drawing.Point(184, 79);
            this.readblockdatatextBox.Name = "readblockdatatextBox";
            this.readblockdatatextBox.Size = new System.Drawing.Size(55, 20);
            this.readblockdatatextBox.TabIndex = 77;
            this.readblockdatatextBox.Text = "0";
            this.readblockdatatextBox.TextChanged += new System.EventHandler(this.readblockdatatextBox_TextChanged);
            // 
            // readingcomboBox
            // 
            this.readingcomboBox.FormattingEnabled = true;
            this.readingcomboBox.Items.AddRange(new object[] {
            "Reserved",
            "EPC",
            "TID",
            "USER"});
            this.readingcomboBox.Location = new System.Drawing.Point(260, 74);
            this.readingcomboBox.Name = "readingcomboBox";
            this.readingcomboBox.Size = new System.Drawing.Size(79, 21);
            this.readingcomboBox.TabIndex = 78;
            this.readingcomboBox.Text = "USER";
            this.readingcomboBox.SelectedIndexChanged += new System.EventHandler(this.readingcomboBox_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(83, 79);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(43, 21);
            this.comboBox2.TabIndex = 79;
            this.comboBox2.Text = "100";
            this.comboBox2.Visible = false;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "LENGTH";
            // 
            // readlengthcomboBox
            // 
            this.readlengthcomboBox.FormattingEnabled = true;
            this.readlengthcomboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.readlengthcomboBox.Location = new System.Drawing.Point(73, 79);
            this.readlengthcomboBox.Name = "readlengthcomboBox";
            this.readlengthcomboBox.Size = new System.Drawing.Size(53, 21);
            this.readlengthcomboBox.TabIndex = 81;
            this.readlengthcomboBox.Text = "1";
            // 
            // epctagtextBox
            // 
            this.epctagtextBox.Location = new System.Drawing.Point(12, 112);
            this.epctagtextBox.Name = "epctagtextBox";
            this.epctagtextBox.Size = new System.Drawing.Size(224, 20);
            this.epctagtextBox.TabIndex = 82;
            // 
            // G20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 299);
            this.Controls.Add(this.epctagtextBox);
            this.Controls.Add(this.readlengthcomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.readingcomboBox);
            this.Controls.Add(this.readblockdatatextBox);
            this.Controls.Add(this.readblocklabel);
            this.Controls.Add(this.readbutton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.multiepccheckBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.Name = "G20";
            this.Text = "G20";
            this.Load += new System.EventHandler(this.G20_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox multiepccheckBox;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button readbutton;
        private System.Windows.Forms.Label readblocklabel;
        private System.Windows.Forms.TextBox readblockdatatextBox;
        private System.Windows.Forms.ComboBox readingcomboBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox readlengthcomboBox;
        private System.Windows.Forms.TextBox epctagtextBox;
    }
}