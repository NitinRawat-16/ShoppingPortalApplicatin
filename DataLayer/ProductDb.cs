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
        private TestDb Db;

        public ProductDb() => Db = new TestDb();

        public IEnumerable<Product> GetAll ()
        {
            var products = Db.Products.ToList();
            return products;
        }

        public Product GetProduct(int id)
        {
            var product = Db.Products.SingleOrDefault(x=> x.ProductId == id);

            return product;
        }



        
    }
}
