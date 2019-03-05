using System;
using System.Threading.Tasks;
using ExternScharpSDK.Classes;

namespace ExternScharpSDK
{
	public class ExternSDK
	{
		private WebApiClient client;

		public ExternSDK(string endpoint)
		{
			client = new WebApiClient(endpoint);
		}

		public void Authentications(string login, string password, string apiKey)
		{
			var t = client.GetTokens(login, password, apiKey);
		}
	}
}
