using iddd_db.Models;
using iddd_db.Repository;

namespace iddd_db.Entities
{
	public class UserEntity : IUserEntity
	{
		private readonly IUserRepository _userRepository;

		public UserEntity(string userAccount, UserInfo userInfo, IUserRepository userRepository)
		{
			this.UserAccount = userAccount;
			this.UserInfo = userInfo;
			this._userRepository = userRepository;
		}

		public string UserAccount { get; private set; }

		public UserInfo UserInfo { get; private set; }

		public bool UpdateUserInfo(UserInfo newInfo)
		{
			var affectedRow = this._userRepository.UpdateUserInfo(this.UserAccount, newInfo);

			if (affectedRow == 1)
			{
				this.UserInfo = newInfo;

				return true;
			}

			return false;
		}
	}
}
