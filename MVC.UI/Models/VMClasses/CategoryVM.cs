using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.UI.Models.VMClasses
{
    public class CategoryVM
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Category>Categories  { get; set; }
    }
}