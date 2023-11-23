using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap2
{
	public static class Utilities
	{
		public static Image GetImageFromByteArray(byte[] bytes)
		{
			MemoryStream str = new MemoryStream(bytes);
			return Image.FromStream(str);
		}

		public static byte[] GetByteArrayFromImage(Image img)
		{
			using (var ms = new MemoryStream())
			{
				img.Save(ms, img.RawFormat);
				return ms.ToArray();
			}
		}
	}
}
