using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RequestRobot.Service;

namespace RequestRobot
{
	class Program
	{
		static void Main(string[] args)
		{
			Register re = new Register();
			re.DoRegister();

		}
	}
}
