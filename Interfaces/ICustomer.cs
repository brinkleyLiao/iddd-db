using iddd_db.Models;

namespace iddd_db.Interfaces
{
    ///
    /// 客戶介面
    ///
    public interface ICustomer
    {
        /// <summary>
        /// 新增案子
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="name"></param>
        /// <param name="content"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        Project AddNewProject(string name, string content, decimal price);

        /// <summary>
        /// 編輯案子
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="customer"></param>
        /// <param name="name"></param>
        /// <param name="content"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        Project EditProject(string projectId,  string name, string content, decimal price);

        /// <summary>
        /// 關閉案子
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="customer"></param>
        /// <returns></returns>
        Project CloseProject(string projectId);

        /// <summary>
        /// 付款
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="customer"></param>
        /// <returns></returns>
        bool Billing(string projectId);
    }
}
