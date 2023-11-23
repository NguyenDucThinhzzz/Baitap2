namespace Baitap2
{
	partial class ProductManager
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManager));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBoxPrice = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxID = new System.Windows.Forms.TextBox();
			this.textBoxSpec = new System.Windows.Forms.TextBox();
			this.comboBoxManufacture = new System.Windows.Forms.ComboBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.buttonChangePicture = new System.Windows.Forms.Button();
			this.labelSpec = new System.Windows.Forms.Label();
			this.labelSellPrice = new System.Windows.Forms.Label();
			this.labelManufacture = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.labelID = new System.Windows.Forms.Label();
			this.productDataList = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.buttonThoat = new System.Windows.Forms.Button();
			this.buttonReset = new System.Windows.Forms.Button();
			this.buttonXoa = new System.Windows.Forms.Button();
			this.buttonSua = new System.Windows.Forms.Button();
			this.buttonThem = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productDataList)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxPrice);
			this.groupBox1.Controls.Add(this.textBoxName);
			this.groupBox1.Controls.Add(this.textBoxID);
			this.groupBox1.Controls.Add(this.textBoxSpec);
			this.groupBox1.Controls.Add(this.comboBoxManufacture);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.buttonChangePicture);
			this.groupBox1.Controls.Add(this.labelSpec);
			this.groupBox1.Controls.Add(this.labelSellPrice);
			this.groupBox1.Controls.Add(this.labelManufacture);
			this.groupBox1.Controls.Add(this.labelName);
			this.groupBox1.Controls.Add(this.labelID);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(1262, 329);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "SQL Data Manager";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// textBoxPrice
			// 
			this.textBoxPrice.Location = new System.Drawing.Point(108, 248);
			this.textBoxPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxPrice.Name = "textBoxPrice";
			this.textBoxPrice.Size = new System.Drawing.Size(451, 22);
			this.textBoxPrice.TabIndex = 23;
			this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxDonGiaBan_TextChanged);
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(108, 72);
			this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(451, 22);
			this.textBoxName.TabIndex = 20;
			// 
			// textBoxID
			// 
			this.textBoxID.Location = new System.Drawing.Point(108, 36);
			this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxID.Name = "textBoxID";
			this.textBoxID.Size = new System.Drawing.Size(451, 22);
			this.textBoxID.TabIndex = 19;
			// 
			// textBoxSpec
			// 
			this.textBoxSpec.Location = new System.Drawing.Point(108, 148);
			this.textBoxSpec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxSpec.Multiline = true;
			this.textBoxSpec.Name = "textBoxSpec";
			this.textBoxSpec.Size = new System.Drawing.Size(451, 87);
			this.textBoxSpec.TabIndex = 18;
			this.textBoxSpec.TextChanged += new System.EventHandler(this.textBoxSpec_TextChanged);
			// 
			// comboBoxManufacture
			// 
			this.comboBoxManufacture.FormattingEnabled = true;
			this.comboBoxManufacture.Items.AddRange(new object[] {
            "Asus",
            "Gigabyte",
            "Acer",
            "Dell",
            "HP",
            "Apple",
            "Toshiba",
            "Lenovo"});
			this.comboBoxManufacture.Location = new System.Drawing.Point(108, 106);
			this.comboBoxManufacture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.comboBoxManufacture.Name = "comboBoxManufacture";
			this.comboBoxManufacture.Size = new System.Drawing.Size(451, 24);
			this.comboBoxManufacture.TabIndex = 17;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
			this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
			this.pictureBox1.Location = new System.Drawing.Point(859, 19);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(391, 225);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// buttonChangePicture
			// 
			this.buttonChangePicture.Location = new System.Drawing.Point(734, 198);
			this.buttonChangePicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonChangePicture.Name = "buttonChangePicture";
			this.buttonChangePicture.Size = new System.Drawing.Size(106, 46);
			this.buttonChangePicture.TabIndex = 8;
			this.buttonChangePicture.Text = "Change Picture";
			this.buttonChangePicture.UseVisualStyleBackColor = true;
			this.buttonChangePicture.Click += new System.EventHandler(this.buttonChangePicture_Click);
			// 
			// labelSpec
			// 
			this.labelSpec.AutoSize = true;
			this.labelSpec.Location = new System.Drawing.Point(10, 148);
			this.labelSpec.Name = "labelSpec";
			this.labelSpec.Size = new System.Drawing.Size(91, 16);
			this.labelSpec.TabIndex = 7;
			this.labelSpec.Text = "Specifications";
			// 
			// labelSellPrice
			// 
			this.labelSellPrice.AutoSize = true;
			this.labelSellPrice.Location = new System.Drawing.Point(10, 254);
			this.labelSellPrice.Name = "labelSellPrice";
			this.labelSellPrice.Size = new System.Drawing.Size(64, 16);
			this.labelSellPrice.TabIndex = 6;
			this.labelSellPrice.Text = "Sell Price";
			// 
			// labelManufacture
			// 
			this.labelManufacture.AutoSize = true;
			this.labelManufacture.Location = new System.Drawing.Point(10, 108);
			this.labelManufacture.Name = "labelManufacture";
			this.labelManufacture.Size = new System.Drawing.Size(80, 16);
			this.labelManufacture.TabIndex = 3;
			this.labelManufacture.Text = "Manufacture";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(10, 72);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(44, 16);
			this.labelName.TabIndex = 1;
			this.labelName.Text = "Name";
			// 
			// labelID
			// 
			this.labelID.AutoSize = true;
			this.labelID.Location = new System.Drawing.Point(10, 36);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(20, 16);
			this.labelID.TabIndex = 0;
			this.labelID.Text = "ID";
			// 
			// productDataList
			// 
			this.productDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.productDataList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.productDataList.Location = new System.Drawing.Point(0, 329);
			this.productDataList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.productDataList.Name = "productDataList";
			this.productDataList.RowHeadersWidth = 62;
			this.productDataList.RowTemplate.Height = 28;
			this.productDataList.Size = new System.Drawing.Size(1262, 344);
			this.productDataList.TabIndex = 6;
			this.productDataList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.buttonThoat);
			this.groupBox2.Controls.Add(this.buttonReset);
			this.groupBox2.Controls.Add(this.buttonXoa);
			this.groupBox2.Controls.Add(this.buttonSua);
			this.groupBox2.Controls.Add(this.buttonThem);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox2.Location = new System.Drawing.Point(0, 593);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox2.Size = new System.Drawing.Size(1262, 80);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			// 
			// buttonThoat
			// 
			this.buttonThoat.Location = new System.Drawing.Point(1072, 20);
			this.buttonThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonThoat.Name = "buttonThoat";
			this.buttonThoat.Size = new System.Drawing.Size(178, 40);
			this.buttonThoat.TabIndex = 10;
			this.buttonThoat.Text = "Exit";
			this.buttonThoat.UseVisualStyleBackColor = true;
			this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
			// 
			// buttonReset
			// 
			this.buttonReset.Location = new System.Drawing.Point(828, 20);
			this.buttonReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.Size = new System.Drawing.Size(178, 40);
			this.buttonReset.TabIndex = 9;
			this.buttonReset.Text = "Reset";
			this.buttonReset.UseVisualStyleBackColor = true;
			this.buttonReset.Click += new System.EventHandler(this.buttonBoQua_Click);
			// 
			// buttonXoa
			// 
			this.buttonXoa.Location = new System.Drawing.Point(575, 20);
			this.buttonXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonXoa.Name = "buttonXoa";
			this.buttonXoa.Size = new System.Drawing.Size(178, 40);
			this.buttonXoa.TabIndex = 8;
			this.buttonXoa.Text = "Delete";
			this.buttonXoa.UseVisualStyleBackColor = true;
			this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
			// 
			// buttonSua
			// 
			this.buttonSua.Location = new System.Drawing.Point(294, 20);
			this.buttonSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonSua.Name = "buttonSua";
			this.buttonSua.Size = new System.Drawing.Size(178, 40);
			this.buttonSua.TabIndex = 7;
			this.buttonSua.Text = "Change";
			this.buttonSua.UseVisualStyleBackColor = true;
			this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
			// 
			// buttonThem
			// 
			this.buttonThem.Location = new System.Drawing.Point(25, 20);
			this.buttonThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonThem.Name = "buttonThem";
			this.buttonThem.Size = new System.Drawing.Size(178, 40);
			this.buttonThem.TabIndex = 6;
			this.buttonThem.Text = "Add";
			this.buttonThem.UseVisualStyleBackColor = true;
			this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
			// 
			// ProductManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1262, 673);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.productDataList);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "ProductManager";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productDataList)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonChangePicture;
		private System.Windows.Forms.Label labelSpec;
		private System.Windows.Forms.Label labelSellPrice;
		private System.Windows.Forms.Label labelManufacture;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelID;
		private System.Windows.Forms.ComboBox comboBoxManufacture;
		private System.Windows.Forms.TextBox textBoxPrice;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxID;
		private System.Windows.Forms.TextBox textBoxSpec;
		private System.Windows.Forms.DataGridView productDataList;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button buttonThoat;
		private System.Windows.Forms.Button buttonReset;
		private System.Windows.Forms.Button buttonXoa;
		private System.Windows.Forms.Button buttonSua;
		private System.Windows.Forms.Button buttonThem;
	}
}

