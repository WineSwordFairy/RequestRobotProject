using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RequestRobot.Read;
using RequestRobot.Request;

namespace RequestRobot.Service
{
	public class Register
	{
		public void DoRegister()
		{

			///名字。
			List<string> data = ReadTxtService.Do();
			///密码。
			String password = "123456";

			List<string> emails = new List<string>();
			///邮箱。
			for (int i = 0; i < 5000; i++)
			{
				emails.Add(new Random().Next(10000, 999999).ToString() + @"@qq.com");
			}
			for (int i = 0; i < data.Count; i++)
			{
				string resultStr = request.DoRequest(string.Format("http://localhost:8086/Register?userName={0}&password={1}&name={2}&email={3}&remark={4}", data[i].ToString(),password, data[i].ToString(), emails[i],"备注"), "");
			}


			//while (true)
			//{
			//	string resultStr = request.DoRequest("http://localhost:8086/Register", "");
			//	Console.WriteLine(resultStr);
			//}


			//for (int i = 0; i < 100; i++)
			//{
			//	Thread thread = new Thread(this.RDoRegister);
			//	thread.Start();
			//}
		}

		public void RDoRegister()
		{


		}
	}
}
