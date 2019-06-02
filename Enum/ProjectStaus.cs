using System;
using System.Collections.Generic;
using System.Text;

namespace iddd_db.Enum
{
    public enum ProjectStaus
    {
        /// <summary>
        /// 新建立
        /// </summary>
        None =  0,

        /// <summary>
        /// 已接案
        /// </summary>
        Taked = 1 ,

        /// <summary>
        /// 已完成待付款
        /// </summary>
        WaitPrice = 2,


        /// <summary>
        /// 結案
        /// </summary>
        Finished = 3,

        /// <summary>
        /// 關閉 ， 發起人可以直接關閉
        /// </summary>
        Close = 4,


    }
}
