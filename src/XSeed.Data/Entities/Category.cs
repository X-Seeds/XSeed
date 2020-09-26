using System;
using System.Collections.Generic;
using System.Text;

namespace XSeed.Data.Entities
{
    /// <summary>
    /// 内容分类
    /// </summary>
    public class Category
    {
        /// <summary>
        /// 分类ID
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
    }
}
