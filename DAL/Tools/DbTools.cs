using DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Tools
{
    public class DbTools
    {
        private DbTools() { }
      

        private static EcommerceContext _context;
        public static EcommerceContext Context
        {
            get
            {
                if (_context == null)
                {
                    _context = new EcommerceContext();
                }
                return _context;
            }
        }

    }
}
