using Cloud.Note.Domain;
using Spring.Data.NHibernate.Generic.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cloud.Note.Dao
{
    public class UserDao:HibernateDaoSupport,IUserDao
    {
        public string GetUser()
        {
            return "test";
        }

        public User Get()
        {
            return Session.QueryOver<User>().Where(u => u.UserName == "admin").SingleOrDefault();
            //return Session.Get<User>((Int64)1);
        }

        public User ValidateByUserName(User user)
        {
            return Session.QueryOver<User>().Where(u => (u.UserName == user.UserName && u.Password == user.Password)).SingleOrDefault();
        }
        public User ValidateByEmail(User user)
        {
            return Session.QueryOver<User>().Where(u => (u.Email == user.Email && u.Password == user.Password)).SingleOrDefault();
        }
        public User ValidateByPhoneNumber(User user)
        {
            return Session.QueryOver<User>().Where(u => (u.PhoneNumber == user.PhoneNumber && u.Password == user.Password)).SingleOrDefault();
        }

        public User GetUserByEmail(string email)
        {
            return Session.QueryOver<User>().Where(u => u.Email == email).SingleOrDefault();
        }
    }
}
