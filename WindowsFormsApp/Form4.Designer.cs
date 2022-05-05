namespace WindowsFormsApp
{
    partial class Form4
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
            this.button1_Write.Location = new System.Drawing.Point(347, 323);
            this.button1_Write.Name = "button1_Write";
            this.button1_Write.Size = new System.Drawing.Size(75, 23);
            this.button1_Write.TabIndex = 6;
            this.button1_Write.Text = "Write To File";
            this.button1_Write.UseVisualStyleBackColor = true;
            this.button1_Write.Click += new System.EventHandler(this.button1_Write_Click);
            // 
            // button2_Read
            // 
            this.button2_Read.Location = new System.Drawing.Point(504, 323);
            this.button2_Read.Name = "button2_Read";
            this.button2_Read.Size = new System.Drawing.Size(75, 23);
            this.button2_Read.TabIndex = 7;
            this.button2_Read.Text = "Read From File";
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
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
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
    }
}