using Core.Map;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Map
{
    public class UserMap:CoreMap<User>
    {
        public UserMap()
        {
            ToTable("Kullanıcılar");
            Property(x=>x.UserName).IsRequired().HasMaxLength(255);
            Property(x=>x.Password).IsRequired().HasMaxLength(255);

        }
    }
}
