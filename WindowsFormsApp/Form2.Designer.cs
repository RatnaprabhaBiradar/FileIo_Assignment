namespace WindowsFormsApp
{
    partial class Registration_Form
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
            this.label1_Name = new System.Windows.Forms.Label();
            this.label2_Email = new System.Windows.Forms.Label();
            this.label3_ContactNo = new System.Windows.Forms.Label();
            this.label4_Adress = new System.Windows.Forms.Label();
            this.button1_Show = new System.Windows.Forms.Button();
            this.button2_Clear = new System.Windows.Forms.Button();
            this.textBox1_Name = new System.Windows.Forms.TextBox();
            this.textBox2_EmailId = new System.Windows.Forms.TextBox();
            this.textBox3_CNumber = new System.Windows.Forms.TextBox();
            this.textBox4_Address = new System.Windows.Forms.TextBox();
            this.label_showDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1_Name
            // 
            this.label1_Name.AutoSize = true;
            this.label1_Name.Location = new System.Drawing.Point(290, 67);
            this.label1_Name.Name = "label1_Name";
            this.label1_Name.Size = new System.Drawing.Size(35, 13);
            this.label1_Name.TabIndex = 0;
            this.label1_Name.Text = "Name";
            // 
            // label2_Email
            // 
            this.label2_Email.AutoSize = true;
            this.label2_Email.Location = new System.Drawing.Point(290, 106);
            this.label2_Email.Name = "label2_Email";
            this.label2_Email.Size = new System.Drawing.Size(44, 13);
            this.label2_Email.TabIndex = 1;
            this.label2_Email.Text = "Email Id";
            // 
            // label3_ContactNo
            // 
            this.label3_ContactNo.AutoSize = true;
            this.label3_ContactNo.Location = new System.Drawing.Point(290, 155);
            this.label3_ContactNo.Name = "label3_ContactNo";
            this.label3_ContactNo.Size = new System.Drawing.Size(84, 13);
            this.label3_ContactNo.TabIndex = 2;
            this.label3_ContactNo.Text = "Contact Number";
            // 
            // label4_Adress
            // 
            this.label4_Adress.AutoSize = true;
            this.label4_Adress.Location = new System.Drawing.Point(290, 207);
            this.label4_Adress.Name = "label4_Adress";
            this.label4_Adress.Size = new System.Drawing.Size(45, 13);
            this.label4_Adress.TabIndex = 3;
            this.label4_Adress.Text = "Address";
            // 
            // button1_Show
            // 
            this.button1_Show.Location = new System.Drawing.Point(272, 267);
            this.button1_Show.Name = "button1_Show";
            this.button1_Show.Size = new System.Drawing.Size(75, 23);
            this.button1_Show.TabIndex = 4;
            this.button1_Show.Text = "Show";
            this.button1_Show.UseVisualStyleBackColor = true;
            this.button1_Show.Click += new System.EventHandler(this.button1_Show_Click);
            // 
            // button2_Clear
            // 
            this.button2_Clear.Location = new System.Drawing.Point(420, 267);
            this.button2_Clear.Name = "button2_Clear";
            this.button2_Clear.Size = new System.Drawing.Size(75, 23);
            this.button2_Clear.TabIndex = 5;
            this.button2_Clear.Text = "Clear";
            this.button2_Clear.UseVisualStyleBackColor = true;
            this.button2_Clear.Click += new System.EventHandler(this.button2_Clear_Click);
            // 
            // textBox1_Name
            // 
            this.textBox1_Name.Location = new System.Drawing.Point(411, 60);
            this.textBox1_Name.Name = "textBox1_Name";
            this.textBox1_Name.Size = new System.Drawing.Size(100, 20);
            this.textBox1_Name.TabIndex = 6;
            this.textBox1_Name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2_EmailId
            // 
            this.textBox2_EmailId.Location = new System.Drawing.Point(411, 99);
            this.textBox2_EmailId.Name = "textBox2_EmailId";
            this.textBox2_EmailId.Size = new System.Drawing.Size(100, 20);
            this.textBox2_EmailId.TabIndex = 7;
            // 
            // textBox3_CNumber
            // 
            this.textBox3_CNumber.Location = new System.Drawing.Point(411, 148);
            this.textBox3_CNumber.Name = "textBox3_CNumber";
            this.textBox3_CNumber.Size = new System.Drawing.Size(100, 20);
            this.textBox3_CNumber.TabIndex = 8;
            // 
            // textBox4_Address
            // 
            this.textBox4_Address.Location = new System.Drawing.Point(411, 200);
            this.textBox4_Address.Name = "textBox4_Address";
            this.textBox4_Address.Size = new System.Drawing.Size(100, 20);
            this.textBox4_Address.TabIndex = 9;
            // 
            // label_showDetails
            // 
            this.label_showDetails.AutoSize = true;
            this.label_showDetails.Location = new System.Drawing.Point(620, 267);
            this.label_showDetails.Name = "label_showDetails";
            this.label_showDetails.Size = new System.Drawing.Size(39, 13);
            this.label_showDetails.TabIndex = 10;
            this.label_showDetails.Text = "Details";
            // 
            // Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_showDetails);
            this.Controls.Add(this.textBox4_Address);
            this.Controls.Add(this.textBox3_CNumber);
            this.Controls.Add(this.textBox2_EmailId);
            this.Controls.Add(this.textBox1_Name);
            this.Controls.Add(this.button2_Clear);
            this.Controls.Add(this.button1_Show);
            this.Controls.Add(this.label4_Adress);
            this.Controls.Add(this.label3_ContactNo);
            this.Controls.Add(this.label2_Email);
            this.Controls.Add(this.label1_Name);
            this.Name = "Registration_Form";
            this.Text = "Registration Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_Name;
        private System.Windows.Forms.Label label2_Email;
        private System.Windows.Forms.Label label3_ContactNo;
        private System.Windows.Forms.Label label4_Adress;
        private System.Windows.Forms.Button button1_Show;
        private System.Windows.Forms.Button button2_Clear;
        private System.Windows.Forms.TextBox textBox1_Name;
        private System.Windows.Forms.TextBox textBox2_EmailId;
        private System.Windows.Forms.TextBox textBox3_CNumber;
        private System.Windows.Forms.TextBox textBox4_Address;
        private System.Windows.Forms.Label label_showDetails;
    }
}