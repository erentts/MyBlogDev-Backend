using System;
using System.Collections.Generic;
using System.Text;
using MyBlogDev.Core.DataAccess;
using MyBlogDev.Entities.Concrete;

namespace MyBlogDev.DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
    }
}
