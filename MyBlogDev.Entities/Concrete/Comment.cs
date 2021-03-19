using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using MyBlogDev.Core.Entities;

namespace MyBlogDev.Entities.Concrete
{
    public class Comment:IEntity
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int ArticleId { get; set; }
        public int UserId { get; set; }
    }
}
