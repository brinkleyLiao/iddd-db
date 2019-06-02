using iddd_db.Interfaces;

namespace iddd_db.Models
{

    public class Freelancer : IFreelancer, IUser
    {
        public Freelancer()
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

        string IUser.GetIdentity()
        {
            throw new System.NotImplementedException();
        }

        bool IUser.IsAccess()
        {
            throw new System.NotImplementedException();
        }

        string IUser.Name { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        string IUser.Password { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        string IUser.Email { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        string IUser.Fax { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        string IUser.Mobile { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}
