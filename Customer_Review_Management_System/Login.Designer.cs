namespace Customer_Review_Management_System
{
	partial class Login
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
			this.usernametxt = new System.Windows.Forms.TextBox();
			this.loginbtn = new System.Windows.Forms.Button();
			this.signupbtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.passwordtxt = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// usernametxt
			// 
			this.usernametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernametxt.Location = new System.Drawing.Point(705, 154);
			this.usernametxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.usernametxt.Multiline = true;
			this.usernametxt.Name = "usernametxt";
			this.usernametxt.Size = new System.Drawing.Size(232, 37);
			this.usernametxt.TabIndex = 0;
			this.usernametxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// loginbtn
			// 
			this.loginbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginbtn.Location = new System.Drawing.Point(704, 324);
			this.loginbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.loginbtn.Name = "loginbtn";
			this.loginbtn.Size = new System.Drawing.Size(125, 49);
			this.loginbtn.TabIndex = 2;
			this.loginbtn.Text = "Login";
			this.loginbtn.UseVisualStyleBackColor = false;
			this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
			// 
			// signupbtn
			// 
			this.signupbtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.signupbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.signupbtn.Location = new System.Drawing.Point(837, 324);
			this.signupbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.signupbtn.Name = "signupbtn";
			this.signupbtn.Size = new System.Drawing.Size(126, 49);
			this.signupbtn.TabIndex = 3;
			this.signupbtn.Text = "Signup";
			this.signupbtn.UseVisualStyleBackColor = false;
			this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label1.Location = new System.Drawing.Point(707, 126);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 24);
			this.label1.TabIndex = 4;
			this.label1.Text = "Username";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label2.Location = new System.Drawing.Point(705, 224);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "Password";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label3.Location = new System.Drawing.Point(16, 11);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(228, 39);
			this.label3.TabIndex = 6;
			this.label3.Text = "Login Details";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// passwordtxt
			// 
			this.passwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordtxt.Location = new System.Drawing.Point(704, 267);
			this.passwordtxt.Name = "passwordtxt";
			this.passwordtxt.PasswordChar = '*';
			this.passwordtxt.Size = new System.Drawing.Size(233, 34);
			this.passwordtxt.TabIndex = 7;
			this.passwordtxt.UseSystemPasswordChar = true;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Customer_Review_Management_System.Properties.Resources.login12;
			this.ClientSize = new System.Drawing.Size(1043, 544);
			this.Controls.Add(this.passwordtxt);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.signupbtn);
			this.Controls.Add(this.loginbtn);
			this.Controls.Add(this.usernametxt);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximumSize = new System.Drawing.Size(1061, 591);
			this.MinimizeBox = false;
			this.Name = "Login";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Login_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox usernametxt;
		private System.Windows.Forms.Button loginbtn;
		private System.Windows.Forms.Button signupbtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox passwordtxt;
	}
}

