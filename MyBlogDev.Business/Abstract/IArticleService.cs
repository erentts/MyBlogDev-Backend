using System;
using System.Collections.Generic;
using System.Text;
using MyBlogDev.Core.Utilities.Results;
using MyBlogDev.Entities.Concrete;

namespace MyBlogDev.Business.Abstract
{
    public interface IArticleService
    {
        IDataResult<Article> GetById(int articleId);
        IDataResult<List<Article>> GetAll();
        IDataResult<List<Article>> GetListByCategory(int categoryId);
        IResult Add(Article article);
        IResult Delete(Article article);
        IResult Update(Article article);
        IResult TransactionalOperation(Article article);
    }
}
