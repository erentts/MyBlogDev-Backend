using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBlogDev.Business.Abstract;
using MyBlogDev.Business.Constants;
using MyBlogDev.Core.Utilities.Results;
using MyBlogDev.DataAccess.Abstract;
using MyBlogDev.Entities.Concrete;

namespace MyBlogDev.Business.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.Id == categoryId));
        }

        public IDataResult<List<Category>> GetList()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetList().ToList());
        }

        public IResult Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult(CategoryMessage.categoryAdded);
        }

        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(CategoryMessage.categoryDeleted);
        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(CategoryMessage.categoryUpdated);
        }
    }
}
