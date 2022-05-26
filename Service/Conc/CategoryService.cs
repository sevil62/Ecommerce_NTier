
using DAL.Context;
using DAL.Entity;
using DAL.Tools;
using Service.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Conc
{
    public class CategoryService : BaseService<Category>
    {
        EcommerceContext context = DbTools.Context;

        public void ProductCount(string categoryName)
        {
            var result = context.Products.SqlQuery(@"select COUNT(*) from Products p join SubCategories sub on p.SubCategoryId=sub.ID join Categories c on c.ID=sub.CategoryId where c.CategoryName='" + categoryName + "'");

        }
       
    }

}
