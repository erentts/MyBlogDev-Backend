using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using MyBlogDev.Business.Abstract;
using MyBlogDev.Business.Concrete;
using MyBlogDev.Core.Utilities.Security.Jwt;
using MyBlogDev.DataAccess.Abstract;
using MyBlogDev.DataAccess.Concrete.EntityFramework;

namespace MyBlogDev.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ArticleManager>().As<IArticleService>();
            builder.RegisterType<EfArticleDal>().As<IArticleDal>();

            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();
        }
    }
}
