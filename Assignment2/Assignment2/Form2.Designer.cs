namespace Assignment2
{
    partial class Form2
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
            this.cancelB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rePasswordTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firstnameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lastnameTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dobTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.typeCB = new System.Windows.Forms.ComboBox();
            this.submitB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(158, 319);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(134, 23);
            this.cancelB.TabIndex = 0;
            this.cancelB.Text = "Cancel";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.typeCB);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dobTB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lastnameTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.firstnameTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rePasswordTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.passwordTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.usernameTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 289);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(157, 41);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(100, 23);
            this.usernameTB.TabIndex = 1;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(157, 74);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(100, 23);
            this.passwordTB.TabIndex = 3;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // rePasswordTB
            // 
            this.rePasswordTB.Location = new System.Drawing.Point(157, 108);
            this.rePasswordTB.Name = "rePasswordTB";
            this.rePasswordTB.Size = new System.Drawing.Size(100, 23);
            this.rePasswordTB.TabIndex = 5;
            this.rePasswordTB.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Re-Enter Password:";
            // 
            // firstnameTB
            // 
            this.firstnameTB.Location = new System.Drawing.Point(157, 140);
            this.firstnameTB.Name = "firstnameTB";
            this.firstnameTB.Size = new System.Drawing.Size(100, 23);
            this.firstnameTB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "First Name:";
            // 
            // lastnameTB
            // 
            this.lastnameTB.Location = new System.Drawing.Point(157, 173);
            this.lastnameTB.Name = "lastnameTB";
            this.lastnameTB.Size = new System.Drawing.Size(100, 23);
            this.lastnameTB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Last Name:";
            // 
            // dobTB
            // 
            this.dobTB.Location = new System.Drawing.Point(157, 205);
            this.dobTB.Name = "dobTB";
            this.dobTB.Size = new System.Drawing.Size(100, 23);
            this.dobTB.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date of Birth:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "User-Type:";
            // 
            // typeCB
            // 
            this.typeCB.FormattingEnabled = true;
            this.typeCB.Items.AddRange(new object[] {
            "View",
            "Edit"});
            this.typeCB.Location = new System.Drawing.Point(157, 239);
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(100, 24);
            this.typeCB.TabIndex = 13;
            this.typeCB.Text = "Select One";
            // 
            // submitB
            // 
            this.submitB.Location = new System.Drawing.Point(14, 318);
            this.submitB.Name = "submitB";
            this.submitB.Size = new System.Drawing.Size(128, 23);
            this.submitB.TabIndex = 2;
            this.submitB.Text = "Submit";
            this.submitB.UseVisualStyleBackColor = true;
            this.submitB.Click += new System.EventHandler(this.submitB_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 361);
            this.Controls.Add(this.submitB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelB);
            this.Name = "Form2";
            this.Text = "New User";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dobTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lastnameTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox firstnameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rePasswordTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Button submitB;
    }
}