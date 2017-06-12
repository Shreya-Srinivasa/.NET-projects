using System.Collections.Generic;
using Entities;
using iDAL;
using ObjectFactory;

namespace Services
{
    public class ServicesCode
    {
        iDAL.iDAL _dal;

        public ServicesCode()
        {
            _dal = new Factory().GetDAL();
        }
        public List<Product> GetProductsBAL()
        {
            return _dal.GetProducts();
        }
        public List<Product> GetProductsUsingEnitityFrameworkBAL()
        {
            return new List<Product>();
        }
        public bool InsertProduct(Product objProduct)
        {
            if (_dal.InsertProduct(objProduct) >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
