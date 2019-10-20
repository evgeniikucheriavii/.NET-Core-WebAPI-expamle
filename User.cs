using System;

namespace Api
{
	class User
	{
		private string key;
		private string login;
		private string password;

		public User(string login, string password, List<User> users)
		{
			if(CheckLogin(login, users))
			{
				this.login = login;
				this.password = password;
				this.key = GenerateKey(users);
			}
		}

		private bool CheckLogin(string login, List<User> users)
		{
			result = true;

			foreach(User user in users)
			{
				if(user.login == login)
				{
					result = false;
					break;
				}
			}

			return result;
		}

		private string GenerateKey(List<User> users)
		{
			Random rand = new Random();

			int key = rand.Next(100, 10000);

			string xKey = key.ToString(16);

			bool free = true;

			foreach(User user in users)
			{
				if(user.Key == xKey)
				{
					free = false;
					break;
				}
			}

			if(!free)
			{
				xKey = GenerateKey(users);
			}

			return xkey;
		}


		public string Key 
		{ 
			get
			{
				return this.key;
			}
		}

		public string Login
		{ 
			get
			{
				return this.login;
			}
		}

		public string Password
		{ 
			get
			{
				return this.password;
			}
		}
	}
}