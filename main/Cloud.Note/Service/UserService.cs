using Cloud.Note.Dao;
using Cloud.Note.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cloud.Note.Service
{
    public class UserService:IUserService
    {
        public IUserDao UserDao
        {
            private get;
            set;
        }
        public string GetUser()
        {
            return UserDao.GetUser();
        }
        public User Get()
        {
            return UserDao.Get();
        }

        public User ValidateUser(User user)
        {
            if(string.IsNullOrEmpty(user.Password))
            {
                return null;
            }
            if(!string.IsNullOrEmpty(user.UserName))
            {
                return UserDao.ValidateByUserName(user);
            }
            if (!string.IsNullOrEmpty(user.Email))
            {
                return UserDao.ValidateByEmail(user);
            }
            if (!string.IsNullOrEmpty(user.PhoneNumber))
            {
                return UserDao.ValidateByPhoneNumber(user);
            }
            return null;
        }

        public User GetUserByEmail(string email)
        {
            return UserDao.GetUserByEmail(email);
        }
    }
}
