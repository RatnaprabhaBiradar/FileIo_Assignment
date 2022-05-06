namespace WindowsFormsApp
{
    partial class Serilization_DEPT
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1_DeptId = new System.Windows.Forms.TextBox();
            this.textBox2_Name = new System.Windows.Forms.TextBox();
            this.textBox3_Location = new System.Windows.Forms.TextBox();
            this.button1_Write = new System.Windows.Forms.Button();
            this.button2_Read = new System.Windows.Forms.Button();
            this.button3_CreateFolder = new System.Windows.Forms.Button();
            this.button4_CreateFile = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button1_binaryWrite = new System.Windows.Forms.Button();
            this.button2_BinaryRead = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1_XmlWrite = new System.Windows.Forms.Button();
            this.button2_XMLRead = new System.Windows.Forms.Button();
            this.button1_SOAPWrite = new System.Windows.Forms.Button();
            this.button2_SOAP_Read = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1_JsonWrite = new System.Windows.Forms.Button();
            this.button2_JsonRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Dept Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Dept Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Location";
            // 
            // textBox1_DeptId
            // 
            this.textBox1_DeptId.Location = new System.Drawing.Point(479, 73);
            this.textBox1_DeptId.Name = "textBox1_DeptId";
            this.textBox1_DeptId.Size = new System.Drawing.Size(100, 20);
            this.textBox1_DeptId.TabIndex = 3;
            // 
            // textBox2_Name
            // 
            this.textBox2_Name.Location = new System.Drawing.Point(479, 140);
            this.textBox2_Name.Name = "textBox2_Name";
            this.textBox2_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox2_Name.TabIndex = 4;
            // 
            // textBox3_Location
            // 
            this.textBox3_Location.Location = new System.Drawing.Point(479, 214);
            this.textBox3_Location.Name = "textBox3_Location";
            this.textBox3_Location.Size = new System.Drawing.Size(100, 20);
            this.textBox3_Location.TabIndex = 5;
            // 
            // button1_Write
            // 
            this.button1_Write.Location = new System.Drawing.Point(285, 323);
            this.button1_Write.Name = "button1_Write";
            this.button1_Write.Size = new System.Drawing.Size(137, 23);
            this.button1_Write.TabIndex = 6;
            this.button1_Write.Text = "Write To File Binary Write";
            this.button1_Write.UseVisualStyleBackColor = true;
            this.button1_Write.Click += new System.EventHandler(this.button1_Write_Click);
            // 
            // button2_Read
            // 
            this.button2_Read.Location = new System.Drawing.Point(456, 323);
            this.button2_Read.Name = "button2_Read";
            this.button2_Read.Size = new System.Drawing.Size(123, 23);
            this.button2_Read.TabIndex = 7;
            this.button2_Read.Text = "Read From File Binary Read";
            this.button2_Read.UseVisualStyleBackColor = true;
            this.button2_Read.Click += new System.EventHandler(this.button2_Read_Click);
            // 
            // button3_CreateFolder
            // 
            this.button3_CreateFolder.Location = new System.Drawing.Point(321, 395);
            this.button3_CreateFolder.Name = "button3_CreateFolder";
            this.button3_CreateFolder.Size = new System.Drawing.Size(113, 23);
            this.button3_CreateFolder.TabIndex = 8;
            this.button3_CreateFolder.Text = "Create Folder";
            this.button3_CreateFolder.UseVisualStyleBackColor = true;
            this.button3_CreateFolder.Click += new System.EventHandler(this.button3_CreateFolder_Click);
            // 
            // button4_CreateFile
            // 
            this.button4_CreateFile.Location = new System.Drawing.Point(504, 395);
            this.button4_CreateFile.Name = "button4_CreateFile";
            this.button4_CreateFile.Size = new System.Drawing.Size(91, 23);
            this.button4_CreateFile.TabIndex = 9;
            this.button4_CreateFile.Text = "Create File";
            this.button4_CreateFile.UseVisualStyleBackColor = true;
            this.button4_CreateFile.Click += new System.EventHandler(this.button4_CreateFile_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(613, 323);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 10;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1_binaryWrite
            // 
            this.button1_binaryWrite.Location = new System.Drawing.Point(613, 90);
            this.button1_binaryWrite.Name = "button1_binaryWrite";
            this.button1_binaryWrite.Size = new System.Drawing.Size(137, 23);
            this.button1_binaryWrite.TabIndex = 11;
            this.button1_binaryWrite.Text = "Binary Write Serilizable";
            this.button1_binaryWrite.UseVisualStyleBackColor = true;
            this.button1_binaryWrite.Click += new System.EventHandler(this.button1_binaryWrite_Click);
            // 
            // button2_BinaryRead
            // 
            this.button2_BinaryRead.Location = new System.Drawing.Point(613, 172);
            this.button2_BinaryRead.Name = "button2_BinaryRead";
            this.button2_BinaryRead.Size = new System.Drawing.Size(137, 23);
            this.button2_BinaryRead.TabIndex = 12;
            this.button2_BinaryRead.Text = "Binary Read Serilizable";
            this.button2_BinaryRead.UseVisualStyleBackColor = true;
            this.button2_BinaryRead.Click += new System.EventHandler(this.button2_BinaryRead_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(621, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Binary Serilization Write";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(621, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Binary Serilization Read";
            // 
            // button1_XmlWrite
            // 
            this.button1_XmlWrite.Location = new System.Drawing.Point(624, 221);
            this.button1_XmlWrite.Name = "button1_XmlWrite";
            this.button1_XmlWrite.Size = new System.Drawing.Size(75, 23);
            this.button1_XmlWrite.TabIndex = 15;
            this.button1_XmlWrite.Text = "XML write";
            this.button1_XmlWrite.UseVisualStyleBackColor = true;
            this.button1_XmlWrite.Click += new System.EventHandler(this.button1_XmlWrite_Click);
            // 
            // button2_XMLRead
            // 
            this.button2_XMLRead.Location = new System.Drawing.Point(624, 278);
            this.button2_XMLRead.Name = "button2_XMLRead";
            this.button2_XMLRead.Size = new System.Drawing.Size(75, 23);
            this.button2_XMLRead.TabIndex = 16;
            this.button2_XMLRead.Text = "XML Read";
            this.button2_XMLRead.UseVisualStyleBackColor = true;
            this.button2_XMLRead.Click += new System.EventHandler(this.button2_XMLRead_Click);
            // 
            // button1_SOAPWrite
            // 
            this.button1_SOAPWrite.Location = new System.Drawing.Point(149, 200);
            this.button1_SOAPWrite.Name = "button1_SOAPWrite";
            this.button1_SOAPWrite.Size = new System.Drawing.Size(75, 23);
            this.button1_SOAPWrite.TabIndex = 17;
            this.button1_SOAPWrite.Text = "SOAP Write";
            this.button1_SOAPWrite.UseVisualStyleBackColor = true;
            this.button1_SOAPWrite.Click += new System.EventHandler(this.button1_SOAPWrite_Click);
            // 
            // button2_SOAP_Read
            // 
            this.button2_SOAP_Read.Location = new System.Drawing.Point(149, 265);
            this.button2_SOAP_Read.Name = "button2_SOAP_Read";
            this.button2_SOAP_Read.Size = new System.Drawing.Size(75, 23);
            this.button2_SOAP_Read.TabIndex = 18;
            this.button2_SOAP_Read.Text = "SOAP Read";
            this.button2_SOAP_Read.UseVisualStyleBackColor = true;
            this.button2_SOAP_Read.Click += new System.EventHandler(this.button2_SOAP_Read_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(619, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "XML serilization REad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(621, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "XML serilization Write";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "SOAP Serilization Write";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(135, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "SOAP Serilization Read";
            // 
            // button1_JsonWrite
            // 
            this.button1_JsonWrite.Location = new System.Drawing.Point(144, 63);
            this.button1_JsonWrite.Name = "button1_JsonWrite";
            this.button1_JsonWrite.Size = new System.Drawing.Size(75, 23);
            this.button1_JsonWrite.TabIndex = 23;
            this.button1_JsonWrite.Text = "JSON Write";
            this.button1_JsonWrite.UseVisualStyleBackColor = true;
            this.button1_JsonWrite.Click += new System.EventHandler(this.button1_JsonWrite_Click);
            // 
            // button2_JsonRead
            // 
            this.button2_JsonRead.Location = new System.Drawing.Point(144, 138);
            this.button2_JsonRead.Name = "button2_JsonRead";
            this.button2_JsonRead.Size = new System.Drawing.Size(75, 23);
            this.button2_JsonRead.TabIndex = 24;
            this.button2_JsonRead.Text = "JSON Read";
            this.button2_JsonRead.UseVisualStyleBackColor = true;
            this.button2_JsonRead.Click += new System.EventHandler(this.button2_JsonRead_Click);
            // 
            // Serilization_DEPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2_JsonRead);
            this.Controls.Add(this.button1_JsonWrite);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2_SOAP_Read);
            this.Controls.Add(this.button1_SOAPWrite);
            this.Controls.Add(this.button2_XMLRead);
            this.Controls.Add(this.button1_XmlWrite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2_BinaryRead);
            this.Controls.Add(this.button1_binaryWrite);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button4_CreateFile);
            this.Controls.Add(this.button3_CreateFolder);
            this.Controls.Add(this.button2_Read);
            this.Controls.Add(this.button1_Write);
            this.Controls.Add(this.textBox3_Location);
            this.Controls.Add(this.textBox2_Name);
            this.Controls.Add(this.textBox1_DeptId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Serilization_DEPT";
            this.Text = "Serilization_DEPT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1_DeptId;
        private System.Windows.Forms.TextBox textBox2_Name;
        private System.Windows.Forms.TextBox textBox3_Location;
        private System.Windows.Forms.Button button1_Write;
        private System.Windows.Forms.Button button2_Read;
        private System.Windows.Forms.Button button3_CreateFolder;
        private System.Windows.Forms.Button button4_CreateFile;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button1_binaryWrite;
        private System.Windows.Forms.Button button2_BinaryRead;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1_XmlWrite;
        private System.Windows.Forms.Button button2_XMLRead;
        private System.Windows.Forms.Button button1_SOAPWrite;
        private System.Windows.Forms.Button button2_SOAP_Read;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1_JsonWrite;
        private System.Windows.Forms.Button button2_JsonRead;
    }
}