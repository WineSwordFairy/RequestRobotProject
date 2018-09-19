using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using RequestRobot.Model;

namespace RequestRobot.Database
{
	public class DataService
	{
		public static Object GetData()
		{


			MySqlConnectionStringBuilder s = new MySqlConnectionStringBuilder();
			s.Server = "localhost";
			s.Port = 3306; //mysql端口号
			s.Database = "jjxdb";
			s.UserID = "root";
			s.Password = "123456";
			s.CharacterSet = "latin1";
			s.SslMode = MySqlSslMode.None;

			List<AccountInfo> data = new List<AccountInfo>();

			using (MySqlConnection mcon = new MySqlConnection(s.ConnectionString))
			{
				string sql = "select * from AccountTable ";
				mcon.Open();
				using (MySqlCommand cmd = new MySqlCommand(sql, mcon))
				{
					using (MySqlDataReader dataReader = cmd.ExecuteReader())
					{
						while (dataReader.Read())
						{
							//string obj = (string)dataReader[1];
							//Console.WriteLine(obj);
							AccountInfo info = new AccountInfo()
							{
								Id = (int)dataReader[0],
								UserName = (string)dataReader[1],
								Password = (string)dataReader[2],
								Name = (string)dataReader[3],
								Email = (string)dataReader[4]
							};
							data.Add(info);
						}
					}
				}
			}
			return data;
		}
	}
}
