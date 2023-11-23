using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap2
{
	public class ShoppingCartData
	{
		public Dictionary<string, int> Items { get; private set; }
		public ShoppingCartData()
		{
			Items = new Dictionary<string, int>();
		}
		public void AddItem(string id, int amount)
		{
			if (!Items.ContainsKey(id))
			{
				Items.Add(id, amount);
				return;
			}
			Items[id] += amount;
		}
		public void RemoveItem(string id)
		{
			if (!Items.ContainsKey(id))
			{
				return;
			}
			Items.Remove(id);
		}
	}
}
