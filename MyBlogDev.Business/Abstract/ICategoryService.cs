using System;
using System.Collections.Generic;
using System.Text;
using MyBlogDev.Core.Utilities.Results;
using MyBlogDev.Entities.Concrete;

namespace MyBlogDev.Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<Category> GetById(int categoryId);
        IDataResult<List<Category>> GetList();
        IResult Add(Category category);
        IResult Delete(Category category);
        IResult Update(Category category);
    }
}
