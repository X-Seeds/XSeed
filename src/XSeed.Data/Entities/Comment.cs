using System;
using System.Collections.Generic;
using System.Text;

namespace XSeed.Data.Entities
{
    public class Comment
    {
        public long Id { get; set; }
        public long PostId { get; set; }
        public long UserId { get; set; }
        public string Content { get; set; }

    }
}
