using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace XSeed.Data.Entities
{
    [Comment("短信")]
    public class ShortMessage
    {
        /// <summary>
        /// 
        /// </summary>
        public long Id { get; set; }
        public string Mobile { get; set; }

        public string Code { get; set; }
        /// <summary>
        /// 短信类型
        /// </summary>
        public int Type { get; set; }

        public int State { get; set; }

        public DateTime ExpiredTime { get; set; }
        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
