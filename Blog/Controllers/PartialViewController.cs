using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class PartialViewController : Controller
    {
        // GET: PartialView
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Gallery ()
        {
            //获取相册   模拟获取数据库数据
            List<UIData> lis = new List<UIData>();
            lis.Add(new UIData { Id="1",PicUrl="images/1.jpg"});
            lis.Add(new UIData { Id = "2", PicUrl = "images/2.jpg" });
            lis.Add(new UIData { Id = "3", PicUrl = "images/3.jpg" });
            lis.Add(new UIData { Id = "4", PicUrl = "images/4.jpg" });
            lis.Add(new UIData { Id = "5", PicUrl = "images/5.jpg" });
            lis.Add(new UIData { Id = "6", PicUrl = "images/6.jpg" });

            return PartialView(lis);
        }


    }
}