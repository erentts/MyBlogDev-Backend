using System;
using System.Collections.Generic;
using System.Text;
using MyBlogDev.Core.Entities.Concrete;
using MyBlogDev.Core.Utilities.Results;
using MyBlogDev.Core.Utilities.Security.Jwt;
using MyBlogDev.Entities.Dtos;

namespace MyBlogDev.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto,string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
