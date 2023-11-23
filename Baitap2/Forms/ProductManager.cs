using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Baitap2
{
	public partial class ProductManager : Form
	{
		private MainMenu menu;
		string insertString = "insert into ProductInfo(ProductID,MftID,ProductName,ProductPrice,ProductDescription,ProductPicture)";
		public ProductManager(MainMenu menu)
		{
			InitializeComponent();
			this.Text = "Laptop Manager";
			this.menu = menu;
			LoadData();
		}

		private void form1_Load(object sender, EventArgs e)
		{
			
		}

		private void LoadData()
		{
			productDataList.DataSource = menu.DataTable;
			productDataList.Columns[0].HeaderText = "ID";
			productDataList.Columns[1].HeaderText = "Name";
			productDataList.Columns[2].HeaderText = "Manufacture ID";
			productDataList.Columns[3].HeaderText = "Price";
			productDataList.Columns[4].HeaderText = "Description";
			productDataList.Columns[5].HeaderText = "Picture";

			DataTable dataTable = ConnectData.ReadData("Select * from ManufactureInfo");
			initComboBox(comboBoxManufacture, dataTable, "MftName", "MftID");
			pictureBox1.ImageLocation = "";
		}
		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void textBoxDonGiaBan_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void buttonThem_Click(object sender, EventArgs e)
		{
			string des = "";
			foreach(string s in textBoxSpec.Lines)
			{
				des += s + "$";
			}
			if (pictureBox1.ImageLocation == "")
			{
				var error = MessageBox.Show("Cannot find the file on the system!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return;
			}
			ConnectData.ChangeData(insertString + "values ('" + textBoxID.Text + "','" + comboBoxManufacture.SelectedValue + "','" + textBoxName.Text + "'," + textBoxPrice.Text+ ",'" + des + "',(SELECT BulkColumn FROM Openrowset(Bulk '"+ pictureBox1.ImageLocation +"', Single_Blob) as image))");
			pictureBox1.ImageLocation = "";
			ReloadDatabase();
		}

		private void buttonSua_Click(object sender, EventArgs e)
		{
			var confirmResult = MessageBox.Show("Are you sure to update this product's info? You cannot undo this!", "Confirm Update", MessageBoxButtons.YesNo);
			if (confirmResult == DialogResult.Yes)
			{
				string des = "";
				foreach (string s in textBoxSpec.Lines)
				{
					des += s + "$";
				}
				ConnectData.ChangeData("Update ProductInfo set ProductID = '" + textBoxID.Text + "', MftID = '" + comboBoxManufacture.SelectedValue + "', ProductName = '" + textBoxName.Text + "', ProductPrice = " + textBoxPrice.Text + ", ProductDescription = '" + des + "' where ProductID = '"+ productDataList.CurrentRow.Cells[0].Value.ToString() +"'");
				if (pictureBox1.ImageLocation != "")
				{
					ConnectData.ChangeData("Update ProductInfo set ProductPicture = (SELECT BulkColumn FROM Openrowset(Bulk '" + pictureBox1.ImageLocation + "', Single_Blob) as image) where ProductID = '"+ productDataList.CurrentRow.Cells[0].Value.ToString() +"'");
					pictureBox1.ImageLocation = "";
				}
				ReloadDatabase();
			}
		}

		private void buttonXoa_Click(object sender, EventArgs e)
		{
			var confirmResult = MessageBox.Show("Are you sure to delete this product? You cannot undo this!", "Confirm Delete", MessageBoxButtons.YesNo);
			if (confirmResult == DialogResult.Yes)
			{
				ConnectData.ChangeData("delete from ProductInfo where ProductID = '" + productDataList.CurrentRow.Cells[0].Value.ToString() + "'");
				ReloadDatabase();
			}
		}
		private void buttonBoQua_Click(object sender, EventArgs e)
		{
			textBoxID.Text = productDataList.CurrentRow.Cells[0].Value.ToString();
			comboBoxManufacture.SelectedValue = productDataList.CurrentRow.Cells[1].Value.ToString();
			textBoxName.Text = productDataList.CurrentRow.Cells[2].Value.ToString();
			textBoxPrice.Text = productDataList.CurrentRow.Cells[3].Value.ToString();
			textBoxSpec.Lines = productDataList.CurrentRow.Cells[4].Value.ToString().Split('$');
			pictureBox1.Image = Utilities.GetImageFromByteArray((byte[])productDataList.CurrentRow.Cells[5].Value);
		}

		private void buttonThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		protected override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);
			menu.InitProducts();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (productDataList.CurrentRow.Index == productDataList.RowCount-1) return;
			textBoxID.Text = productDataList.CurrentRow.Cells[0].Value.ToString();
			comboBoxManufacture.SelectedValue = productDataList.CurrentRow.Cells[1].Value.ToString();
			textBoxName.Text = productDataList.CurrentRow.Cells[2].Value.ToString();
			textBoxPrice.Text = productDataList.CurrentRow.Cells[3].Value.ToString();
			textBoxSpec.Lines = productDataList.CurrentRow.Cells[4].Value.ToString().Split('$');
			pictureBox1.Image = Utilities.GetImageFromByteArray((byte[])productDataList.CurrentRow.Cells[5].Value);
		}

		private void initComboBox(ComboBox comboBox, DataTable dataTable, string displayMember, string valueMember)
		{
			comboBox.DataSource = dataTable;
			comboBox.DisplayMember = displayMember;
			comboBox.ValueMember = valueMember;
		}

		private void buttonChangePicture_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog dlg = new OpenFileDialog())
			{
				dlg.Title = "Open Image";

				if (dlg.ShowDialog() == DialogResult.OK)
				{
					pictureBox1.Image = new Bitmap(dlg.FileName);
					pictureBox1.ImageLocation = dlg.FileName;
				}
			}
		}

		private void ReloadDatabase()
		{
			productDataList.DataSource = ConnectData.ReadData("Select * from ProductInfo inner join ManufactureInfo on ProductInfo.MftID = ManufactureInfo.MftID");
		}

		private void textBoxSpec_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
