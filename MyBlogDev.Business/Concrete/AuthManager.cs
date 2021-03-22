using System;
using System.Collections.Generic;
using System.Text;
using MyBlogDev.Business.Abstract;
using MyBlogDev.Business.Constants;
using MyBlogDev.Core.Entities.Concrete;
using MyBlogDev.Core.Utilities.Results;
using MyBlogDev.Core.Utilities.Security.Hashing;
using MyBlogDev.Core.Utilities.Security.Jwt;
using MyBlogDev.Entities.Dtos;

namespace MyBlogDev.Business.Concrete
{
    public class AuthManager:IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            throw new NotImplementedException();
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<User>(UserMessage.UserNotFound);
            }

            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.Data.PasswordHash,
                userToCheck.Data.PasswordSalt))
            {
                return new ErrorDataResult<User>(UserMessage.PasswordError);
            }

            return new SuccessDataResult<User>(userToCheck.Data, UserMessage.SuccessfulLogin);
        }

        public IResult UserExists(string email)
        {
            if (_userService.GetByMail(email) != null)
            {
                return new ErrorResult(UserMessage.UserAlreadyExists);
            }

            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            throw new NotImplementedException();
        }
    }
}
