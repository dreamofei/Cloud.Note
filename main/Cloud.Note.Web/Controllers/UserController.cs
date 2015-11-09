using Cloud.Note.Domain;
using Cloud.Note.Service;
using Cloud.Note.Web.Common;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cloud.Note.Web.Controllers
{
    public class UserController : BaseController
    {
        private IUserService UserService
        {
            get
            {
                return ContextRegistry.GetContext().GetObject("UserService") as IUserService;
            }
        }

        public string GetUser()
        {
            return UserService.GetUser();
        }

        public JsonResult Get()
        {
            Cloud.Note.Domain.User user=UserService.Get();
            if(user==null)
            {
                return Json(new { Msg="No data"},JsonRequestBehavior.AllowGet);
            }
            return Json(new { Id=user.Id,Name=user.UserName,Email=user.Email,PhoneNumber=user.PhoneNumber},JsonRequestBehavior.AllowGet);
        }

        public JsonResult ValidateUser(User user)
        {
            User returnUser = UserService.ValidateUser(user);
            if (returnUser == null)
            {
                return Json(new { }, ResultType.Failure, "用户名或密码错误");
            }
            return Json(
                new { 
                    Id = returnUser.Id,
                    UserName = returnUser.UserName,
                    Email = returnUser.Email,
                    PhoneNumber = returnUser.PhoneNumber
                },
                ResultType.Success,
                ""
                );
        }

        public void ValidateUser2(string user1)
        {
            //User user=JavaScriptSerialize 
            //User returnUser = UserService.ValidateUser(user);
            //if (returnUser == null)
            //{
            //    return Json(new { }, ResultType.Failure, "用户名或密码错误");
            //}
            //return Json(
            //    new
            //    {
            //        Id = returnUser.Id,
            //        UserName = returnUser.UserName,
            //        Email = returnUser.Email,
            //        PhoneNumber = returnUser.PhoneNumber
            //    },
            //    ResultType.Success,
            //    ""
            //    );
        }

    }
}
