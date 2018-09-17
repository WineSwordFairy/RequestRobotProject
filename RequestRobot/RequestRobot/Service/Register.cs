using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RequestRobot.Request;

namespace RequestRobot.Service
{
	public class Register
	{
		public void DoRegister()
		{

			//List<Thread> threadList = new List<Thread>();
			for (int i = 0; i < 100; i++)
			{
				Thread thread = new Thread(this.RDoRegister);
				//threadList.Add(thread);
				thread.Start();
			}
			//Console.WriteLine("开始跑");
			//for (int i = 0; i < 100; i++)
			//{
			//	threadList[i].Start();
			//}
		}

		public void RDoRegister()
		{
			while (true)
			{
				string resultStr = request.DoRequest("http://localhost:8086/Register", "");
				Console.WriteLine(resultStr);
			}
		}
	}
}
