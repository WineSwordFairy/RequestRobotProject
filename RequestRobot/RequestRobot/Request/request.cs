using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRobot.Request
{
	public class request
	{
		public static string DoRequest(string url, string sendData)
		{
			string backMsg = "";
			try
			{
				System.Net.WebRequest httpRquest = System.Net.HttpWebRequest.Create(url);
				httpRquest.Method = "GET";
				//这行代码很关键，不设置ContentType将导致后台参数获取不到值  
				httpRquest.ContentType = "application/x-www-form-urlencoded;charset=UTF-8";
				byte[] dataArray = System.Text.Encoding.UTF8.GetBytes(sendData);
				//httpRquest.ContentLength = dataArray.Length;  
				//System.IO.Stream requestStream = null;
				//if (string.IsNullOrWhiteSpace(sendData) == false)
				//{
				//	requestStream = httpRquest.GetRequestStream();
				//	requestStream.Write(dataArray, 0, dataArray.Length);
				//	requestStream.Close();
				//}
				System.Net.WebResponse response = httpRquest.GetResponse();
				System.IO.Stream responseStream = response.GetResponseStream();
				System.IO.StreamReader reader = new System.IO.StreamReader(responseStream, System.Text.Encoding.UTF8);
				backMsg = reader.ReadToEnd();
				reader.Close();
				reader.Dispose();
			}
			catch (Exception ex)
			{
				return "";
			}
			return backMsg;
		}



	}
}
