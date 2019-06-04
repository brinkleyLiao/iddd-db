using iddd_db.Entities;
using iddd_db.Models;
using iddd_db.Repository;

namespace iddd_db.Factory
{
	public class EntityFactory
	{
		public static IUserEntity GetUserEntity(string account, UserInfo userInfo)
		{
			return new UserEntity(account, userInfo, new UserRepository());
		}
	}
}
