namespace WindowsFormsApplication1
{
    partial class SetRFPower
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
            this.setRFPowerLevelbutton = new System.Windows.Forms.Button();
            this.readRFPowerLevelbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.setregulationbutton = new System.Windows.Forms.Button();
            this.readregulationbutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // setRFPowerLevelbutton
            // 
            this.setRFPowerLevelbutton.Location = new System.Drawing.Point(12, 13);
            this.setRFPowerLevelbutton.Name = "setRFPowerLevelbutton";
            this.setRFPowerLevelbutton.Size = new System.Drawing.Size(98, 43);
            this.setRFPowerLevelbutton.TabIndex = 1;
            this.setRFPowerLevelbutton.Text = "SET RF POWER LEVEL";
            this.setRFPowerLevelbutton.UseVisualStyleBackColor = true;
            this.setRFPowerLevelbutton.Click += new System.EventHandler(this.setRFPowerLevelbutton_Click);
            // 
            // readRFPowerLevelbutton
            // 
            this.readRFPowerLevelbutton.Location = new System.Drawing.Point(116, 13);
            this.readRFPowerLevelbutton.Name = "readRFPowerLevelbutton";
            this.readRFPowerLevelbutton.Size = new System.Drawing.Size(116, 43);
            this.readRFPowerLevelbutton.TabIndex = 2;
            this.readRFPowerLevelbutton.Text = "READ RF POWER LEVEL";
            this.readRFPowerLevelbutton.UseVisualStyleBackColor = true;
            this.readRFPowerLevelbutton.Click += new System.EventHandler(this.readRFPowerLevelbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(255, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "FF";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 142);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(228, 108);
            this.listBox1.TabIndex = 6;
            // 
            // setregulationbutton
            // 
            this.setregulationbutton.Location = new System.Drawing.Point(12, 74);
            this.setregulationbutton.Name = "setregulationbutton";
            this.setregulationbutton.Size = new System.Drawing.Size(98, 49);
            this.setregulationbutton.TabIndex = 7;
            this.setregulationbutton.Text = "SET RF REGULATION";
            this.setregulationbutton.UseVisualStyleBackColor = true;
            this.setregulationbutton.Click += new System.EventHandler(this.setregulationbutton_Click);
            // 
            // readregulationbutton
            // 
            this.readregulationbutton.Location = new System.Drawing.Point(116, 75);
            this.readregulationbutton.Name = "readregulationbutton";
            this.readregulationbutton.Size = new System.Drawing.Size(125, 46);
            this.readregulationbutton.TabIndex = 8;
            this.readregulationbutton.Text = "READ RF REGULATION";
            this.readregulationbutton.UseVisualStyleBackColor = true;
            this.readregulationbutton.Click += new System.EventHandler(this.readregulationbutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(264, 166);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(91, 44);
            this.clearbutton.TabIndex = 10;
            this.clearbutton.Text = "CLEAR";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "EU 865~868",
            "US 902~928"});
            this.comboBox1.Location = new System.Drawing.Point(251, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "EU 865~868";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SetRFPower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 258);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.readregulationbutton);
            this.Controls.Add(this.setregulationbutton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.readRFPowerLevelbutton);
            this.Controls.Add(this.setRFPowerLevelbutton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetRFPower";
            this.Text = "SetRFPower";
            this.Load += new System.EventHandler(this.SetRFPower_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setRFPowerLevelbutton;
        private System.Windows.Forms.Button readRFPowerLevelbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button setregulationbutton;
        private System.Windows.Forms.Button readregulationbutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}