using iddd_db.Interfaces;

namespace iddd_db.Service
{
    public static class AuthorizationService
    {
        //客戶權限可用項目
        private static readonly string[] CustomerAccess = new string[]{"View","Post","Bill"};

        //自由接案者權限可用項目
        private static readonly string[] FreelancerAccess = new string[] { "View", "TakeCase", "TimeSheet" };


        public static bool IsAuth(this IUser user , string action )
        {
            if (action == null)
            {
                throw new System.ArgumentNullException(nameof(action));
            }

            return false;
        }
    }
}
