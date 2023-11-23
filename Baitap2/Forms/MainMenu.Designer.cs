using System;

namespace Baitap2
{
	partial class MainMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonCart = new System.Windows.Forms.Button();
			this.productManage_button = new System.Windows.Forms.Button();
			this.CompanyLable = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.labelUser = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.groupBox1.Controls.Add(this.labelUser);
			this.groupBox1.Controls.Add(this.buttonCart);
			this.groupBox1.Controls.Add(this.productManage_button);
			this.groupBox1.Controls.Add(this.CompanyLable);
			this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(1262, 59);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// buttonCart
			// 
			this.buttonCart.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonCart.Location = new System.Drawing.Point(1103, 10);
			this.buttonCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonCart.Name = "buttonCart";
			this.buttonCart.Size = new System.Drawing.Size(153, 42);
			this.buttonCart.TabIndex = 3;
			this.buttonCart.Text = "Shopping Cart";
			this.buttonCart.UseVisualStyleBackColor = true;
			this.buttonCart.Click += new System.EventHandler(this.buttonCart_Click);
			// 
			// productManage_button
			// 
			this.productManage_button.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.productManage_button.Location = new System.Drawing.Point(1135, 0);
			this.productManage_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.productManage_button.Name = "productManage_button";
			this.productManage_button.Size = new System.Drawing.Size(127, 62);
			this.productManage_button.TabIndex = 2;
			this.productManage_button.Text = "Product Manage";
			this.productManage_button.UseVisualStyleBackColor = true;
			this.productManage_button.Click += new System.EventHandler(this.button1_Click);
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
			this.CompanyLable.Click += new System.EventHandler(this.label1_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.flowLayoutPanel1.Controls.Add(this.panel1);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 59);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1262, 614);
			this.flowLayoutPanel1.TabIndex = 2;
			this.flowLayoutPanel1.WrapContents = false;
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(9, 8);
			this.panel1.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(878, 204);
			this.panel1.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.textBox1.Enabled = false;
			this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.textBox1.Location = new System.Drawing.Point(354, 35);
			this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(254, 158);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "this is the description";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.label2.Font = new System.Drawing.Font("Unispace", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(724, 164);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label2.Size = new System.Drawing.Size(151, 40);
			this.label2.TabIndex = 3;
			this.label2.Text = "9999$";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(348, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(175, 33);
			this.label1.TabIndex = 1;
			this.label1.Text = "Product Name";
			// 
			// labelUser
			// 
			this.labelUser.AutoSize = true;
			this.labelUser.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelUser.Location = new System.Drawing.Point(918, 18);
			this.labelUser.Name = "labelUser";
			this.labelUser.Size = new System.Drawing.Size(143, 24);
			this.labelUser.TabIndex = 4;
			this.labelUser.Text = "Welcome, Username";
			this.labelUser.Click += new System.EventHandler(this.labelUser_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Baitap2.Properties.Resources.yasuo;
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(345, 204);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(1262, 673);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainMenu";
			this.Text = "MainMenu";
			this.Load += new System.EventHandler(this.MainMenu_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label CompanyLable;
		private System.Windows.Forms.Button productManage_button;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonCart;
		private System.Windows.Forms.Label labelUser;
	}
}