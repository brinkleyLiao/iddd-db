namespace iddd_db.Interfaces
{

    /// <summary>
    ///  會員Interface
    /// </summary>
    public interface IUser
    {
        /// <summary>
        /// 取得身分
        /// </summary>
        /// <returns></returns>
        string GetIdentity();

        /// <summary>
        /// 是否有訪問權限
        /// </summary>
        /// <returns></returns>
        bool IsAccess();

        /// <summary>
        /// 名字
        /// </summary>
        string Name{get;set;}

        /// <summary>
        /// 密碼
        /// </summary>
        string Password { get; set; }

        /// <summary>
        /// 聯絡電子郵件
        /// </summary>
        string Email{get;set;}

        /// <summary>
        /// 聯絡傳真
        /// </summary>
        string Fax{get;set;}

        /// <summary>
        /// 連絡電話
        /// </summary>
        string  Mobile {get;set;}
    }
}
