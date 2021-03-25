using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using MyBlogDev.Entities.Concrete;

namespace MyBlogDev.Business.ValidationRules.FluentValidation
{
    public class ArticleValidator:AbstractValidator<Article>
    {
        public ArticleValidator()
        {
            RuleFor(a => a.Name).NotEmpty();
            RuleFor(a => a.Name).Length(2, 30);
            RuleFor(a => a.Contents).NotEmpty();
            RuleFor(a => a.Thumbnail).NotEmpty();
        }
    }
}
