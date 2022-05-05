namespace WindowsFormsApp
{
    partial class EmployeeForm
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
            this.button1_WriteFile = new System.Windows.Forms.Button();
            this.button2_ReadFile = new System.Windows.Forms.Button();
            this.button3_Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1_EmpId = new System.Windows.Forms.TextBox();
            this.textBox2_Name = new System.Windows.Forms.TextBox();
            this.textBox3_EmpelailId = new System.Windows.Forms.TextBox();
            this.textBox4_Bdate = new System.Windows.Forms.TextBox();
            this.textBox5_JoiningDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1_WriteFile
            // 
            this.button1_WriteFile.Location = new System.Drawing.Point(295, 336);
            this.button1_WriteFile.Name = "button1_WriteFile";
            this.button1_WriteFile.Size = new System.Drawing.Size(75, 23);
            this.button1_WriteFile.TabIndex = 0;
            this.button1_WriteFile.Text = "Write on File";
            this.button1_WriteFile.UseVisualStyleBackColor = true;
            this.button1_WriteFile.Click += new System.EventHandler(this.button1_WriteFile_Click);
            // 
            // button2_ReadFile
            // 
            this.button2_ReadFile.Location = new System.Drawing.Point(431, 336);
            this.button2_ReadFile.Name = "button2_ReadFile";
            this.button2_ReadFile.Size = new System.Drawing.Size(75, 23);
            this.button2_ReadFile.TabIndex = 1;
            this.button2_ReadFile.Text = "Read From File";
            this.button2_ReadFile.UseVisualStyleBackColor = true;
            this.button2_ReadFile.Click += new System.EventHandler(this.button2_ReadFile_Click);
            // 
            // button3_Clear
            // 
            this.button3_Clear.Location = new System.Drawing.Point(575, 336);
            this.button3_Clear.Name = "button3_Clear";
            this.button3_Clear.Size = new System.Drawing.Size(75, 23);
            this.button3_Clear.TabIndex = 2;
            this.button3_Clear.Text = "Clear";
            this.button3_Clear.UseVisualStyleBackColor = true;
            this.button3_Clear.Click += new System.EventHandler(this.button3_Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee Id";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(312, 165);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(84, 13);
            this.Name.TabIndex = 4;
            this.Name.Text = "Employee Name";
            this.Name.Click += new System.EventHandler(this.Name_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Birth date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Joining Date";
            // 
            // textBox1_EmpId
            // 
            this.textBox1_EmpId.Location = new System.Drawing.Point(431, 110);
            this.textBox1_EmpId.Name = "textBox1_EmpId";
            this.textBox1_EmpId.Size = new System.Drawing.Size(100, 20);
            this.textBox1_EmpId.TabIndex = 8;
            // 
            // textBox2_Name
            // 
            this.textBox2_Name.Location = new System.Drawing.Point(431, 158);
            this.textBox2_Name.Name = "textBox2_Name";
            this.textBox2_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox2_Name.TabIndex = 9;
            // 
            // textBox3_EmpelailId
            // 
            this.textBox3_EmpelailId.Location = new System.Drawing.Point(431, 201);
            this.textBox3_EmpelailId.Name = "textBox3_EmpelailId";
            this.textBox3_EmpelailId.Size = new System.Drawing.Size(100, 20);
            this.textBox3_EmpelailId.TabIndex = 10;
            this.textBox3_EmpelailId.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4_Bdate
            // 
            this.textBox4_Bdate.Location = new System.Drawing.Point(431, 237);
            this.textBox4_Bdate.Name = "textBox4_Bdate";
            this.textBox4_Bdate.Size = new System.Drawing.Size(100, 20);
            this.textBox4_Bdate.TabIndex = 11;
            this.textBox4_Bdate.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5_JoiningDate
            // 
            this.textBox5_JoiningDate.Location = new System.Drawing.Point(431, 288);
            this.textBox5_JoiningDate.Name = "textBox5_JoiningDate";
            this.textBox5_JoiningDate.Size = new System.Drawing.Size(100, 20);
            this.textBox5_JoiningDate.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Employee Information";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5_JoiningDate);
            this.Controls.Add(this.textBox4_Bdate);
            this.Controls.Add(this.textBox3_EmpelailId);
            this.Controls.Add(this.textBox2_Name);
            this.Controls.Add(this.textBox1_EmpId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3_Clear);
            this.Controls.Add(this.button2_ReadFile);
            this.Controls.Add(this.button1_WriteFile);
           // this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_WriteFile;
        private System.Windows.Forms.Button button2_ReadFile;
        private System.Windows.Forms.Button button3_Clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1_EmpId;
        private System.Windows.Forms.TextBox textBox2_Name;
        private System.Windows.Forms.TextBox textBox3_EmpelailId;
        private System.Windows.Forms.TextBox textBox4_Bdate;
        private System.Windows.Forms.TextBox textBox5_JoiningDate;
        private System.Windows.Forms.Label label6;
    }
}