namespace TerminalPC
{
    partial class FormFileTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFileTransfer));
            this.buttonChoose = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonFilesLCD = new System.Windows.Forms.Button();
            this.button_SendTimer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(273, 38);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(75, 23);
            this.buttonChoose.TabIndex = 0;
            this.buttonChoose.Text = "Browse";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.ButtonChoose_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose File:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(20, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 20);
            this.textBox1.TabIndex = 2;
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonSend.Location = new System.Drawing.Point(20, 75);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // buttonFilesLCD
            // 
            this.buttonFilesLCD.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonFilesLCD.Location = new System.Drawing.Point(234, 75);
            this.buttonFilesLCD.Name = "buttonFilesLCD";
            this.buttonFilesLCD.Size = new System.Drawing.Size(114, 23);
            this.buttonFilesLCD.TabIndex = 4;
            this.buttonFilesLCD.Text = "Show files on LCD";
            this.buttonFilesLCD.UseVisualStyleBackColor = false;
            this.buttonFilesLCD.Click += new System.EventHandler(this.ButtonFilesLCD_Click);
            // 
            // button_SendTimer
            // 
            this.button_SendTimer.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_SendTimer.Location = new System.Drawing.Point(108, 75);
            this.button_SendTimer.Name = "button_SendTimer";
            this.button_SendTimer.Size = new System.Drawing.Size(114, 23);
            this.button_SendTimer.TabIndex = 5;
            this.button_SendTimer.Text = "Send with timer";
            this.button_SendTimer.UseVisualStyleBackColor = false;
            this.button_SendTimer.Click += new System.EventHandler(this.Button_SendTimer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 178);
            this.label2.TabIndex = 6;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // FormFileTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 329);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_SendTimer);
            this.Controls.Add(this.buttonFilesLCD);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChoose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFileTransfer";
            this.Text = "File Transfer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFileTransfer_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonFilesLCD;
        private System.Windows.Forms.Button button_SendTimer;
        private System.Windows.Forms.Label label2;
    }
}