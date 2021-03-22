using System;
using System.Collections.Generic;
using System.Text;
using MyBlogDev.Core.Entities.Concrete;
using MyBlogDev.Core.Utilities.Results;

namespace MyBlogDev.Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int userId);
        User GetByMail(string email);
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
    }
}
