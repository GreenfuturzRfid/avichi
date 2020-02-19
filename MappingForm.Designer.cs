namespace WindowsFormsApplication1
{
    partial class MappingForm
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
            this.multiepccheckBox = new System.Windows.Forms.CheckBox();
            this.startreadingcomboBox = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.rbHeaderYes = new System.Windows.Forms.RadioButton();
            this.rbHeaderNo = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clearbutton = new System.Windows.Forms.Button();
            this.mappingbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.mappingcheckBox = new System.Windows.Forms.CheckBox();
            this.SAVE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // readbutton
            // 
            this.readbutton.Location = new System.Drawing.Point(12, 6);
            this.readbutton.Name = "readbutton";
            this.readbutton.Size = new System.Drawing.Size(90, 35);
            this.readbutton.TabIndex = 18;
            this.readbutton.Text = "START";
            this.readbutton.UseVisualStyleBackColor = true;
            this.readbutton.Click += new System.EventHandler(this.readbutton_Click);
            // 
            // multiepccheckBox
            // 
            this.multiepccheckBox.AutoSize = true;
            this.multiepccheckBox.Location = new System.Drawing.Point(12, 64);
            this.multiepccheckBox.Name = "multiepccheckBox";
            this.multiepccheckBox.Size = new System.Drawing.Size(72, 17);
            this.multiepccheckBox.TabIndex = 20;
            this.multiepccheckBox.Text = "Multi EPC";
            this.multiepccheckBox.UseVisualStyleBackColor = true;
            this.multiepccheckBox.Visible = false;
            this.multiepccheckBox.CheckedChanged += new System.EventHandler(this.multiepccheckBox_CheckedChanged);
            // 
            // startreadingcomboBox
            // 
            this.startreadingcomboBox.FormattingEnabled = true;
            this.startreadingcomboBox.Location = new System.Drawing.Point(40, 116);
            this.startreadingcomboBox.Name = "startreadingcomboBox";
            this.startreadingcomboBox.Size = new System.Drawing.Size(44, 21);
            this.startreadingcomboBox.TabIndex = 80;
            this.startreadingcomboBox.Text = "100";
            this.startreadingcomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 186);
            this.listBox1.TabIndex = 83;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 84;
            this.label1.Text = "HEADER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(212, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(434, 186);
            this.dataGridView1.TabIndex = 86;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-19, -13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(10, 23);
            this.button2.TabIndex = 85;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(212, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 87;
            this.button3.Text = "SELECT FILE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rbHeaderYes
            // 
            this.rbHeaderYes.AutoSize = true;
            this.rbHeaderYes.Checked = true;
            this.rbHeaderYes.Location = new System.Drawing.Point(420, 13);
            this.rbHeaderYes.Name = "rbHeaderYes";
            this.rbHeaderYes.Size = new System.Drawing.Size(43, 17);
            this.rbHeaderYes.TabIndex = 88;
            this.rbHeaderYes.TabStop = true;
            this.rbHeaderYes.Text = "Yes";
            this.rbHeaderYes.UseVisualStyleBackColor = true;
            // 
            // rbHeaderNo
            // 
            this.rbHeaderNo.Location = new System.Drawing.Point(420, 36);
            this.rbHeaderNo.Name = "rbHeaderNo";
            this.rbHeaderNo.Size = new System.Drawing.Size(47, 17);
            this.rbHeaderNo.TabIndex = 89;
            this.rbHeaderNo.Text = "No";
            this.rbHeaderNo.UseVisualStyleBackColor = true;
            this.rbHeaderNo.Visible = false;
            this.rbHeaderNo.CheckedChanged += new System.EventHandler(this.rbHeaderNo_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 91;
            this.label2.Text = "RECORD COUNT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 92;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(99, 62);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(52, 21);
            this.comboBox2.TabIndex = 93;
            this.comboBox2.Text = "100";
            this.comboBox2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 94;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(392, 60);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(86, 23);
            this.clearbutton.TabIndex = 95;
            this.clearbutton.Text = "CLEAR";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // mappingbutton
            // 
            this.mappingbutton.Location = new System.Drawing.Point(469, 13);
            this.mappingbutton.Name = "mappingbutton";
            this.mappingbutton.Size = new System.Drawing.Size(75, 23);
            this.mappingbutton.TabIndex = 96;
            this.mappingbutton.Text = "MAPPING";
            this.mappingbutton.UseVisualStyleBackColor = true;
            this.mappingbutton.Visible = false;
            this.mappingbutton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(484, 60);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 23);
            this.deletebutton.TabIndex = 97;
            this.deletebutton.Text = "DELETE";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // mappingcheckBox
            // 
            this.mappingcheckBox.AutoSize = true;
            this.mappingcheckBox.Location = new System.Drawing.Point(117, 13);
            this.mappingcheckBox.Name = "mappingcheckBox";
            this.mappingcheckBox.Size = new System.Drawing.Size(75, 17);
            this.mappingcheckBox.TabIndex = 81;
            this.mappingcheckBox.Text = "MAPPING";
            this.mappingcheckBox.UseVisualStyleBackColor = true;
            this.mappingcheckBox.CheckedChanged += new System.EventHandler(this.mappingcheckBox_CheckedChanged);
            // 
            // SAVE
            // 
            this.SAVE.Location = new System.Drawing.Point(565, 59);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(75, 23);
            this.SAVE.TabIndex = 98;
            this.SAVE.Text = "SAVE";
            this.SAVE.UseVisualStyleBackColor = true;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // MappingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 305);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.mappingbutton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbHeaderNo);
            this.Controls.Add(this.rbHeaderYes);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.mappingcheckBox);
            this.Controls.Add(this.startreadingcomboBox);
            this.Controls.Add(this.multiepccheckBox);
            this.Controls.Add(this.readbutton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MappingForm";
            this.Text = "MappingForm";
            this.Load += new System.EventHandler(this.MappingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readbutton;
        private System.Windows.Forms.CheckBox multiepccheckBox;
        private System.Windows.Forms.ComboBox startreadingcomboBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton rbHeaderYes;
        private System.Windows.Forms.RadioButton rbHeaderNo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button mappingbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.CheckBox mappingcheckBox;
        private System.Windows.Forms.Button SAVE;
    }
}