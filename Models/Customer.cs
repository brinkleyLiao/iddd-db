using iddd_db.Interfaces;

namespace iddd_db.Models
{
  public class Customer : ICustomer, IUser
  {
    public Customer()
    {
    }

    //取得身分
    public string GetIdentity(){
        return "";
    }

    //是否有訪問權限
   public bool IsAccess(){

       return true;
   }
  }
}
