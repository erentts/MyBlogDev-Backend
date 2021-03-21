using System.Collections.Generic;
using MyBlogDev.Core.Entities.Concrete;

namespace MyBlogDev.Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
