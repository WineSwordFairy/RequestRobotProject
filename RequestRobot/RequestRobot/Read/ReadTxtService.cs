using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRobot.Read
{
	public class ReadTxtService
	{
		public static List<string> Do()
		{
			System.IO.StreamReader sr = System.IO.File.OpenText(@"E:/Project/Name.txt");
			//string[] xx = sr.ReadToEnd().Split(new string[] { "\r\n" }, StringSplitOptions.None);//StringSplitOptions.None 分割后返回原值。sr.ReadToEnd()后再次sr.ReadToEnd()内容将为空。
			List<string> data = sr.ReadToEnd().Split(' ').ToList();//StringSplitOptions.RemoveEmptyEntries 分割后内容为空则不返回。.EndsWith("strat")取以“strat”结尾的结果
			sr.Close();
			return data;
		}
	}
}
