namespace Assignment2
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.newUserB = new System.Windows.Forms.Button();
            this.exitB = new System.Windows.Forms.Button();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passwordTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.usernameTB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // newUserB
            // 
            this.newUserB.Location = new System.Drawing.Point(93, 124);
            this.newUserB.Name = "newUserB";
            this.newUserB.Size = new System.Drawing.Size(100, 27);
            this.newUserB.TabIndex = 6;
            this.newUserB.Text = "New User";
            this.newUserB.UseVisualStyleBackColor = true;
            this.newUserB.Click += new System.EventHandler(this.newUserB_Click);
            // 
            // exitB
            // 
            this.exitB.Location = new System.Drawing.Point(199, 124);
            this.exitB.Name = "exitB";
            this.exitB.Size = new System.Drawing.Size(75, 27);
            this.exitB.TabIndex = 5;
            this.exitB.Text = "Exit";
            this.exitB.UseVisualStyleBackColor = true;
            this.exitB.Click += new System.EventHandler(this.exitB_Click);
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(97, 67);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(146, 23);
            this.passwordTB.TabIndex = 4;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // loginB
            // 
            this.loginB.Location = new System.Drawing.Point(12, 124);
            this.loginB.Name = "loginB";
            this.loginB.Size = new System.Drawing.Size(75, 27);
            this.loginB.TabIndex = 2;
            this.loginB.Text = "Login";
            this.loginB.UseVisualStyleBackColor = true;
            this.loginB.Click += new System.EventHandler(this.loginB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(97, 22);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(146, 23);
            this.usernameTB.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 163);
            this.Controls.Add(this.newUserB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exitB);
            this.Controls.Add(this.loginB);
            this.Name = "Form1";
            this.Text = "Login ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Button loginB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitB;
        private System.Windows.Forms.Button newUserB;
    }
}

