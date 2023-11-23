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
	public class ProductPane
	{
		private MainMenu mainMenu;
		public string ID { get; private set; }
		public Panel ProductPanel { get; private set; }
		public PictureBox ProductPicture { get; private set; }
		public Label ProductName { get; private set; }
		public Label ProductPrice { get; private set; }
		public TextBox ProductDescription { get; private set; }

		public ProductPane(MainMenu mainMenu,string id, Image image, string name, int price, string description)
		{
			this.mainMenu = mainMenu;
			ID = id;
			ProductPanel = new Panel();
			ProductPicture = new PictureBox();
			ProductPicture.Image = image;
			ProductName = new Label();
			ProductName.Text = name;
			ProductPrice = new Label();
			ProductPrice.Text = price + "$";
			ProductDescription = new TextBox();
			ProductDescription.Lines = description.Split('$');
		}
		public void SetupProductPanel(FlowLayoutPanel parent, Panel panel, PictureBox picture, Label name, Label price, TextBox description)
		{
			//Panel
			ProductPanel.Parent = parent;
			ProductPanel.AutoSize = false;
			ProductPanel.BackColor = Color.LightGray;
			ProductPanel.Size = panel.Size;
			ProductPanel.Margin = panel.Margin;
			ProductPanel.Cursor = Cursors.Hand;
			ProductPanel.MouseClick += new MouseEventHandler(this.showProductInfoPage);

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
			ProductPrice.Cursor = Cursors.Hand;
			ProductPrice.MouseClick += new MouseEventHandler(this.showProductInfoPage);

			//Description
			ProductDescription.BackColor = Color.White;
			ProductDescription.BorderStyle = BorderStyle.None;
			ProductDescription.BackColor = Color.LightGray;
			ProductDescription.Font = description.Font;
			ProductDescription.AutoSize = false;
			ProductDescription.Location = description.Location;
			ProductDescription.Size = description.Size;
			ProductDescription.ReadOnly = true;
			ProductDescription.WordWrap = true;
			ProductDescription.Multiline = true;
			ProductDescription.Parent = ProductPanel;
			ProductDescription.Cursor = Cursors.Hand;
			ProductDescription.MouseClick += new MouseEventHandler(this.showProductInfoPage);

			ProductPanel.Show();
			ProductPicture.Show();
			ProductName.Show();
			ProductPrice.Show();
			ProductDescription.Show();
		}
		public void Destroy()
		{
			ProductPanel.Hide();
			ProductPicture.Hide();
			ProductName.Hide();
			ProductPrice.Hide();
			ProductDescription.Hide();

			ProductPanel = null;
			ProductPicture = null;
			ProductName = null;
			ProductPrice = null;
			ProductDescription = null;
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
				ProductInfo panel = new ProductInfo(mainMenu, ID ,manufacture, picture, name, price, description.Split('$'));
				panel.Show();
				return;
			}
		}
	}
}
