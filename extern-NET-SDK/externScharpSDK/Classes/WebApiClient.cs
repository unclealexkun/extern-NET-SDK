using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using ExternScharpSDK.Interface;

namespace ExternScharpSDK.Classes
{
	public class WebApiClient : IWebApiClient
	{
		private string token { get; set; }
		private static Uri endpoint { get; set; }

		public static string Content { get; set; }

		public WebApiClient(string endpoint)
		{
			WebApiClient.endpoint = new Uri(endpoint);
		}

		public WebApiClient(Uri endpoint)
		{
			WebApiClient.endpoint = endpoint;
		}

		public async Task<string> GetTokens(string login, string password, string apiKey)
		{
			using (var client = new HttpClient())
			{
				client.DefaultRequestHeaders.Add("X-Kontur-Apikey", apiKey);
				var response = await client.PostAsync(new Uri(endpoint, "/auth/v5.12/authenticate-by-pass?login="+login),
					new StringContent(password));
				response.EnsureSuccessStatusCode();
				var obj = await response.Content.ReadAsStringAsync();
				return obj;
			}
		}
	}
}
