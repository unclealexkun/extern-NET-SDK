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
			var login = "";
			var password = "";
			var apiKey = "";

			var sdk = new ExternSDK("https://extern-api.testkontur.ru/");
			var t = sdk.Authentications(login, password, apiKey);
			Console.WriteLine();
		}
	}
}
