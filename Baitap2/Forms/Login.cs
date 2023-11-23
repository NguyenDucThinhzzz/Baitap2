using Baitap2.Scripts.Login;
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
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();

			User admin = new User("thinh","123",EUserType.Admin);
			User user = new User("hieu", "456");
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			string usernameInput = textBoxUsername.Text;
			string passwordInput = textBoxPassword.Text;
			string username, password;
			DataTable user;
			try
			{
				user = ConnectData.ReadData("Select * from Account where Account.Username = '" + usernameInput +"'");
				username = user.Rows[0].Field<string>("Username");
				password = user.Rows[0].Field<string>("Userpass");
			}
			catch
			{
				var error = MessageBox.Show("Either your username or password is wrong!!!");
				return;
			}
			if (password != passwordInput)
			{
				var error = MessageBox.Show("Either your username or password is wrong!!!");
				return;
			}
			this.Hide();
			User user1;
			if (username == "admin")
			{
				 user1= new User(username,password,EUserType.Admin);
			}
			else
			{
				user1 = new User(username, password);
			}

			MainMenu menu = new MainMenu(user1);
			menu.FormClosed += (s, args) => this.Close();
			menu.Show();
		}

		private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(char.IsWhiteSpace(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void textBoxUsername_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsWhiteSpace(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void buttonSignUp_Click(object sender, EventArgs e)
		{
			SignUp signUp = new SignUp();
			signUp.Show();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
