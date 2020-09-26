using System;
using System.Collections.Generic;
using System.Text;

namespace XSeed.Data.Entities
{
    /// <summary>
    /// 访客信息
    /// </summary>
    public class Visitor
    {
        public long Id { get; set; }

        public string Token { get; set; }

        public long UserId { get; set; }

        public long CategoryId { get; set; }

        public long PostId { get; set; }

        public DateTime ActiveTime { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
