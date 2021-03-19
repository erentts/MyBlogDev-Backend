using System;
using System.Collections.Generic;
using MyBlogDev.Core.Entities;

namespace MyBlogDev.Entities.Concrete
{
    public class Article:IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Contents { get; set; }
        public string Thumbnail { get; set; }
    }
}
