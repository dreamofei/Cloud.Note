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
        #region test
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
            Cloud.Note.Domain.User user = UserService.Get();
            if (user == null)
            {
                return Json(new { Msg = "No data" }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { Id = user.Id, Name = user.UserName, Email = user.Email, PhoneNumber = user.PhoneNumber }, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region account

        public JsonResult ValidateUser(User user)
        {
            User returnUser = UserService.ValidateUser(user);
            if (returnUser == null)
            {
                //HttpContext.Response.AppendHeader("Access-Control-Allow-Origin", "*");
                return Json(new { }, ResultType.Failure, "用户名或密码错误");
            }
            return Json(
                new
                {
                    Id = returnUser.Id,
                    UserName = returnUser.UserName,
                    Email = returnUser.Email,
                    PhoneNumber = returnUser.PhoneNumber
                },
                ResultType.Success,
                ""
                );
        }

        public JsonResult CheckExistEmail([System.Web.Http.FromBody]string email)
        {
            if(string.IsNullOrWhiteSpace(email))
            {
                return Json(new {},ResultType.Failure,"邮箱不能为空");
            }
            User returnUser = UserService.GetUserByEmail(email);
            if(returnUser==null)
            {
                return Json(new {Email=email }, ResultType.Success, "");
            }
            return Json(new { },ResultType.Failure,"该邮箱已经被注册");
        }

        #endregion

    }
}
