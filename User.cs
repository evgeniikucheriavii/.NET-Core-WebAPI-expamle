using System;

namespace Api
{
	class User
	{
		private string key;
		private string login;
		private string password;

		public User(string login, string password)
		{
			
		}

		public string Key 
		{ 
			get
			{
				return this.key;
			}
		}


		private string GenerateKey(List<User> users)
		{
			string key = "";

			return key;
		}
	}
}