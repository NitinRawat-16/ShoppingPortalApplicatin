using System;
using System.Collections.Generic;
using System.Text;
using DataLayer;
using Model;

namespace BusinessLogic
{
    public class ProductBl
    {
        private ProductDb prodDb;

        public ProductBl()
        {
            prodDb = new ProductDb ();
        }

        public IEnumerable<Product> GetAll()
        {

            return prodDb.GetAll();
        }

    }
}
