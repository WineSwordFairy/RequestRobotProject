using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RequestRobot.Request;

namespace RequestRobot.Model
{
	public class AccountInfo
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }


		public void BuyProduct()
		{
			string resultStr = request.DoRequest(string.Format("http://localhost:8087/BuyProduct?accountId={0}&productId={1}&count={2}&createDate={3}", this.Id,1,1, DateTime.Now.AddDays(new Random().Next(-1100, -1)).ToString("yyyy-MM-dd")), "");
			Console.WriteLine(resultStr);
		}
	}
}
