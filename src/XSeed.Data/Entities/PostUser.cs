using System;
using System.Collections.Generic;
using System.Text;

namespace XSeed.Data.Entities
{
    public class PostUser
    {
        /// <summary>
        /// 数据Id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public long UserId { get; set; }
        
        /// <summary>
        /// 话题ID
        /// </summary>
        public long PostId { get; set; }
        /// <summary>
        /// 是否阅读
        /// </summary>
        public bool Read { get; set; }
        /// <summary>
        /// 是否作者
        /// </summary>
        public bool Poster { get; set; }

        /// <summary>
        /// 是否提及
        /// </summary>
        public bool Mentioned { get; set; }

        /// <summary>
        /// 是否邀约
        /// </summary>
        public bool Invite { get; set; }
    }
}
