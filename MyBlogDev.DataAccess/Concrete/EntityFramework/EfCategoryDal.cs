using System;
using System.Collections.Generic;
using System.Text;
using MyBlogDev.Core.DataAccess.Concrete.EntityFramework;
using MyBlogDev.DataAccess.Abstract;
using MyBlogDev.DataAccess.Concrete.EntityFramework.Contexts;
using MyBlogDev.Entities.Concrete;

namespace MyBlogDev.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category,MyBlogDevContext>,ICategoryDal
    {
    }
}
