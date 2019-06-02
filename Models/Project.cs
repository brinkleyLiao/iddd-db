using iddd_db.Enum;
using System;

namespace iddd_db.Models
{
    public class Project
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="project_name"></param>
        /// <param name="timeSheets"></param>
        /// <param name="customer"></param>
        public Project(string project_name , string content , decimal price , Customer customer)
        {
            this.Name = project_name;

            this.Content = content;

            this.Price = price;

            this.Customer = customer;

        }

        /// <summary>
        /// 專案名稱
        /// </summary>
        public string Name { get; private set; }


        /// <summary>
        /// 專案內容
        /// </summary>
        public string Content { get; private set; }


        /// <summary>
        /// 價格
        /// </summary>
        public decimal Price { get; private set; }


        /// <summary>
        /// 發包者資訊
        /// </summary>
        public Customer Customer{get;private set;}


        /// <summary>
        /// 接案者資訊
        /// </summary>
        public Freelancer Freelancer { get; private set; }

        /// <summary>
        /// 完成時間
        /// </summary>
        public DateTime Timesheets{get;private set;}

        /// <summary>
        /// 專案狀態
        /// </summary>
        public ProjectStaus Status { get; private set; }


        /// <summary>
        /// 建立時間
        /// </summary>
        public DateTime CreateDt { get; private set; }





    }
}
