using iddd_db.Models;

namespace iddd_db.Entities
{
	public interface IUserEntity
	{
		string UserAccount { get; }

		UserInfo UserInfo { get; }

		bool UpdateUserInfo(UserInfo newInfo);
	}
}
