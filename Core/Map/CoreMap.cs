using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Map
{
    public class CoreMap<T>:EntityTypeConfiguration<T> where T : EntityRepository
    {
        public CoreMap()
        {
            Property(x => x.CreatedAdUserName).IsOptional().HasMaxLength(255);
            Property(x => x.CreatedComputerName).IsOptional().HasMaxLength(255);
            Property(x => x.CreatedBy).IsOptional().HasMaxLength(255);
            Property(x => x.CreatedIP).IsOptional().HasMaxLength(255);


            Property(x => x.UpdatedAdUserName).IsOptional().HasMaxLength(255);
            Property(x => x.UpdatedComputerName).IsOptional().HasMaxLength(255);
            Property(x => x.UpdatedBy).IsOptional().HasMaxLength(255);
            Property(x => x.UpdatedIP).IsOptional().HasMaxLength(255);
        }

    }
}
