using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cloud.Note.Domain
{
    public class User
    {
        public virtual Int64? Id { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Email { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Password { get; set; }
    }
}
