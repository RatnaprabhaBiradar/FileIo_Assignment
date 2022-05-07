namespace WindowsFormsApp
{
    partial class BookInformation
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
            this.button1_Binary_Write = new System.Windows.Forms.Button();
            this.button2_XmlSeralization_Write = new System.Windows.Forms.Button();
            this.button3_SoapSeralization_Write = new System.Windows.Forms.Button();
            this.button4_JsonSeralization_Write = new System.Windows.Forms.Button();
            this.button5_BinarySeralization_Read = new System.Windows.Forms.Button();
            this.button6_XmlSeralization_Read = new System.Windows.Forms.Button();
            this.button7_SOAPSEralization_read = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1_BookId = new System.Windows.Forms.TextBox();
            this.textBox2_BookName = new System.Windows.Forms.TextBox();
            this.textBox3_AuthorName = new System.Windows.Forms.TextBox();
            this.textBox4_Price = new System.Windows.Forms.TextBox();
            this.button8_JsonSeralization_Read = new System.Windows.Forms.Button();
            this.button9_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1_Binary_Write
            // 
            this.button1_Binary_Write.Location = new System.Drawing.Point(419, 77);
            this.button1_Binary_Write.Name = "button1_Binary_Write";
            this.button1_Binary_Write.Size = new System.Drawing.Size(142, 23);
            this.button1_Binary_Write.TabIndex = 0;
            this.button1_Binary_Write.Text = "Binary seralization Write";
            this.button1_Binary_Write.UseVisualStyleBackColor = true;
            this.button1_Binary_Write.Click += new System.EventHandler(this.button1_Binary_Write_Click);
            // 
            // button2_XmlSeralization_Write
            // 
            this.button2_XmlSeralization_Write.Location = new System.Drawing.Point(419, 127);
            this.button2_XmlSeralization_Write.Name = "button2_XmlSeralization_Write";
            this.button2_XmlSeralization_Write.Size = new System.Drawing.Size(142, 23);
            this.button2_XmlSeralization_Write.TabIndex = 1;
            this.button2_XmlSeralization_Write.Text = "XML Seralization Write";
            this.button2_XmlSeralization_Write.UseVisualStyleBackColor = true;
            this.button2_XmlSeralization_Write.Click += new System.EventHandler(this.button2_XmlSeralization_Write_Click);
            // 
            // button3_SoapSeralization_Write
            // 
            this.button3_SoapSeralization_Write.Location = new System.Drawing.Point(419, 184);
            this.button3_SoapSeralization_Write.Name = "button3_SoapSeralization_Write";
            this.button3_SoapSeralization_Write.Size = new System.Drawing.Size(142, 23);
            this.button3_SoapSeralization_Write.TabIndex = 2;
            this.button3_SoapSeralization_Write.Text = "SOAP Seralization Write";
            this.button3_SoapSeralization_Write.UseVisualStyleBackColor = true;
            this.button3_SoapSeralization_Write.Click += new System.EventHandler(this.button3_SoapSeralization_Write_Click);
            // 
            // button4_JsonSeralization_Write
            // 
            this.button4_JsonSeralization_Write.Location = new System.Drawing.Point(419, 241);
            this.button4_JsonSeralization_Write.Name = "button4_JsonSeralization_Write";
            this.button4_JsonSeralization_Write.Size = new System.Drawing.Size(142, 23);
            this.button4_JsonSeralization_Write.TabIndex = 3;
            this.button4_JsonSeralization_Write.Text = "Json Seralization Write";
            this.button4_JsonSeralization_Write.UseVisualStyleBackColor = true;
            this.button4_JsonSeralization_Write.Click += new System.EventHandler(this.button4_JsonSeralization_Write_Click);
            // 
            // button5_BinarySeralization_Read
            // 
            this.button5_BinarySeralization_Read.Location = new System.Drawing.Point(605, 80);
            this.button5_BinarySeralization_Read.Name = "button5_BinarySeralization_Read";
            this.button5_BinarySeralization_Read.Size = new System.Drawing.Size(145, 23);
            this.button5_BinarySeralization_Read.TabIndex = 4;
            this.button5_BinarySeralization_Read.Text = "Binary Seralization Read";
            this.button5_BinarySeralization_Read.UseVisualStyleBackColor = true;
            this.button5_BinarySeralization_Read.Click += new System.EventHandler(this.button5_BinarySeralization_Read_Click);
            // 
            // button6_XmlSeralization_Read
            // 
            this.button6_XmlSeralization_Read.Location = new System.Drawing.Point(605, 128);
            this.button6_XmlSeralization_Read.Name = "button6_XmlSeralization_Read";
            this.button6_XmlSeralization_Read.Size = new System.Drawing.Size(145, 23);
            this.button6_XmlSeralization_Read.TabIndex = 5;
            this.button6_XmlSeralization_Read.Text = "XML seralization Read";
            this.button6_XmlSeralization_Read.UseVisualStyleBackColor = true;
            this.button6_XmlSeralization_Read.Click += new System.EventHandler(this.button6_XmlSeralization_Read_Click);
            // 
            // button7_SOAPSEralization_read
            // 
            this.button7_SOAPSEralization_read.Location = new System.Drawing.Point(605, 180);
            this.button7_SOAPSEralization_read.Name = "button7_SOAPSEralization_read";
            this.button7_SOAPSEralization_read.Size = new System.Drawing.Size(145, 23);
            this.button7_SOAPSEralization_read.TabIndex = 6;
            this.button7_SOAPSEralization_read.Text = "SOAP seralization Read";
            this.button7_SOAPSEralization_read.UseVisualStyleBackColor = true;
            this.button7_SOAPSEralization_read.Click += new System.EventHandler(this.button7_SOAPSEralization_read_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Book Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Book Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Author Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Price";
            // 
            // textBox1_BookId
            // 
            this.textBox1_BookId.Location = new System.Drawing.Point(284, 80);
            this.textBox1_BookId.Name = "textBox1_BookId";
            this.textBox1_BookId.Size = new System.Drawing.Size(100, 20);
            this.textBox1_BookId.TabIndex = 11;
            // 
            // textBox2_BookName
            // 
            this.textBox2_BookName.Location = new System.Drawing.Point(284, 130);
            this.textBox2_BookName.Name = "textBox2_BookName";
            this.textBox2_BookName.Size = new System.Drawing.Size(100, 20);
            this.textBox2_BookName.TabIndex = 12;
            // 
            // textBox3_AuthorName
            // 
            this.textBox3_AuthorName.Location = new System.Drawing.Point(284, 187);
            this.textBox3_AuthorName.Name = "textBox3_AuthorName";
            this.textBox3_AuthorName.Size = new System.Drawing.Size(100, 20);
            this.textBox3_AuthorName.TabIndex = 13;
            // 
            // textBox4_Price
            // 
            this.textBox4_Price.Location = new System.Drawing.Point(284, 244);
            this.textBox4_Price.Name = "textBox4_Price";
            this.textBox4_Price.Size = new System.Drawing.Size(100, 20);
            this.textBox4_Price.TabIndex = 14;
            // 
            // button8_JsonSeralization_Read
            // 
            this.button8_JsonSeralization_Read.Location = new System.Drawing.Point(616, 244);
            this.button8_JsonSeralization_Read.Name = "button8_JsonSeralization_Read";
            this.button8_JsonSeralization_Read.Size = new System.Drawing.Size(134, 23);
            this.button8_JsonSeralization_Read.TabIndex = 17;
            this.button8_JsonSeralization_Read.Text = "Json Seralization Read";
            this.button8_JsonSeralization_Read.UseVisualStyleBackColor = true;
            this.button8_JsonSeralization_Read.Click += new System.EventHandler(this.button8_JsonSeralization_Read_Click);
            // 
            // button9_Clear
            // 
            this.button9_Clear.Location = new System.Drawing.Point(500, 297);
            this.button9_Clear.Name = "button9_Clear";
            this.button9_Clear.Size = new System.Drawing.Size(75, 23);
            this.button9_Clear.TabIndex = 18;
            this.button9_Clear.Text = "Clear";
            this.button9_Clear.UseVisualStyleBackColor = true;
            this.button9_Clear.Click += new System.EventHandler(this.button9_Clear_Click);
            // 
            // BookInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button9_Clear);
            this.Controls.Add(this.button8_JsonSeralization_Read);
            this.Controls.Add(this.textBox4_Price);
            this.Controls.Add(this.textBox3_AuthorName);
            this.Controls.Add(this.textBox2_BookName);
            this.Controls.Add(this.textBox1_BookId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7_SOAPSEralization_read);
            this.Controls.Add(this.button6_XmlSeralization_Read);
            this.Controls.Add(this.button5_BinarySeralization_Read);
            this.Controls.Add(this.button4_JsonSeralization_Write);
            this.Controls.Add(this.button3_SoapSeralization_Write);
            this.Controls.Add(this.button2_XmlSeralization_Write);
            this.Controls.Add(this.button1_Binary_Write);
            this.Name = "BookInformation";
            this.Text = "BookInformation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_Binary_Write;
        private System.Windows.Forms.Button button2_XmlSeralization_Write;
        private System.Windows.Forms.Button button3_SoapSeralization_Write;
        private System.Windows.Forms.Button button4_JsonSeralization_Write;
        private System.Windows.Forms.Button button5_BinarySeralization_Read;
        private System.Windows.Forms.Button button6_XmlSeralization_Read;
        private System.Windows.Forms.Button button7_SOAPSEralization_read;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1_BookId;
        private System.Windows.Forms.TextBox textBox2_BookName;
        private System.Windows.Forms.TextBox textBox3_AuthorName;
        private System.Windows.Forms.TextBox textBox4_Price;
        private System.Windows.Forms.Button button8_JsonSeralization_Read;
        private System.Windows.Forms.Button button9_Clear;
    }
}