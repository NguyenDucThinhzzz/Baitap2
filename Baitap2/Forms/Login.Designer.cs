namespace Baitap2.Forms
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxUsername = new System.Windows.Forms.TextBox();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.CompanyLable = new System.Windows.Forms.Label();
			this.buttonLogin = new System.Windows.Forms.Button();
			this.buttonSignUp = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(75, 92);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(75, 140);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password: ";
			// 
			// textBoxUsername
			// 
			this.textBoxUsername.Location = new System.Drawing.Point(188, 93);
			this.textBoxUsername.Name = "textBoxUsername";
			this.textBoxUsername.Size = new System.Drawing.Size(189, 22);
			this.textBoxUsername.TabIndex = 2;
			this.textBoxUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUsername_KeyPress);
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(188, 143);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(189, 22);
			this.textBoxPassword.TabIndex = 3;
			this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassword_KeyPress);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.groupBox1.Controls.Add(this.CompanyLable);
			this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(482, 59);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// CompanyLable
			// 
			this.CompanyLable.AutoSize = true;
			this.CompanyLable.Cursor = System.Windows.Forms.Cursors.Default;
			this.CompanyLable.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CompanyLable.Location = new System.Drawing.Point(11, 18);
			this.CompanyLable.Name = "CompanyLable";
			this.CompanyLable.Size = new System.Drawing.Size(109, 24);
			this.CompanyLable.TabIndex = 1;
			this.CompanyLable.Text = "LaptopPoro";
			this.CompanyLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonLogin
			// 
			this.buttonLogin.Location = new System.Drawing.Point(79, 189);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(98, 43);
			this.buttonLogin.TabIndex = 5;
			this.buttonLogin.Text = "Login";
			this.buttonLogin.UseVisualStyleBackColor = true;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// buttonSignUp
			// 
			this.buttonSignUp.Location = new System.Drawing.Point(279, 189);
			this.buttonSignUp.Name = "buttonSignUp";
			this.buttonSignUp.Size = new System.Drawing.Size(98, 43);
			this.buttonSignUp.TabIndex = 6;
			this.buttonSignUp.Text = "Sign Up";
			this.buttonSignUp.UseVisualStyleBackColor = true;
			this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(482, 253);
			this.Controls.Add(this.buttonSignUp);
			this.Controls.Add(this.buttonLogin);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.textBoxUsername);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Login";
			this.Text = "Login";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxUsername;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label CompanyLable;
		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonSignUp;
	}
}