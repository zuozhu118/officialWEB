using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YUTIAN.Controllers
{
    public class YTianController : Controller
    {
        //
        // GET: /YTian/

        public ActionResult Index()//主页面
        {
            return View();
        }
        public ActionResult ChargingPile()//充电桩
        {
            return View();

        }
        public ActionResult ParkingLot()//停车场
        {

            return View();
        }
        public ActionResult RentCar()//分时租赁
        {

            return View();
        }
        public ActionResult Company_Adress()//公司地址
        {

            return View();
        }
        public ActionResult Company_Profile()//公司简介
        {

            return View();
        }
        public ActionResult Success_Case()//成功案例
        {

            return View();
        }
        public ActionResult Solution()//解决方案
        {

            return View();
        }
        public ActionResult Service_Center()//服务中心
        {

            return View();
        }
        public ActionResult Team_Style()//团队风采
        {

            return View();
        }
        //public JsonResult Test_Async(string name)
        //{

        //    return Json("成功");
        //}
    }
}
