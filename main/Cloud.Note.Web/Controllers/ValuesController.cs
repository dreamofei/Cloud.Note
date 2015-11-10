using Cloud.Note.Domain;
using Cloud.Note.Service;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Cloud.Note.Web.Controllers
{
    public class ValuesController : ApiController
    {

        private IUserService UserService
        {
            get
            {
                return ContextRegistry.GetContext().GetObject("UserService") as IUserService;
            }
        }
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return id.ToString();
        }

        // POST api/values
        //public void Post([FromBody]string value)
        //{
        //}

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        [HttpPost]
        public string ValidateUser(User user)
        {
            User returnUser = UserService.ValidateUser(user);
            if (returnUser == null)
            {
                return "用户名或密码错误";
            }
            return "成功";
        }
        public string Options()
        {
            return null; // HTTP 200 response with empty body
        }
    }
}
