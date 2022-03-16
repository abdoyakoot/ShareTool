using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShareTool.Controllers
{
    //قومنا بكتابه هذا الفلتر هنا حتي يعمل علي جميع الصفحه ولا يعمل علي اكشن محدده فقط 
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // نذهب ل ملف ال web.config ونقوم باضافه كود هناك لجعل صفحه ال ايرور في ملف شيرد تعمل عند حدوث خطأ
            throw new Exception("حدث خطا ما ");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}