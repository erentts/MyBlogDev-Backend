using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using MyBlogDev.Business.Abstract;
using MyBlogDev.Business.Concrete;
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
        }
    }
}
