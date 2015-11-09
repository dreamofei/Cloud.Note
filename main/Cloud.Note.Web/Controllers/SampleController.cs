using Cloud.Note.Service;
using Spring.Context.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cloud.Note.Web.Controllers
{
    public class SampleController : Controller
    {
        //
        // GET: /Sample/
        public ISampleService SampleService
        {
            get
            {
                return ContextRegistry.GetContext().GetObject("SampleService") as ISampleService;
            }
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Get()
        {
            return Json(new {Id="2",Name="test"},JsonRequestBehavior.AllowGet);
        }

        public DateTime GetTime()
        {
            return SampleService.GetTime();
        }

    }
}
