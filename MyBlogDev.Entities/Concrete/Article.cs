using System;
using System.Collections.Generic;
using MyBlogDev.Core.Entities;

namespace MyBlogDev.Entities.Concrete
{
    public class Article:IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        public int Name { get; set; }
        public string Contents { get; set; }
        public string Thumbnail { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public IList<Comment> Comments { get; set; }
    }
}
