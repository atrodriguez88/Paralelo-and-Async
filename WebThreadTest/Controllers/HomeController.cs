using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;
using WebThreadTest.Services;

namespace WebThreadTest.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            ThreadsServices obj = new ThreadsServices();
            Stopwatch stopWatch = new Stopwatch();


            stopWatch.Start();

            /*Paralelo and Async*/
            var t1 = obj.Thread1(1000);
            var t2 = obj.Thread2(5500);
            var t3 = obj.Thread3(3255);
            var t4 = obj.Thread4(2000);
            await Task.WhenAll(t1, t2, t3, t4);

            /*Paralelo and Not Async*/
            //var t1 = Task.Factory.StartNew(() => obj.Thread1(1000));
            //var t2 = Task.Factory.StartNew(() => obj.Thread2(1500));
            //var t3 = Task.Factory.StartNew(() => obj.Thread3(4255));
            //var t4 = Task.Factory.StartNew(() => obj.Thread4(300));
            //Task.WhenAll(t1, t2, t3, t4);


            ViewBag.Value1 = t1.Result;
            ViewBag.Value2 = t2.Result;
            ViewBag.Value3 = t3.Result;
            ViewBag.Value4 = t4.Result;

            stopWatch.Stop();
            ViewBag.Time = stopWatch.Elapsed;

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