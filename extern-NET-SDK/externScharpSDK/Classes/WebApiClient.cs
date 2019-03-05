﻿using System;
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

		public async Task<object> GetTokens (string login, string password, string apiKey)
		{
			using (var client = new HttpClient())
			{
				var response = await client.GetAsync(new Uri(endpoint, "Test"));
				response.EnsureSuccessStatusCode();
				var obj = await response.Content.ReadAsAsync<object>();
				return obj;
			}
		}
	}
}