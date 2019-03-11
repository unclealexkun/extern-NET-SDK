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

		public async Task Authentications(string login, string password, string apiKey)
		{
			var t = await client.GetTokens(login, password, apiKey);
		}
	}
}
