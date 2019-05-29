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

  }
}
