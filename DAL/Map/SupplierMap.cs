using Core.Map;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Map
{
    public class SupplierMap:CoreMap<Supplier>
    {
        public SupplierMap()
        {
            ToTable("Tedarikçiler");
            Property(x=>x.CompanyName).IsRequired().HasMaxLength(255);
            Property(x=>x.PhoneNumber).IsOptional().HasMaxLength(255);
            Property(x=>x.Address).IsOptional().HasMaxLength(500);
            Property(x=>x.Email).IsRequired().HasMaxLength(255);
        }
    }
}
