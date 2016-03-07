using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {

        #region 初始化数据集合 +List InitData()
        /// <summary>
        /// 初始化数据集合
        /// </summary>
        /// <returns></returns>
        public List<Models.Child> InitData()
        {

            List<Models.Child> list = new List<Models.Child>()
            {
                new Child(){Id=1,StrName="你好啊！"},
                new Child(){Id=2,StrName="不好啊！"}
            };

            return list;
        }

        #endregion



        // GET: Home
        public ActionResult Index()
        {
            //可以处理当前业务（你比如读取数据库，判断等）
            StringBuilder strBuilder = new StringBuilder();
            //创建数据集合，获取数据
            List<Models.Child> list = InitData();
            //遍历集合获取生成的Html代码
            list.ForEach(d =>
            {
                strBuilder.AppendLine("<div>" + d.Id.ToString() + "</div>");
            });

            //使用ViewBag传输数据给同名的Indexcshtml视图
            //ViewBag是一个dynamic类型的集合，可以动态添加任意类型的任意名称和属性
            ViewBag.HtmlStrBuilder = strBuilder.ToString();
            //加载同名视图Index.cshtml
            return View();
        }
    }
}