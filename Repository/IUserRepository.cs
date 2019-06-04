using iddd_db.Models;

namespace iddd_db.Repository
{
	public interface IUserRepository
	{
		UserInfo Authenticate(string userAccount, string password);

		/// <summary>
		/// Updates the user information.
		/// </summary>
		/// <param name="userAccount">The user account.</param>
		/// <param name="userInfo">The user information.</param>
		/// <returns>affected rows</returns>
		int UpdateUserInfo(string userAccount, UserInfo userInfo);
	}
}
