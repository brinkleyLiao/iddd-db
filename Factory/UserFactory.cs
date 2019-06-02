using System;
using System.Collections.Generic;
using System.Text;
using iddd_db.Interfaces;

namespace iddd_db.Factory
{
    public class UserFactory : IUserFactory
    {
        IUser IUserFactory.Register(string name, string password)
        {
            throw new NotImplementedException();
        }

        void IUserFactory.ChangePassword(string password)
        {
            throw new NotImplementedException();
        }

        void IUserFactory.ChangeContactInformation(string email, string fax, string mobile)
        {
            throw new NotImplementedException();
        }
    }
}
