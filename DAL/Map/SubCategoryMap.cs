using Core.Map;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Map
{
    public class SubCategoryMap:CoreMap<SubCategory>
    {
        public SubCategoryMap()
        {
            ToTable("AltKategoriler");
            Property(x=>x.SubCategoryName).IsRequired().HasMaxLength(255);
            Property(x=>x.SubDescription).IsRequired().HasMaxLength(255);
        }
    }
}
