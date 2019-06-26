using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using DAL1;

namespace BLL1
{
   public class ProductBLL
    {
        public static List<Product> GetAll()
        {
            return ProductDal.GetAll();
        }
    }
}
