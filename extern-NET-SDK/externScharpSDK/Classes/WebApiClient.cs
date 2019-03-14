using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using ExternScharpSDK.Interface;
using Refit;

namespace ExternScharpSDK.Classes
{
	public class WebApiClient : IWebApiClient
	{
		private string token { get; set; }
		private static IWebApiClient client { get; set; }

		public static string Content { get; set; }

		public WebApiClient(string endpoint)
		{
			client = RestService.For<IWebApiClient>(endpoint);
		}

		public async Task<string> GetTokens(string login, string password, string apiKey)
		{
			return await client.GetTokens(login, password, apiKey);
		}
	}
}
