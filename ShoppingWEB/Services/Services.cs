using System.Collections.Generic;
using Entities;
using adoDAL;

namespace Services
{
    public class ServicesCode
    {
        public List<Product> GetProductsBAL()
        {
            return new DAL().GetProducts(); ;
        }
    }
}
