using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBlogDev.Core.DataAccess.Concrete.EntityFramework;
using MyBlogDev.Core.Entities.Concrete;
using MyBlogDev.DataAccess.Abstract;
using MyBlogDev.DataAccess.Concrete.EntityFramework.Contexts;

namespace MyBlogDev.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, MyBlogDevContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new MyBlogDevContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.Id
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim
                             {
                                 Id = operationClaim.Id,
                                 Name = operationClaim.Name
                             };
                return result.ToList();
            }
        }
    }
}
