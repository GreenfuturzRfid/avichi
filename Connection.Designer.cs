namespace WindowsFormsApplication1
{
    partial class Connection
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
            this.comportcomboBox = new System.Windows.Forms.ComboBox();
            this.connectbutton = new System.Windows.Forms.Button();
            this.openportlistBox = new System.Windows.Forms.ListBox();
            this.openportbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comportcomboBox
            // 
            this.comportcomboBox.FormattingEnabled = true;
            this.comportcomboBox.Location = new System.Drawing.Point(121, 28);
            this.comportcomboBox.Name = "comportcomboBox";
            this.comportcomboBox.Size = new System.Drawing.Size(91, 21);
            this.comportcomboBox.TabIndex = 1;
            this.comportcomboBox.SelectedIndexChanged += new System.EventHandler(this.comportcomboBox_SelectedIndexChanged_1);
            // 
            // connectbutton
            // 
            this.connectbutton.Location = new System.Drawing.Point(12, 21);
            this.connectbutton.Name = "connectbutton";
            this.connectbutton.Size = new System.Drawing.Size(89, 33);
            this.connectbutton.TabIndex = 2;
            this.connectbutton.Text = "Connect";
            this.connectbutton.UseVisualStyleBackColor = true;
            this.connectbutton.Click += new System.EventHandler(this.connectbutton_Click);
            // 
            // openportlistBox
            // 
            this.openportlistBox.FormattingEnabled = true;
            this.openportlistBox.Location = new System.Drawing.Point(12, 69);
            this.openportlistBox.Name = "openportlistBox";
            this.openportlistBox.Size = new System.Drawing.Size(200, 82);
            this.openportlistBox.TabIndex = 3;
            this.openportlistBox.SelectedIndexChanged += new System.EventHandler(this.openportlistBox_SelectedIndexChanged);
            // 
            // openportbutton
            // 
            this.openportbutton.Location = new System.Drawing.Point(228, 21);
            this.openportbutton.Name = "openportbutton";
            this.openportbutton.Size = new System.Drawing.Size(98, 33);
            this.openportbutton.TabIndex = 4;
            this.openportbutton.Text = "Find Reader";
            this.openportbutton.UseVisualStyleBackColor = true;
            this.openportbutton.Visible = false;
            this.openportbutton.Click += new System.EventHandler(this.openportbutton_Click);
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 165);
            this.Controls.Add(this.openportbutton);
            this.Controls.Add(this.openportlistBox);
            this.Controls.Add(this.connectbutton);
            this.Controls.Add(this.comportcomboBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Connection";
            this.Text = " Connection Settings";
            this.Load += new System.EventHandler(this.Connection_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comportcomboBox;
        private System.Windows.Forms.ListBox openportlistBox;
        private System.Windows.Forms.Button openportbutton;
        internal System.Windows.Forms.Button connectbutton;
    }
}