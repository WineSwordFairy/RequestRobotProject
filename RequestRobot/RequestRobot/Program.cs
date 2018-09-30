using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RequestRobot.Service;
using RequestRobot.Read;
using RequestRobot.Database;
using RequestRobot.Model;

namespace RequestRobot
{
	class Program
	{

		private static List<AccountInfo> accountList = (List<AccountInfo>)DataService.GetData();

		static void Main(string[] args)
		{
			#region 购买商品。
			for (int i = 0; i < 100; i++)
			{
				Thread thread = new Thread(DoBuyProduct);
				thread.Start();
			}
			#endregion

		}
		public static void DoBuyProduct()
		{
			while (true)
			{
				accountList[new Random().Next(1, 690000)].BuyProduct();
			}
		}
	}
}
