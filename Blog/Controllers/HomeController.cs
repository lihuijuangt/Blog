using Blog.Models;
using Blog.Models.DAL;
using Blog.Models.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            //获取数据  怎么  反思  请反思  有问题
            //----------------------
            //测试
            List<Articles> lis = ArticleServices.GetArticles();
            int a = 0;//更改必须推送？
            return View(lis);
        }




        public ActionResult RazorDome1 ()
        {
            return View();
        }

        public ActionResult RazorDome2 ()
        {
            //模拟数据   数据库 
            List<Student> lis = new List<Student>();
            lis.Add(new Student { Id = 1, Name = "张三1" });
            lis.Add(new Student { Id = 2, Name = "张三2" });
            lis.Add(new Student { Id = 3, Name = "张三3" });
            lis.Add(new Student { Id = 4, Name = "张三4" });
            //Student stu = new Student { Id = 1, Name = "张三33333" };

            ViewData["msg"] = "这是viewdata传过来的值";
            ViewData["stu"] = new Student { Id = 1, Name = "张三viewData" };

            ViewBag.A = "这是ViewBag传过来的值";
            ViewBag.Student1= new Student { Id = 1, Name = "张三viewBag" };
            return View(lis);
        }

    }
}