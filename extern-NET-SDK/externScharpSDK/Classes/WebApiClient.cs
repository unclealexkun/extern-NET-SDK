using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text;
using ExternScharpSDK.Interface;

namespace ExternScharpSDK.Classes
{
	public class WebApiClient : IWebApiClient
	{
		private static Uri endpoint { get; set; }

		public WebApiClient(string endpoint)
		{
			WebApiClient.endpoint = new Uri(endpoint);
		}

		public WebApiClient(Uri endpoint)
		{
			WebApiClient.endpoint = endpoint;
		}

		static async Task ProcessAuthentications()
		{
			var apiUrl = new Uri(endpoint, string.Format("/auth/v5.9/authenticate-by-cert?free={0}&apiKey={1}", true, ""));
			using (var client = new HttpClient())
			{
				var response = await client.PostAsync(apiUrl, new StringContent("", Encoding.UTF8));
			}
		}
	}
}
