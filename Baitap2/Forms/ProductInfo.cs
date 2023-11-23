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
	public partial class ProductInfo : Form
	{
		private MainMenu menu;
		private string id;
		public ProductInfo(MainMenu mainMenu, string id,string manufacture, Image image, string name, int price, string[] description)
		{
			InitializeComponent();
			this.menu = mainMenu;
			this.id = id;
			labelManufacture.Text = manufacture;
			labelPrice.Text = price + "$";
			labelProductName.Text = name;
			pictureBoxImage.Image = image;
			createSpecPanel(description);
			panelSpecDefault.Visible = false;
			
			if(menu.User.UserType == Scripts.Login.EUserType.Admin)
			{
				buttonAddToCart.Enabled = false;
			}
		}

		private void buttonAddToCart_Click(object sender, EventArgs e)
		{
			menu.ShoppingCartData.AddItem(id,int.Parse(textBoxAmount.Text));
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void labelSpecDefault_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
		private void createSpecPanel(string[] strings)
		{
			foreach (string s in strings)
			{
				if (s == string.Empty) continue;
				Panel panel = new Panel();
				panel.Parent = flowLayoutPanelSpec;
				panel.Size = panelSpecDefault.Size;
				panel.BorderStyle = BorderStyle.FixedSingle;

				Label label = new Label();
				label.AutoSize = true;
				label.Text = s;
				label.Font = labelSpecDefault.Font;
				label.Parent = panel;
				label.Location = labelSpecDefault.Location;
			}
		}

		private void buttonIncrease_Click(object sender, EventArgs e)
		{
			int value = int.Parse(textBoxAmount.Text);
			if(value < 99)
			{
				value++;
				textBoxAmount.Text = value.ToString();
			}
		}

		private void buttonDecrease_Click(object sender, EventArgs e)
		{
			int value = int.Parse(textBoxAmount.Text);
			if (value > 0)
			{
				value--;
				textBoxAmount.Text = value.ToString();
			}
		}
	}
}
