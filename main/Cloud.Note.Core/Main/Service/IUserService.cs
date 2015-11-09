using Cloud.Note.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cloud.Note.Service
{
    public interface IUserService
    {
        string GetUser();
        User Get();

        User ValidateUser(User user);
    }
}
