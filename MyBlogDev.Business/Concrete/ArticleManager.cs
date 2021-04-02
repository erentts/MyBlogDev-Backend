using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBlogDev.Business.Abstract;
using MyBlogDev.Business.Constants;
using MyBlogDev.Business.ValidationRules.FluentValidation;
using MyBlogDev.Core.Aspects.Autofac.Validation;
using MyBlogDev.Core.CrossCuttingConcerns.Validation.FluentValidation;
using MyBlogDev.Core.Utilities.Results;
using MyBlogDev.DataAccess.Abstract;
using MyBlogDev.Entities.Concrete;

namespace MyBlogDev.Business.Concrete
{
    public class ArticleManager:IArticleService
    {
        private IArticleDal _articleDal;

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public IDataResult<Article> GetById(int articleId)
        {
            return new SuccessDataResult<Article>(_articleDal.Get(a => a.Id == articleId));
        }

        public IDataResult<List<Article>> GetAll()
        {
            return new SuccessDataResult<List<Article>>(_articleDal.GetList().ToList());
        }

        public IDataResult<List<Article>> GetListByCategory(int categoryId)
        {
            return new SuccessDataResult<List<Article>>(_articleDal.GetList(a => a.CategoryId == categoryId).ToList());
        }

        [ValidationAspect(typeof(ArticleValidator),Priority = 1)]
        public IResult Add(Article article)
        {
            _articleDal.Add(article);
            return new SuccessResult(ArticleMessage.ArticleAdded);
        }

        public IResult Delete(Article article)
        {
            _articleDal.Delete(article);
            return new SuccessResult(ArticleMessage.ArticleDeleted);
        }

        public IResult Update(Article article)
        {
            _articleDal.Update(article);
            return new SuccessResult(ArticleMessage.ArticleUpdated);
        }
    }
}
