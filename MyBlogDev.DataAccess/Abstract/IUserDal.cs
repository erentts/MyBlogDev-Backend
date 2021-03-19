using System;
using System.Collections.Generic;
using System.Text;
using MyBlogDev.Core.DataAccess;
using MyBlogDev.Core.Entities.Concrete;

namespace MyBlogDev.DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
