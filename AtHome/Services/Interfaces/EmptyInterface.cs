using System;
namespace AtHome.Services.Interfaces
{
	public interface IAccountService
	{
		string Login(string username, string password);
	}
}

