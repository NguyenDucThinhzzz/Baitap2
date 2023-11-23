using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap2
{
	public class ProductCartPane
	{
		private ShoppingCart shoppingCart;
		public string ID { get; private set; }
		public Panel ProductPanel { get; private set; }
		public PictureBox ProductPicture { get; private set; }
		public Label ProductName { get; private set; }
		public Label ProductPrice { get; private set; }
		public Label ProductAmount { get; private set; }
		public Button DeleteButton { get; private set; }

		public ProductCartPane(ShoppingCart shoppingCart, string id, Image image, string name, int price, int amount)
		{
			this.shoppingCart = shoppingCart;
			ID = id;
			ProductPanel = new Panel();
			ProductPicture = new PictureBox();
			ProductPicture.Image = image;
			ProductName = new Label();
			ProductName.Text = name;
			ProductPrice = new Label();
			ProductPrice.Text = price.ToString();
			ProductAmount = new Label();
			ProductAmount.Text = amount.ToString();
			DeleteButton = new Button();
		}
		public void SetupProductPanel(FlowLayoutPanel parent, Panel panel, PictureBox picture, Label name, Label price, Label amount, Button delete)
		{
			//Panel
			ProductPanel.Parent = parent;
			ProductPanel.AutoSize = false;
			ProductPanel.BackColor = Color.LightGray;
			ProductPanel.Size = panel.Size;
			ProductPanel.Margin = panel.Margin;

			//Product Picture
			ProductPicture.Size = picture.Size;
			ProductPicture.SizeMode = PictureBoxSizeMode.Zoom;
			ProductPicture.BackColor = Color.White;
			ProductPicture.Parent = ProductPanel;
			ProductPicture.Cursor = Cursors.Hand;
			ProductPicture.MouseClick += new MouseEventHandler(this.showProductInfoPage);

			//Name Lable
			ProductName.Font = name.Font;
			ProductName.AutoSize = true;
			ProductName.Location = name.Location;
			ProductName.BackColor = Color.Transparent;
			ProductName.Parent = ProductPanel;
			ProductName.Cursor = Cursors.Hand;
			ProductName.MouseClick += new MouseEventHandler(this.showProductInfoPage);

			//Price Lable
			ProductPrice.Font = price.Font;
			ProductPrice.AutoSize = true;
			ProductPrice.Location = price.Location;
			ProductPrice.BackColor = Color.Transparent;
			ProductPrice.Parent = ProductPanel;

			//Amount Lable
			ProductAmount.Font = amount.Font;
			ProductAmount.AutoSize = true;
			ProductAmount.Location = amount.Location;
			ProductAmount.BackColor = Color.Transparent;
			ProductAmount.Parent = ProductPanel;

			//Delete Button
			DeleteButton.Text = delete.Text;
			DeleteButton.Location = delete.Location;
			DeleteButton.Parent = ProductPanel;
			DeleteButton.Size = delete.Size;
			DeleteButton.Click += new EventHandler(this.DestroyPane);

			ProductPanel.Show();
			ProductPicture.Show();
			ProductName.Show();
			ProductPrice.Show();
			ProductAmount.Show();
			DeleteButton.Show();
		}
		public void Destroy()
		{
			ProductPanel.Hide();
			ProductPicture.Hide();
			ProductName.Hide();
			ProductPrice.Hide();

			ProductPanel = null;
			ProductPicture = null;
			ProductName = null;
			ProductPrice = null;
		}

		private void showProductInfoPage(object sender, EventArgs e)
		{
			DataTable dataTable = ConnectData.ReadData("Select * from ProductInfo inner join ManufactureInfo on ProductInfo.MftID = ManufactureInfo.MftID");
			// On all tables' rows
			foreach (DataRow dtRow in dataTable.Rows)
			{
				var ID = dtRow.Field<string>(0);
				if (ID != this.ID)
					continue;
				var manufacture = dtRow.Field<string>(7);
				var name = dtRow.Field<string>(2);
				var price = (int)dtRow.Field<Decimal>(3);
				var description = dtRow.Field<string>(4);
				var picture = Utilities.GetImageFromByteArray(dtRow.Field<Byte[]>(5));
				ProductInfo panel = new ProductInfo(shoppingCart.mainMenu,ID,manufacture, picture, name, price, description.Split('$'));
				panel.Show();
				return;
			}
		}
		private void DestroyPane(object sender, EventArgs e)
		{
			Destroy();
			shoppingCart.mainMenu.ShoppingCartData.RemoveItem(this.ID);
			shoppingCart.CalculateTotal();
		}
	}
}
