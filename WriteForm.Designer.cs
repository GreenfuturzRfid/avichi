namespace WindowsFormsApplication1
{
    partial class WriteForm
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
            this.writebutton = new System.Windows.Forms.Button();
            this.writeblocklabel = new System.Windows.Forms.Label();
            this.blockwritetextBox = new System.Windows.Forms.TextBox();
            this.datalabel = new System.Windows.Forms.Label();
            this.datawritetextBox = new System.Windows.Forms.TextBox();
            this.writecomboBox = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.multiepccheckBox = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.clearbutton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.epctagtextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // writebutton
            // 
            this.writebutton.Location = new System.Drawing.Point(126, 12);
            this.writebutton.Name = "writebutton";
            this.writebutton.Size = new System.Drawing.Size(206, 39);
            this.writebutton.TabIndex = 4;
            this.writebutton.Text = "WRITE";
            this.writebutton.UseVisualStyleBackColor = true;
            this.writebutton.Click += new System.EventHandler(this.writebutton_Click);
            // 
            // writeblocklabel
            // 
            this.writeblocklabel.AutoSize = true;
            this.writeblocklabel.Location = new System.Drawing.Point(10, 83);
            this.writeblocklabel.Name = "writeblocklabel";
            this.writeblocklabel.Size = new System.Drawing.Size(42, 13);
            this.writeblocklabel.TabIndex = 10;
            this.writeblocklabel.Text = "BLOCK";
            this.writeblocklabel.Click += new System.EventHandler(this.writeblocllabel_Click);
            // 
            // blockwritetextBox
            // 
            this.blockwritetextBox.Location = new System.Drawing.Point(58, 80);
            this.blockwritetextBox.Name = "blockwritetextBox";
            this.blockwritetextBox.Size = new System.Drawing.Size(59, 20);
            this.blockwritetextBox.TabIndex = 11;
            this.blockwritetextBox.Text = "0";
            this.blockwritetextBox.TextChanged += new System.EventHandler(this.blockwritetextBox_TextChanged);
            // 
            // datalabel
            // 
            this.datalabel.AutoSize = true;
            this.datalabel.Location = new System.Drawing.Point(123, 86);
            this.datalabel.Name = "datalabel";
            this.datalabel.Size = new System.Drawing.Size(36, 13);
            this.datalabel.TabIndex = 13;
            this.datalabel.Text = "DATA";
            // 
            // datawritetextBox
            // 
            this.datawritetextBox.Location = new System.Drawing.Point(169, 83);
            this.datawritetextBox.Name = "datawritetextBox";
            this.datawritetextBox.Size = new System.Drawing.Size(228, 20);
            this.datawritetextBox.TabIndex = 14;
            this.datawritetextBox.Text = "0";
            // 
            // writecomboBox
            // 
            this.writecomboBox.FormattingEnabled = true;
            this.writecomboBox.Items.AddRange(new object[] {
            "Reserved",
            "EPC",
            "TID",
            "USER"});
            this.writecomboBox.Location = new System.Drawing.Point(326, 117);
            this.writecomboBox.Name = "writecomboBox";
            this.writecomboBox.Size = new System.Drawing.Size(86, 21);
            this.writecomboBox.TabIndex = 15;
            this.writecomboBox.Text = "USER";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 159);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(271, 121);
            this.listBox1.TabIndex = 16;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 35);
            this.button1.TabIndex = 18;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // multiepccheckBox
            // 
            this.multiepccheckBox.AutoSize = true;
            this.multiepccheckBox.Location = new System.Drawing.Point(13, 53);
            this.multiepccheckBox.Name = "multiepccheckBox";
            this.multiepccheckBox.Size = new System.Drawing.Size(72, 17);
            this.multiepccheckBox.TabIndex = 20;
            this.multiepccheckBox.Text = "Multi EPC";
            this.multiepccheckBox.UseVisualStyleBackColor = true;
            this.multiepccheckBox.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(87, 51);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(49, 21);
            this.comboBox2.TabIndex = 80;
            this.comboBox2.Text = "100";
            this.comboBox2.Visible = false;
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(234, 117);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(86, 23);
            this.clearbutton.TabIndex = 81;
            this.clearbutton.Text = "CLEAR";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // epctagtextBox
            // 
            this.epctagtextBox.Location = new System.Drawing.Point(4, 120);
            this.epctagtextBox.Name = "epctagtextBox";
            this.epctagtextBox.Size = new System.Drawing.Size(224, 20);
            this.epctagtextBox.TabIndex = 83;
            this.epctagtextBox.TextChanged += new System.EventHandler(this.epctagtextBox_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(338, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 35);
            this.button2.TabIndex = 84;
            this.button2.Text = "RW";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 302);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.epctagtextBox);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.multiepccheckBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.writecomboBox);
            this.Controls.Add(this.datawritetextBox);
            this.Controls.Add(this.datalabel);
            this.Controls.Add(this.blockwritetextBox);
            this.Controls.Add(this.writeblocklabel);
            this.Controls.Add(this.writebutton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WriteForm";
            this.Text = "WriteForm";
            this.Load += new System.EventHandler(this.WriteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button writebutton;
        private System.Windows.Forms.Label writeblocklabel;
        private System.Windows.Forms.TextBox blockwritetextBox;
        private System.Windows.Forms.Label datalabel;
        private System.Windows.Forms.TextBox datawritetextBox;
        private System.Windows.Forms.ComboBox writecomboBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox multiepccheckBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox epctagtextBox;
        private System.Windows.Forms.Button button2;
    }
}