using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap2
{
	public partial class ShoppingCart : Form
	{
		public MainMenu mainMenu;
		private List<ProductCartPane> panels;
		public ShoppingCart(MainMenu mainMenu)
		{
			InitializeComponent();
			this.mainMenu = mainMenu;
			panels = new List<ProductCartPane>();
			panelDefault.Visible = false;
			DrawItems();
			CalculateTotal();
		}
		
		private void DrawItems()
		{
			foreach (var x in mainMenu.ShoppingCartData.Items)
			{
				DataRow row = ConnectData.ReadData("select * from ProductInfo where ProductInfo.ProductID = '" + x.Key + "'").Rows[0];
				var ID = row.Field<string>(0);
				var manufacture = row.Field<string>(1);
				var name = row.Field<string>(2);
				var price = (int)row.Field<Decimal>(3);
				var description = row.Field<string>(4);
				var picture = Utilities.GetImageFromByteArray(row.Field<Byte[]>(5));
				ProductCartPane panel = new ProductCartPane(this, ID, picture, name, price, x.Value);
				panel.SetupProductPanel(flowLayoutPanel1,panelDefault,pictureBoxDefault,labelNameDefault,labelPriceDefault,lableAmountDefault,buttonDeleteDefault);
				panels.Add(panel);
			}
		}
		private void lableAmountDefault_Click(object sender, EventArgs e)
		{

		}
		public long CalculateTotal()
		{
			long total = 0;
			foreach (var x in mainMenu.ShoppingCartData.Items)
			{
				DataRow row = ConnectData.ReadData("select * from ProductInfo where ProductInfo.ProductID = '" + x.Key + "'").Rows[0];
				var price = (int)row.Field<Decimal>(3);
				total += price * x.Value;
			}
			labelPrice.Text = total + "$";
			return total;
		}

		private void buttonBuy_Click(object sender, EventArgs e)
		{
			addReceiptToSQL();
		}

		private void addReceiptToSQL()
		{
			DataTable dt = ConnectData.ReadData("select * from HoaDonBan");
			string receiptID = "MHD" + dt.Rows.Count;
			string customerID = ConnectData.ReadData("select * from KhachHang where KhachHang.Username = '"+ mainMenu.User.Name + "'").Rows[0].Field<string>("MaKH");
			ConnectData.ChangeData("insert into HoaDonBan(MaHD,MaNV,NgayBan,MaKH,TongTien)" +
									"values('"+ receiptID +"','ONLINE',GETDATE(),'"+ customerID +"',"+ CalculateTotal()+")");
			foreach(ProductCartPane product in panels)
			{
				long total = long.Parse(product.ProductPrice.Text) * int.Parse(product.ProductAmount.Text);
				ConnectData.ChangeData("insert into ChiTietHD(MaHD,MaSP,SoLuong,TongTien)" +
										"values('"+ receiptID +"','"+ product.ID +"',"+ product.ProductAmount.Text +","+ total +")");
			}
		}
	}
}
