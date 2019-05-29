namespace iddd_db.Interfaces
{
    //會員Interface
    public interface IUser
    {
         //取得身分
         string GetIdentity();

        //是否有訪問權限
        bool IsAccess();
    }
}
