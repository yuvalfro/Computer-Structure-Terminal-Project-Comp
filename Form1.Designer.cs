namespace TerminalPC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonCommandsMode = new System.Windows.Forms.Button();
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.comboBoxSTPBIT = new System.Windows.Forms.ComboBox();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.labelCOM = new System.Windows.Forms.Label();
            this.labelBaud = new System.Windows.Forms.Label();
            this.labelSTPBIT = new System.Windows.Forms.Label();
            this.labelParity = new System.Windows.Forms.Label();
            this.buttonChat = new System.Windows.Forms.Button();
            this.buttonFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCommandsMode
            // 
            this.buttonCommandsMode.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonCommandsMode.ForeColor = System.Drawing.Color.Black;
            this.buttonCommandsMode.Location = new System.Drawing.Point(50, 76);
            this.buttonCommandsMode.Name = "buttonCommandsMode";
            this.buttonCommandsMode.Size = new System.Drawing.Size(75, 42);
            this.buttonCommandsMode.TabIndex = 0;
            this.buttonCommandsMode.Text = "Commands Mode";
            this.buttonCommandsMode.UseVisualStyleBackColor = false;
            this.buttonCommandsMode.Click += new System.EventHandler(this.ButtonCommandsMode_Click);
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Items.AddRange(new object[] {
            "COM4",
            "COM9",
            "COM10",
            "COM11",
            "COM6"});
            this.comboBoxCOM.Location = new System.Drawing.Point(182, 88);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCOM.TabIndex = 1;
            this.comboBoxCOM.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCOM_SelectedIndexChanged);
            // 
            // comboBoxSTPBIT
            // 
            this.comboBoxSTPBIT.FormattingEnabled = true;
            this.comboBoxSTPBIT.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBoxSTPBIT.Location = new System.Drawing.Point(182, 169);
            this.comboBoxSTPBIT.Name = "comboBoxSTPBIT";
            this.comboBoxSTPBIT.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSTPBIT.TabIndex = 2;
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Items.AddRange(new object[] {
            "2400",
            "9600",
            "19200",
            "38400"});
            this.comboBoxBaud.Location = new System.Drawing.Point(182, 127);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBaud.TabIndex = 4;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(204, 248);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 5;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.comboBoxParity.Location = new System.Drawing.Point(182, 212);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxParity.TabIndex = 6;
            // 
            // labelCOM
            // 
            this.labelCOM.AutoSize = true;
            this.labelCOM.Location = new System.Drawing.Point(179, 72);
            this.labelCOM.Name = "labelCOM";
            this.labelCOM.Size = new System.Drawing.Size(34, 13);
            this.labelCOM.TabIndex = 8;
            this.labelCOM.Text = "COM:";
            // 
            // labelBaud
            // 
            this.labelBaud.AutoSize = true;
            this.labelBaud.Location = new System.Drawing.Point(179, 111);
            this.labelBaud.Name = "labelBaud";
            this.labelBaud.Size = new System.Drawing.Size(61, 13);
            this.labelBaud.TabIndex = 9;
            this.labelBaud.Text = "Baud Rate:";
            // 
            // labelSTPBIT
            // 
            this.labelSTPBIT.AutoSize = true;
            this.labelSTPBIT.Location = new System.Drawing.Point(179, 153);
            this.labelSTPBIT.Name = "labelSTPBIT";
            this.labelSTPBIT.Size = new System.Drawing.Size(52, 13);
            this.labelSTPBIT.TabIndex = 11;
            this.labelSTPBIT.Text = "Stop Bits:";
            // 
            // labelParity
            // 
            this.labelParity.AutoSize = true;
            this.labelParity.Location = new System.Drawing.Point(179, 193);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(36, 13);
            this.labelParity.TabIndex = 12;
            this.labelParity.Text = "Parity:";
            // 
            // buttonChat
            // 
            this.buttonChat.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonChat.ForeColor = System.Drawing.Color.Black;
            this.buttonChat.Location = new System.Drawing.Point(50, 136);
            this.buttonChat.Name = "buttonChat";
            this.buttonChat.Size = new System.Drawing.Size(75, 42);
            this.buttonChat.TabIndex = 13;
            this.buttonChat.TabStop = false;
            this.buttonChat.Text = "Chat Mode";
            this.buttonChat.UseVisualStyleBackColor = false;
            this.buttonChat.Click += new System.EventHandler(this.ButtonChat_Click);
            // 
            // buttonFile
            // 
            this.buttonFile.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonFile.ForeColor = System.Drawing.Color.Black;
            this.buttonFile.Location = new System.Drawing.Point(50, 196);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(75, 42);
            this.buttonFile.TabIndex = 14;
            this.buttonFile.Text = "Files Transfer";
            this.buttonFile.UseVisualStyleBackColor = false;
            this.buttonFile.Click += new System.EventHandler(this.ButtonFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(78, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Communication Terminal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(361, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.buttonChat);
            this.Controls.Add(this.labelParity);
            this.Controls.Add(this.labelSTPBIT);
            this.Controls.Add(this.labelBaud);
            this.Controls.Add(this.labelCOM);
            this.Controls.Add(this.comboBoxParity);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.comboBoxBaud);
            this.Controls.Add(this.comboBoxSTPBIT);
            this.Controls.Add(this.comboBoxCOM);
            this.Controls.Add(this.buttonCommandsMode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Terminal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCommandsMode;
        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.ComboBox comboBoxSTPBIT;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.Label labelCOM;
        private System.Windows.Forms.Label labelBaud;
        private System.Windows.Forms.Label labelSTPBIT;
        private System.Windows.Forms.Label labelParity;
        private System.Windows.Forms.Button buttonChat;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
    }
}

