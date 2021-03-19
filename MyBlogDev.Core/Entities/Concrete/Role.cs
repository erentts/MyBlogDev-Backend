using System;
using System.Collections.Generic;
using System.Text;

namespace MyBlogDev.Core.Entities.Concrete
{
    public class Role:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<User> Users { get; set; }
    }
}
