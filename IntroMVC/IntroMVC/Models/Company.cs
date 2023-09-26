using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntroMVC.Models
{
    public class Company
    {
        public int Id;
        readonly string name2;
        public string Name { set; get; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Descr { get; set; }
    }
}