using System;
using System.Collections.Generic;
using System.Text;

namespace XSeed.Data.Entities
{
    /// <summary>
    /// 统计信息
    /// </summary>
    public class Statistic
    {
        /// <summary>
        /// 数据ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 注册用户数量
        /// </summary>
        public int UserCount { get; set; }

        /// <summary>
        /// 话题数量
        /// </summary>
        public int PostCount { get; set; }

        /// <summary>
        /// 访客数量
        /// </summary>
        public int VisitorCount { get; set; }

        /// <summary>
        /// 最大在线人数
        /// </summary>
        public int MaxOnlineCount { get; set; }
    }
}
