namespace WindowsFormsApp
{
    partial class StudentForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1_RollNo = new System.Windows.Forms.TextBox();
            this.textBox2_Name = new System.Windows.Forms.TextBox();
            this.textBox3_Email = new System.Windows.Forms.TextBox();
            this.textBox4_ContactNo = new System.Windows.Forms.TextBox();
            this.textBox5_Bdate = new System.Windows.Forms.TextBox();
            this.textBox6_City = new System.Windows.Forms.TextBox();
            this.button1_WriteFile = new System.Windows.Forms.Button();
            this.button2_Read = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roll No";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Birth Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "City";
            // 
            // textBox1_RollNo
            // 
            this.textBox1_RollNo.Location = new System.Drawing.Point(447, 68);
            this.textBox1_RollNo.Name = "textBox1_RollNo";
            this.textBox1_RollNo.Size = new System.Drawing.Size(100, 20);
            this.textBox1_RollNo.TabIndex = 6;
            // 
            // textBox2_Name
            // 
            this.textBox2_Name.Location = new System.Drawing.Point(447, 107);
            this.textBox2_Name.Name = "textBox2_Name";
            this.textBox2_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox2_Name.TabIndex = 7;
            // 
            // textBox3_Email
            // 
            this.textBox3_Email.Location = new System.Drawing.Point(447, 146);
            this.textBox3_Email.Name = "textBox3_Email";
            this.textBox3_Email.Size = new System.Drawing.Size(100, 20);
            this.textBox3_Email.TabIndex = 8;
            // 
            // textBox4_ContactNo
            // 
            this.textBox4_ContactNo.Location = new System.Drawing.Point(447, 184);
            this.textBox4_ContactNo.Name = "textBox4_ContactNo";
            this.textBox4_ContactNo.Size = new System.Drawing.Size(100, 20);
            this.textBox4_ContactNo.TabIndex = 9;
            // 
            // textBox5_Bdate
            // 
            this.textBox5_Bdate.Location = new System.Drawing.Point(447, 226);
            this.textBox5_Bdate.Name = "textBox5_Bdate";
            this.textBox5_Bdate.Size = new System.Drawing.Size(100, 20);
            this.textBox5_Bdate.TabIndex = 10;
            // 
            // textBox6_City
            // 
            this.textBox6_City.Location = new System.Drawing.Point(447, 267);
            this.textBox6_City.Name = "textBox6_City";
            this.textBox6_City.Size = new System.Drawing.Size(100, 20);
            this.textBox6_City.TabIndex = 11;
            // 
            // button1_WriteFile
            // 
            this.button1_WriteFile.Location = new System.Drawing.Point(285, 312);
            this.button1_WriteFile.Name = "button1_WriteFile";
            this.button1_WriteFile.Size = new System.Drawing.Size(107, 23);
            this.button1_WriteFile.TabIndex = 12;
            this.button1_WriteFile.Text = "Binary Write To File";
            this.button1_WriteFile.UseVisualStyleBackColor = true;
            this.button1_WriteFile.Click += new System.EventHandler(this.button1_WriteFile_Click);
            // 
            // button2_Read
            // 
            this.button2_Read.Location = new System.Drawing.Point(447, 312);
            this.button2_Read.Name = "button2_Read";
            this.button2_Read.Size = new System.Drawing.Size(100, 23);
            this.button2_Read.TabIndex = 13;
            this.button2_Read.Text = "Binary Read From File";
            this.button2_Read.UseVisualStyleBackColor = true;
            this.button2_Read.Click += new System.EventHandler(this.button2_Read_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(593, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Student Information";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2_Read);
            this.Controls.Add(this.button1_WriteFile);
            this.Controls.Add(this.textBox6_City);
            this.Controls.Add(this.textBox5_Bdate);
            this.Controls.Add(this.textBox4_ContactNo);
            this.Controls.Add(this.textBox3_Email);
            this.Controls.Add(this.textBox2_Name);
            this.Controls.Add(this.textBox1_RollNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1_RollNo;
        private System.Windows.Forms.TextBox textBox2_Name;
        private System.Windows.Forms.TextBox textBox3_Email;
        private System.Windows.Forms.TextBox textBox4_ContactNo;
        private System.Windows.Forms.TextBox textBox5_Bdate;
        private System.Windows.Forms.TextBox textBox6_City;
        private System.Windows.Forms.Button button1_WriteFile;
        private System.Windows.Forms.Button button2_Read;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
    }
}