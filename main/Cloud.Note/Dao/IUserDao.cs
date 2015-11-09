using Cloud.Note.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cloud.Note.Dao
{
    public interface IUserDao
    {
        string GetUser();
        User Get();

        User ValidateByUserName(User user);
        User ValidateByEmail(User user);
        User ValidateByPhoneNumber(User user);
    }
}
