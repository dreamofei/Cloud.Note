using Cloud.Note.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cloud.Note.Web.Controllers
{
    public class BaseController : Controller
    {
        public JsonResult Json(object data,ResultType resultType,string msg)
        {
            return Json(new { ResultType = resultType.ToString(), Data = data, Msg = msg }, "application/json", System.Text.Encoding.UTF8, JsonRequestBehavior.AllowGet);
        }
    }
}
