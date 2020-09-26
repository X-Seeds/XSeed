using System;
using System.Collections.Generic;
using System.Text;

namespace XSeed.Data.Entities
{
    /// <summary>
    /// 文章帖子
    /// </summary>
    public class Post
    {
        public long Id { get; set; }
        public long CategoryId { get; set; }
        public long PosterId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        /// <summary>
        /// 最后回复的用户ID
        /// </summary>
        public long LastCommenterId { get; set; }

        /// <summary>
        /// 回复评论数量
        /// </summary>
        public long CommentCount { get; set; }
        public DateTime CreateTime { get; set; }
       
        public DateTime UpdateTime { get; set; }
        public int ClickCount { get; set; }
        
    }
}
