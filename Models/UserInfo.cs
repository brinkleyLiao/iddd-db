using iddd_db.Enum;

namespace iddd_db.Models
{
	public class UserInfo
	{
		public UserInfo(UserRole userRole, string userName, string address, string bankAccount,
			CommunicationChannels communicationChannels)
		{
			this.UserRole = userRole;
			this.UserName = userName;
			this.Address = address;
			this.BankAccount = bankAccount;
			this.CommunicationChannel = communicationChannels;
		}

		public UserRole UserRole { get; private set; }

		public string UserName { get; private set; }

		public string Address { get; private set; }

		public string BankAccount { get; private set; }

		public CommunicationChannels CommunicationChannel { get; private set; }
	}
}
