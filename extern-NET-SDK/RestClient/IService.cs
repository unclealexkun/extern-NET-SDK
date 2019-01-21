namespace RestClient
{
	public interface IService
	{
		void Send(string request);
		string Answer();
	}
}