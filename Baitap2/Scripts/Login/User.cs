using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap2.Scripts.Login
{
	public enum EUserType
	{
		Admin,
		User
	}
	public class User
	{
		public string Name { get; private set; }
		public string Password { get; private set; }
		public EUserType UserType { get; private set; }
		public User() { }
		public User(string name, string password, EUserType userType = EUserType.User)
		{
			Name = name;
			Password = password;
			UserType = userType;
		}
	}
}
