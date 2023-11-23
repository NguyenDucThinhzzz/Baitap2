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
	public partial class SignUp : Form
	{
		public SignUp()
		{
			InitializeComponent();
		}

		private void buttonReset_Click(object sender, EventArgs e)
		{
			textBoxUsername.Text = string.Empty;
			textBoxPassword.Text = string.Empty;
			textBoxPassword2.Text = string.Empty;
			textBoxName.Text = string.Empty;
			textBoxPhone.Text = string.Empty;
			textBoxLocation.Text = string.Empty;
		}

		private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void buttonConfirm_Click(object sender, EventArgs e)
		{
			//if(textBoxUsername.Text == string.Empty||
			//textBoxPassword.Text == string.Empty||
			//textBoxPassword2.Text == string.Empty||
			//textBoxName.Text == string.Empty||
			//textBoxPhone.Text == string.Empty||
			//textBoxLocation.Text == string.Empty) 
			//{
			//	var error = MessageBox.Show("There is an empty field!!!");
			//	return;
			//}
			try
			{
				DataTable dt = ConnectData.ReadData("Select * from Account where Account.Username = '"+ textBoxUsername.Text +"'");
				if(dt.Rows[0].Field<string>("Username") == textBoxUsername.Text)
				{
					var error = MessageBox.Show("Username already exist!!!");
				}
				return;

			}
			catch { }
			if (textBoxPassword.Text != textBoxPassword2.Text)
			{
				var error = MessageBox.Show("Your re enter password is different!!");
				return;
			}
			if (textBoxPassword.Text.Length<6)
			{
				var error = MessageBox.Show("Your Password is too short");
				return;
			}
			ConnectData.ChangeData("Insert into Account(Username,Userpass) values ('" + textBoxUsername.Text + "','" + textBoxPassword.Text + "')");
			DataTable dataTable = ConnectData.ReadData("Select * from KhachHang");
			ConnectData.ChangeData("Insert into KhachHang(MaKH,Username,TenKH,DiaChi,DienThoai) values ('MKH" + dataTable.Rows.Count + "','" + textBoxUsername.Text + "','" + textBoxName.Text + "','" + textBoxLocation.Text + "','" + textBoxPhone.Text + "')");
			var info = MessageBox.Show("Account has been created!!!");
		}
	}
}
