using System;
using System.Threading.Tasks;
using ExternScharpSDK.Classes;

namespace ExternScharpSDK
{
	public class ExternSDK
	{
		private string endpoint;

		public ExternSDK(string endpoint)
		{
			this.endpoint = endpoint;
		}

		public void Authentications(string login, string password, string apiKey)
		{
			var client = new WebApiClient(endpoint);
		}

		public async Task<string> Test()
		{
			var client = new WebApiClient(endpoint);
			await WebApiClient.GetMySelf();
			return WebApiClient.Content;
		}
	}
}
