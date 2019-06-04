using System;
using iddd_db.Models;

namespace iddd_db.Repository
{
	public class UserRepository : IUserRepository
	{
		public UserInfo Authenticate(string userAccount, string password)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Updates the user information.
		/// </summary>
		/// <param name="userAccount">The user account.</param>
		/// <param name="userInfo">The user information.</param>
		/// <returns>affected rows</returns>
		public int UpdateUserInfo(string userAccount, UserInfo userInfo)
		{
			return 1;
		}
	}
}
