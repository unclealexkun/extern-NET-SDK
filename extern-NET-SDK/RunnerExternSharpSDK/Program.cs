using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExternScharpSDK;

namespace RunnerExternSharpSDK
{
	class Program
	{
		static void Main(string[] args)
		{
			var login = String.Empty;
			var password = String.Empty;
			var apiKey = String.Empty;

			var sdk = new ExternSDK("https://api.testkontur.ru", login, password, apiKey);
			Console.WriteLine();
		}
	}
}
