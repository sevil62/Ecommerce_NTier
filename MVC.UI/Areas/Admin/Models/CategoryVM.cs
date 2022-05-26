using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.UI.Areas.Admin.Models
{
    public class CategoryVM
    {
        public Category  Category { get; set; }
        public List<Category>Categories  { get; set; }
        public List<SubCategory>SubCategories { get; set; }
    }
}