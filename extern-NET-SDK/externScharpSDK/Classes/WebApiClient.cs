using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using ExternScharpSDK.Interface;

namespace ExternScharpSDK.Classes
{
	public class WebApiClient : IWebApiClient
	{
		private string SId { get; set; }
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

		public static async Task ProcessAuthentications(bool checkValidationCert, string apiKey)
		{
			var apiUrl = new Uri(endpoint, string.Format("/auth/v5.9/authenticate-by-cert?free={0}&apiKey={1}", checkValidationCert, apiKey));
			using (var client = new HttpClient())
			{
				//client.DefaultRequestHeaders.Accept.Clear();
				//client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
				client.DefaultRequestHeaders.Add("User-Agent", ".NET Extern SDK");
				var response = await client.PostAsync(apiUrl, new StringContent("", Encoding.UTF8));
			}
		}

		public static async Task GetMySelf()
		{
			var resource = new Uri(endpoint, String.Empty);
			using (var client = new HttpClient())
			{
				client.DefaultRequestHeaders.Add("User-Agent", ".NET Extern SDK");
				var response = await client.GetAsync(resource);
				Content = response.Content.ReadAsStringAsync().Result;
			}
		}
	}
}
