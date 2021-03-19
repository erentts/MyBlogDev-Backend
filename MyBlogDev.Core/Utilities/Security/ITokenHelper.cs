using System.Collections.Generic;
using MyBlogDev.Core.Entities.Concrete;

namespace MyBlogDev.Core.Utilities.Security
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
