using Baitap2.Forms;
using Baitap2.Scripts.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Baitap2
{
	public partial class MainMenu : Form
	{
		public User User { get; private set; }
		public List<ProductPane> panels { get; private set; }
		public ShoppingCartData ShoppingCartData { get; private set; } = new ShoppingCartData();
		public DataTable DataTable { get; set; }
		public MainMenu(User user)
		{
			InitializeComponent();
			this.User = user;
			panel1.Visible = false;
			labelUser.Text = "Welcome, " + User.Name;
			userSetup();
			InitProducts();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{	
			ProductManager productManager= new ProductManager(this);
			productManager.Show();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void AddProductPane(string id, Image image, string name, int price, string description)
		{
			ProductPane pane = new ProductPane(this,id,image,name,price,description);
			pane.SetupProductPanel(flowLayoutPanel1, panel1, pictureBox1, label1, label2, textBox1);
			panels.Add(pane);
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void MainMenu_Load(object sender, EventArgs e)
		{

		}

		private void RemoveProductByID(string id)
		{
			ProductPane temp = null;
			foreach (ProductPane pane in panels)
			{
				if(pane.ID.CompareTo(id) == 0)
				{
					temp = pane;
					break;
				}
			}
			if (temp != null)
			{
				panels.Remove(temp);
			}
		}
		public void InitProducts()
		{
			if (panels != null)
			{
				foreach (ProductPane pane in panels)
				{
					pane.Destroy();
				}
				panels = null;
			}
			panels = new List<ProductPane>();
			DataTable = ConnectData.ReadData("Select * from ProductInfo inner join ManufactureInfo on ProductInfo.MftID = ManufactureInfo.MftID");
			// On all tables' rows
			foreach (DataRow dtRow in DataTable.Rows)
			{
				var ID = dtRow.Field<string>(0);
				var manufacture = dtRow.Field<string>(1);
				var name = dtRow.Field<string>(2);
				var price = (int)dtRow.Field<Decimal>(3);
				var description = dtRow.Field<string>(4);
				var picture = Utilities.GetImageFromByteArray(dtRow.Field<Byte[]>(5));
				AddProductPane(ID, picture, name, price, description);
			}
		}

		private void buttonCart_Click(object sender, EventArgs e)
		{
			ShoppingCart shoppingCart = new ShoppingCart(this);
			shoppingCart.Show();
		}

		private void userSetup()
		{
			switch (User.UserType)
			{
				case EUserType.User:
					productManage_button.Visible = false;
					buttonReceipt.Visible = false;
					break;
				case EUserType.Admin:
					buttonCart.Visible = false;
					break;
			}
		}

		private void labelUser_Click(object sender, EventArgs e)
		{

		}

		private void buttonReceipt_Click(object sender, EventArgs e)
		{
			ReceiptViewer receiptViewer = new ReceiptViewer();
			receiptViewer.Show();
		}
	}
}
