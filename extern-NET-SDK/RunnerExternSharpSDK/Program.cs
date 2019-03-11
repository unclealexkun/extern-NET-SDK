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
			var login = args[0];
			var password = args[1];
			var apiKey = args[2];

			var sdk = new ExternSDK("https://extern-api.testkontur.ru/");
			var token = sdk.Authenticate(login, password, apiKey);
			Console.WriteLine("token = "+token);
		}
	}
}
