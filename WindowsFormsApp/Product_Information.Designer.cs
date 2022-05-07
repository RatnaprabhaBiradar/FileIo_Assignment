namespace WindowsFormsApp
{
    partial class Product_Information
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
            this.label4 = new System.Windows.Forms.Label();
            this.Button1_BinarySerialization_Write = new System.Windows.Forms.Button();
            this.button2_XMLSerialization_Write = new System.Windows.Forms.Button();
            this.button3_SOAPSerialization_Write = new System.Windows.Forms.Button();
            this.button4_JSONSerialization_Write = new System.Windows.Forms.Button();
            this.textBox1_Id = new System.Windows.Forms.TextBox();
            this.textBox2_ProdName = new System.Windows.Forms.TextBox();
            this.textBox3_ProdPrice = new System.Windows.Forms.TextBox();
            this.textBox4_CategoryName = new System.Windows.Forms.TextBox();
            this.button5_Clear = new System.Windows.Forms.Button();
            this.button1_BinarySerialization_Read = new System.Windows.Forms.Button();
            this.button2_XML_Read = new System.Windows.Forms.Button();
            this.button3_SOAP_Read = new System.Windows.Forms.Button();
            this.button4_Json_Raed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Category Name";
            // 
            // Button1_BinarySerialization_Write
            // 
            this.Button1_BinarySerialization_Write.Location = new System.Drawing.Point(472, 142);
            this.Button1_BinarySerialization_Write.Name = "Button1_BinarySerialization_Write";
            this.Button1_BinarySerialization_Write.Size = new System.Drawing.Size(135, 23);
            this.Button1_BinarySerialization_Write.TabIndex = 4;
            this.Button1_BinarySerialization_Write.Text = "Binary Serialization Write";
            this.Button1_BinarySerialization_Write.UseVisualStyleBackColor = true;
            this.Button1_BinarySerialization_Write.Click += new System.EventHandler(this.Button1_BinarySerialization_Click);
            // 
            // button2_XMLSerialization_Write
            // 
            this.button2_XMLSerialization_Write.Location = new System.Drawing.Point(472, 196);
            this.button2_XMLSerialization_Write.Name = "button2_XMLSerialization_Write";
            this.button2_XMLSerialization_Write.Size = new System.Drawing.Size(135, 23);
            this.button2_XMLSerialization_Write.TabIndex = 5;
            this.button2_XMLSerialization_Write.Text = "XML Serialization Write";
            this.button2_XMLSerialization_Write.UseVisualStyleBackColor = true;
            this.button2_XMLSerialization_Write.Click += new System.EventHandler(this.button2_XMLSerialization_Write_Click);
            // 
            // button3_SOAPSerialization_Write
            // 
            this.button3_SOAPSerialization_Write.Location = new System.Drawing.Point(472, 240);
            this.button3_SOAPSerialization_Write.Name = "button3_SOAPSerialization_Write";
            this.button3_SOAPSerialization_Write.Size = new System.Drawing.Size(135, 23);
            this.button3_SOAPSerialization_Write.TabIndex = 6;
            this.button3_SOAPSerialization_Write.Text = "SOAP Serialization write";
            this.button3_SOAPSerialization_Write.UseVisualStyleBackColor = true;
            this.button3_SOAPSerialization_Write.Click += new System.EventHandler(this.button3_SOAPSerialization_Write_Click);
            // 
            // button4_JSONSerialization_Write
            // 
            this.button4_JSONSerialization_Write.Location = new System.Drawing.Point(472, 297);
            this.button4_JSONSerialization_Write.Name = "button4_JSONSerialization_Write";
            this.button4_JSONSerialization_Write.Size = new System.Drawing.Size(135, 23);
            this.button4_JSONSerialization_Write.TabIndex = 7;
            this.button4_JSONSerialization_Write.Text = "Json Serialization Write";
            this.button4_JSONSerialization_Write.UseVisualStyleBackColor = true;
            this.button4_JSONSerialization_Write.Click += new System.EventHandler(this.button4_JSONSerialization_Write_Click);
            // 
            // textBox1_Id
            // 
            this.textBox1_Id.Location = new System.Drawing.Point(342, 141);
            this.textBox1_Id.Name = "textBox1_Id";
            this.textBox1_Id.Size = new System.Drawing.Size(100, 20);
            this.textBox1_Id.TabIndex = 8;
            // 
            // textBox2_ProdName
            // 
            this.textBox2_ProdName.Location = new System.Drawing.Point(342, 194);
            this.textBox2_ProdName.Name = "textBox2_ProdName";
            this.textBox2_ProdName.Size = new System.Drawing.Size(100, 20);
            this.textBox2_ProdName.TabIndex = 9;
            // 
            // textBox3_ProdPrice
            // 
            this.textBox3_ProdPrice.Location = new System.Drawing.Point(342, 243);
            this.textBox3_ProdPrice.Name = "textBox3_ProdPrice";
            this.textBox3_ProdPrice.Size = new System.Drawing.Size(100, 20);
            this.textBox3_ProdPrice.TabIndex = 10;
            // 
            // textBox4_CategoryName
            // 
            this.textBox4_CategoryName.Location = new System.Drawing.Point(342, 299);
            this.textBox4_CategoryName.Name = "textBox4_CategoryName";
            this.textBox4_CategoryName.Size = new System.Drawing.Size(100, 20);
            this.textBox4_CategoryName.TabIndex = 11;
            // 
            // button5_Clear
            // 
            this.button5_Clear.Location = new System.Drawing.Point(409, 350);
            this.button5_Clear.Name = "button5_Clear";
            this.button5_Clear.Size = new System.Drawing.Size(75, 23);
            this.button5_Clear.TabIndex = 12;
            this.button5_Clear.Text = "Clear";
            this.button5_Clear.UseVisualStyleBackColor = true;
            this.button5_Clear.Click += new System.EventHandler(this.button5_Clear_Click);
            // 
            // button1_BinarySerialization_Read
            // 
            this.button1_BinarySerialization_Read.Location = new System.Drawing.Point(656, 137);
            this.button1_BinarySerialization_Read.Name = "button1_BinarySerialization_Read";
            this.button1_BinarySerialization_Read.Size = new System.Drawing.Size(132, 23);
            this.button1_BinarySerialization_Read.TabIndex = 13;
            this.button1_BinarySerialization_Read.Text = "Binary Serialization Read";
            this.button1_BinarySerialization_Read.UseVisualStyleBackColor = true;
            this.button1_BinarySerialization_Read.Click += new System.EventHandler(this.button1_BinarySerialization_Read_Click);
            // 
            // button2_XML_Read
            // 
            this.button2_XML_Read.Location = new System.Drawing.Point(656, 192);
            this.button2_XML_Read.Name = "button2_XML_Read";
            this.button2_XML_Read.Size = new System.Drawing.Size(132, 23);
            this.button2_XML_Read.TabIndex = 14;
            this.button2_XML_Read.Text = "XML serialization Read";
            this.button2_XML_Read.UseVisualStyleBackColor = true;
            this.button2_XML_Read.Click += new System.EventHandler(this.button2_XML_Read_Click);
            // 
            // button3_SOAP_Read
            // 
            this.button3_SOAP_Read.Location = new System.Drawing.Point(656, 241);
            this.button3_SOAP_Read.Name = "button3_SOAP_Read";
            this.button3_SOAP_Read.Size = new System.Drawing.Size(132, 23);
            this.button3_SOAP_Read.TabIndex = 15;
            this.button3_SOAP_Read.Text = "SOAP serialization Read";
            this.button3_SOAP_Read.UseVisualStyleBackColor = true;
            this.button3_SOAP_Read.Click += new System.EventHandler(this.button3_SOAP_Read_Click);
            // 
            // button4_Json_Raed
            // 
            this.button4_Json_Raed.Location = new System.Drawing.Point(656, 299);
            this.button4_Json_Raed.Name = "button4_Json_Raed";
            this.button4_Json_Raed.Size = new System.Drawing.Size(132, 23);
            this.button4_Json_Raed.TabIndex = 16;
            this.button4_Json_Raed.Text = "Json Serialization Read";
            this.button4_Json_Raed.UseVisualStyleBackColor = true;
            this.button4_Json_Raed.Click += new System.EventHandler(this.button4_Json_Raed_Click);
            // 
            // Product_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4_Json_Raed);
            this.Controls.Add(this.button3_SOAP_Read);
            this.Controls.Add(this.button2_XML_Read);
            this.Controls.Add(this.button1_BinarySerialization_Read);
            this.Controls.Add(this.button5_Clear);
            this.Controls.Add(this.textBox4_CategoryName);
            this.Controls.Add(this.textBox3_ProdPrice);
            this.Controls.Add(this.textBox2_ProdName);
            this.Controls.Add(this.textBox1_Id);
            this.Controls.Add(this.button4_JSONSerialization_Write);
            this.Controls.Add(this.button3_SOAPSerialization_Write);
            this.Controls.Add(this.button2_XMLSerialization_Write);
            this.Controls.Add(this.Button1_BinarySerialization_Write);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Product_Information";
            this.Text = "Product Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button1_BinarySerialization_Write;
        private System.Windows.Forms.Button button2_XMLSerialization_Write;
        private System.Windows.Forms.Button button3_SOAPSerialization_Write;
        private System.Windows.Forms.Button button4_JSONSerialization_Write;
        private System.Windows.Forms.TextBox textBox1_Id;
        private System.Windows.Forms.TextBox textBox2_ProdName;
        private System.Windows.Forms.TextBox textBox3_ProdPrice;
        private System.Windows.Forms.TextBox textBox4_CategoryName;
        private System.Windows.Forms.Button button5_Clear;
        private System.Windows.Forms.Button button1_BinarySerialization_Read;
        private System.Windows.Forms.Button button2_XML_Read;
        private System.Windows.Forms.Button button3_SOAP_Read;
        private System.Windows.Forms.Button button4_Json_Raed;
    }
}