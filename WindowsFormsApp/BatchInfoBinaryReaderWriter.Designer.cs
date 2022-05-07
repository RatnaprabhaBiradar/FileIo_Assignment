namespace WindowsFormsApp
{
    partial class BatchInfoBinaryReaderWriter
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
            this.button1_Clear = new System.Windows.Forms.Button();
            this.button2_Binary_Reader = new System.Windows.Forms.Button();
            this.button3_Binary_Writer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1_Trainer_Name = new System.Windows.Forms.TextBox();
            this.textBox2_Batch_Location = new System.Windows.Forms.TextBox();
            this.textBox3_EndDate = new System.Windows.Forms.TextBox();
            this.textBox4_StartDate = new System.Windows.Forms.TextBox();
            this.textBox5_BatchName = new System.Windows.Forms.TextBox();
            this.textBox6_BatchID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1_Clear
            // 
            this.button1_Clear.Location = new System.Drawing.Point(503, 302);
            this.button1_Clear.Name = "button1_Clear";
            this.button1_Clear.Size = new System.Drawing.Size(98, 23);
            this.button1_Clear.TabIndex = 0;
            this.button1_Clear.Text = "Clear";
            this.button1_Clear.UseVisualStyleBackColor = true;
            this.button1_Clear.Click += new System.EventHandler(this.button1_Clear_Click);
            // 
            // button2_Binary_Reader
            // 
            this.button2_Binary_Reader.Location = new System.Drawing.Point(503, 196);
            this.button2_Binary_Reader.Name = "button2_Binary_Reader";
            this.button2_Binary_Reader.Size = new System.Drawing.Size(98, 23);
            this.button2_Binary_Reader.TabIndex = 1;
            this.button2_Binary_Reader.Text = "Binary Reader";
            this.button2_Binary_Reader.UseVisualStyleBackColor = true;
            this.button2_Binary_Reader.Click += new System.EventHandler(this.button2_Binary_Reader_Click);
            // 
            // button3_Binary_Writer
            // 
            this.button3_Binary_Writer.Location = new System.Drawing.Point(503, 94);
            this.button3_Binary_Writer.Name = "button3_Binary_Writer";
            this.button3_Binary_Writer.Size = new System.Drawing.Size(98, 23);
            this.button3_Binary_Writer.TabIndex = 2;
            this.button3_Binary_Writer.Text = "Binary Writer";
            this.button3_Binary_Writer.UseVisualStyleBackColor = true;
            this.button3_Binary_Writer.Click += new System.EventHandler(this.button3_Binary_Writer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Batch ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Batch Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "End Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Trainer Name";
            // 
            // textBox1_Trainer_Name
            // 
            this.textBox1_Trainer_Name.Location = new System.Drawing.Point(250, 354);
            this.textBox1_Trainer_Name.Name = "textBox1_Trainer_Name";
            this.textBox1_Trainer_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox1_Trainer_Name.TabIndex = 9;
            // 
            // textBox2_Batch_Location
            // 
            this.textBox2_Batch_Location.Location = new System.Drawing.Point(250, 300);
            this.textBox2_Batch_Location.Name = "textBox2_Batch_Location";
            this.textBox2_Batch_Location.Size = new System.Drawing.Size(100, 20);
            this.textBox2_Batch_Location.TabIndex = 10;
            // 
            // textBox3_EndDate
            // 
            this.textBox3_EndDate.Location = new System.Drawing.Point(250, 241);
            this.textBox3_EndDate.Name = "textBox3_EndDate";
            this.textBox3_EndDate.Size = new System.Drawing.Size(100, 20);
            this.textBox3_EndDate.TabIndex = 11;
            // 
            // textBox4_StartDate
            // 
            this.textBox4_StartDate.Location = new System.Drawing.Point(250, 177);
            this.textBox4_StartDate.Name = "textBox4_StartDate";
            this.textBox4_StartDate.Size = new System.Drawing.Size(100, 20);
            this.textBox4_StartDate.TabIndex = 12;
            // 
            // textBox5_BatchName
            // 
            this.textBox5_BatchName.Location = new System.Drawing.Point(250, 122);
            this.textBox5_BatchName.Name = "textBox5_BatchName";
            this.textBox5_BatchName.Size = new System.Drawing.Size(100, 20);
            this.textBox5_BatchName.TabIndex = 13;
            // 
            // textBox6_BatchID
            // 
            this.textBox6_BatchID.Location = new System.Drawing.Point(250, 72);
            this.textBox6_BatchID.Name = "textBox6_BatchID";
            this.textBox6_BatchID.Size = new System.Drawing.Size(100, 20);
            this.textBox6_BatchID.TabIndex = 14;
            // 
            // BatchInfoBinaryReaderWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox6_BatchID);
            this.Controls.Add(this.textBox5_BatchName);
            this.Controls.Add(this.textBox4_StartDate);
            this.Controls.Add(this.textBox3_EndDate);
            this.Controls.Add(this.textBox2_Batch_Location);
            this.Controls.Add(this.textBox1_Trainer_Name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3_Binary_Writer);
            this.Controls.Add(this.button2_Binary_Reader);
            this.Controls.Add(this.button1_Clear);
            this.Name = "BatchInfoBinaryReaderWriter";
            this.Text = "BatchInfoBinaryReaderWriter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_Clear;
        private System.Windows.Forms.Button button2_Binary_Reader;
        private System.Windows.Forms.Button button3_Binary_Writer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1_Trainer_Name;
        private System.Windows.Forms.TextBox textBox2_Batch_Location;
        private System.Windows.Forms.TextBox textBox3_EndDate;
        private System.Windows.Forms.TextBox textBox4_StartDate;
        private System.Windows.Forms.TextBox textBox5_BatchName;
        private System.Windows.Forms.TextBox textBox6_BatchID;
    }
}