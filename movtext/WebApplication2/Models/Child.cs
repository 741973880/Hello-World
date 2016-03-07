using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Child
    {

        //编号
        private int id;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        //姓名
        private string strName;

        public string StrName
        {
            get { return strName; }
            set { strName = value; }
        }



    }
}