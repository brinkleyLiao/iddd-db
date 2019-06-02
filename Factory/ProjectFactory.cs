using iddd_db.Interfaces;
using iddd_db.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace iddd_db.Factory
{
    public class ProjectFactory : IProjectFactory
    {
        Project IProjectFactory.AddNewProject(IUser user, string name, string content, decimal price)
        {
            if (string.IsNullOrWhiteSpace(name))
            {

            }


           var proejct =  (user as ICustomer).AddNewProject(name, content, price);
           return proejct;
        }

        Project IProjectFactory.EditProject(string projectId, IUser user, string name, string content, decimal price)
        {
            throw new NotImplementedException();
        }

        Project IProjectFactory.CloseProject(string projectId, IUser user)
        {
            throw new NotImplementedException();
        }

        bool IProjectFactory.Billing(string projectId, IUser user)
        {
            throw new NotImplementedException();
        }

        Project IProjectFactory.TakeProjectCase(string projectId, IUser user)
        {
            throw new NotImplementedException();
        }

        Project IProjectFactory.SetTimeSheet(string projectId, IUser user)
        {
            throw new NotImplementedException();
        }

        ICustomer IProjectFactory.GetCustomer(string projectId, IUser user)
        {
            throw new NotImplementedException();
        }

        IFreelancer IProjectFactory.GetContactFreelancer(string projectId, IUser user)
        {
            throw new NotImplementedException();
        }
    }
}
