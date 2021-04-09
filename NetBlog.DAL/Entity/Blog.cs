using System;
using System.Collections.Generic;
using System.Text;

namespace NetBlog.DAL.Entity
{
   public class Blog
    {
        public int ID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public DateTime PublishedDate { get; set; }
        public string ImagePath { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
