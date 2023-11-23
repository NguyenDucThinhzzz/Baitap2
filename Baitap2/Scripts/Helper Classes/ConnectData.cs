using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap2
{
	public static class ConnectData
	{
		//Chuoi ket noi
		static string strConnect = "Data Source=DESKTOP-SC31FVH\\MSSQLSERVER01;Initial Catalog=LaptopStore;Integrated Security=True";
		static SqlConnection sqlConn = null;
		//Open Connection
		public static void OpenConnect()
		{
			sqlConn = new SqlConnection(strConnect);
			if(sqlConn.State != System.Data.ConnectionState.Open)
			{
				sqlConn.Open(); 
			}
		}
		//Close Connection
		public static void CloseConnect()
		{
			if(sqlConn.State != ConnectionState.Closed)
			{
				sqlConn.Close();
				sqlConn.Dispose();
			}
		}
		//Read data
		public static DataTable ReadData(string sql)
		{
			DataTable dt = new DataTable();
			OpenConnect();
			SqlDataAdapter sqlData = new SqlDataAdapter(sql, sqlConn);
			sqlData.Fill(dt);
			return dt;
		}
		//Data Manipulation
		public static void UpdateData(string sql)
		{
			OpenConnect();
			SqlCommand sqlCommand = new SqlCommand();
			sqlCommand.Connection = sqlConn;

		}

		public static void ChangeData(string sql)
		{
			OpenConnect();
			SqlCommand sqlCommand = new SqlCommand();
			sqlCommand.Connection = sqlConn;
			sqlCommand.CommandText = sql;
			sqlCommand.ExecuteNonQuery();
			CloseConnect();
		}

	}
}
