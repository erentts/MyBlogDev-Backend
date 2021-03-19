using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyBlogDev.Business.Abstract;
using MyBlogDev.Business.Constants;
using MyBlogDev.Core.Entities.Concrete;
using MyBlogDev.Core.Utilities.Results;
using MyBlogDev.DataAccess.Abstract;

namespace MyBlogDev.Business.Concrete
{
    public class UserManager:IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            return new SuccessDataResult<List<OperationClaim>>(_userDal.GetClaims(user));
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetList().ToList());
        }

        public IDataResult<User> GetById(int userId)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Id == userId));
        }

        public IDataResult<User> GetByMail(string email)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Email == email));
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(UserMessage.UserAdded);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(UserMessage.UserDeleted);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(UserMessage.UserUpdated);
        }
    }
}
