using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShareTool.Models;

namespace ShareTool.Controllers
{
    public class ShareToolController : Controller
    {
        // GET: ShareTool
        public ActionResult Index()
        {
            List<SharedTool> ShareToollist = new List<SharedTool>();
            SharedTool share1 = new SharedTool("غساله","الحاله كويسه",1);
            SharedTool share2 = new SharedTool("عجله","استعمال طبيب",2);
            SharedTool share3 = new SharedTool("تلاجه","بكفاءة 70",3);
            SharedTool share4 = new SharedTool("عربيه","100%",4);

            ShareToollist.Add(share1);
            ShareToollist.Add(share2);
            ShareToollist.Add(share3);
            ShareToollist.Add(share4);
            return View(ShareToollist);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        // after ( we can write [Bind(Include="Name,Description") that code will ignore quntity or we can use Exclude and
        // write the parameter we want to ignore it ]
        public ActionResult Create(FormCollection values)
        {
            string name = values["Name"];
            string desc = values["Description"];
            int quntity;
            int.TryParse(values["Quantity"],out quntity);
            return RedirectToAction("index");
        }
    }
}