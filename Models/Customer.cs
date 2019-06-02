using iddd_db.Interfaces;

namespace iddd_db.Models
{
    public class Customer : ICustomer, IUser
    {
        public Customer()
        {
        }

        //取得身分
        public string GetIdentity()
        {
            return "";
        }

        //是否有訪問權限
        public bool IsAccess()
        {

            return true;
        }

        public string Name { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string Email { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string Fax { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string Mobile { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        Project ICustomer.AddNewProject(string name, string content, decimal price)
        {
            throw new System.NotImplementedException();
        }

        Project ICustomer.EditProject(string projectId, string name, string content, decimal price)
        {
            throw new System.NotImplementedException();
        }

        Project ICustomer.CloseProject(string projectId)
        {
            throw new System.NotImplementedException();
        }

        bool ICustomer.Billing(string projectId)
        {
            throw new System.NotImplementedException();
        }
    }
}
