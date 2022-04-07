using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataLayer
{
    public class ProductDb
    {
        private PortalEntities Db;

        public ProductDb()
        {
            Db = new PortalEntities();
        }

        public IEnumerable<Product> GetAll ()
        {
            var products = Db.Products.ToList();
            return products;
        }




        
    }
}
