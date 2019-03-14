using System.Threading.Tasks;
using Refit;

namespace ExternScharpSDK.Interface
{
	public interface IWebApiClient
	{
		[Get("/v1")]
		Task<string> GetTokens(string login, string password, string apiKey);
	}
}