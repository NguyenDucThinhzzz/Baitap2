namespace Baitap2.Forms
{
	partial class ReceiptViewer
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
			this.label1 = new System.Windows.Forms.Label();
			this.CompanyLable = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.dataGridViewReceipt = new System.Windows.Forms.DataGridView();
			this.dataGridViewReceiptInfo = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipt)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceiptInfo)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.CompanyLable);
			this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(1093, 59);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(515, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "Reciept Viewer";
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
			// panel1
			// 
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.buttonDelete);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 591);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1093, 52);
			this.panel1.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(686, 17);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(72, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Exit";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(68, 17);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(150, 23);
			this.buttonDelete.TabIndex = 0;
			this.buttonDelete.Text = "Delete Receipt";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// dataGridViewReceipt
			// 
			this.dataGridViewReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewReceipt.Dock = System.Windows.Forms.DockStyle.Left;
			this.dataGridViewReceipt.Location = new System.Drawing.Point(0, 59);
			this.dataGridViewReceipt.Name = "dataGridViewReceipt";
			this.dataGridViewReceipt.RowHeadersWidth = 51;
			this.dataGridViewReceipt.RowTemplate.Height = 24;
			this.dataGridViewReceipt.Size = new System.Drawing.Size(332, 532);
			this.dataGridViewReceipt.TabIndex = 4;
			this.dataGridViewReceipt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReceipt_CellClick);
			// 
			// dataGridViewReceiptInfo
			// 
			this.dataGridViewReceiptInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewReceiptInfo.Dock = System.Windows.Forms.DockStyle.Right;
			this.dataGridViewReceiptInfo.Location = new System.Drawing.Point(340, 59);
			this.dataGridViewReceiptInfo.Name = "dataGridViewReceiptInfo";
			this.dataGridViewReceiptInfo.RowHeadersWidth = 51;
			this.dataGridViewReceiptInfo.RowTemplate.Height = 24;
			this.dataGridViewReceiptInfo.Size = new System.Drawing.Size(753, 532);
			this.dataGridViewReceiptInfo.TabIndex = 5;
			// 
			// ReceiptViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1093, 643);
			this.Controls.Add(this.dataGridViewReceiptInfo);
			this.Controls.Add(this.dataGridViewReceipt);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox1);
			this.Name = "ReceiptViewer";
			this.Text = "ReceiptViewer";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipt)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceiptInfo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label CompanyLable;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dataGridViewReceipt;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.DataGridView dataGridViewReceiptInfo;
		private System.Windows.Forms.Button button1;
	}
}