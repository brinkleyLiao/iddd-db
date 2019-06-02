using iddd_db.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace iddd_db.Models.DTO
{
    public class NewProjectDto
    {
        /// <summary>
        /// 會員
        /// </summary>
        [Required]
        public IUser User { get; set; }

        /// <summary>
        /// 專案名稱
        /// </summary>
        [Required]
        public string ProjectName { get; set; }

        /// <summary>
        /// 內容
        /// </summary>
        [Required]
        public string Content { get; set; }

        /// <summary>
        /// 價格
        /// </summary>
        [Required,Range(0,int.MaxValue)]
        public decimal Price { get; set; }
    }
}
