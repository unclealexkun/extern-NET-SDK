using System;
using RestSharp;

namespace Core
{
	public class ApiConnection
	{
		public Uri EndPoint { private get; set; }
		public string ApiKey { private get; set; }

		private RestClient restClient;

		public ApiConnection(string endPoint, string apiKey)
		{
			EndPoint = new Uri(endPoint);
			ApiKey = apiKey;
		}
		public ApiConnection(Uri endPoint, string apiKey)
		{
			EndPoint = endPoint;
			ApiKey = apiKey;

			restClient = new RestClient(endPoint);
		}

		public void Authenticate()
		{

		}
	}
}
