using iddd_db.Entities;
using iddd_db.Factory;
using iddd_db.Repository;

namespace iddd_db.Service
{
	public class AuthenticateService
	{
		private readonly IUserRepository _userRepository;

		public AuthenticateService(IUserRepository userRepository)
		{
			this._userRepository = userRepository;
		}

		public IUserEntity IsAuth(string account, string password)
		{
			var userInfo = this._userRepository.Authenticate(account, password);

			if (userInfo != null)
			{
				return EntityFactory.GetUserEntity(account, userInfo);
			}

			return null;
		}
	}
}
