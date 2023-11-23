using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap2.Forms
{
	public partial class ReceiptViewer : Form
	{
		public ReceiptViewer()
		{
			InitializeComponent();
			initReceiptData();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void initReceiptData()
		{
			DataTable dt = ConnectData.ReadData("select * from HoaDonBan");
			dataGridViewReceipt.DataSource = dt;
		}
		private void dataGridViewReceipt_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dataGridViewReceipt.CurrentRow.Index == dataGridViewReceipt.RowCount - 1) return;
			string receiptID = dataGridViewReceipt.CurrentRow.Cells[0].Value.ToString();
			DataTable dt = ConnectData.ReadData("select * from ChiTietHD join ProductInfo on ChiTietHD.MaSP = ProductInfo.ProductID where ChiTietHD.MaHD = '" + receiptID +"'");
			dataGridViewReceiptInfo.DataSource = dt;
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			var confirmResult = MessageBox.Show("Are you sure to delete this receipt? You cannot undo this!", "Confirm Delete", MessageBoxButtons.YesNo);
			if (confirmResult == DialogResult.Yes)
			{
				string receiptID = dataGridViewReceipt.CurrentRow.Cells[0].Value.ToString();
				ConnectData.ChangeData("delete from ChiTietHD where ChiTietHD.MaHD = '" + receiptID + "'");
				ConnectData.ChangeData("delete from HoaDonBan where HoaDonBan.MaHD = '" + receiptID + "'");
				dataGridViewReceiptInfo.DataSource = null;
				initReceiptData();
			}
		}
	}
}
