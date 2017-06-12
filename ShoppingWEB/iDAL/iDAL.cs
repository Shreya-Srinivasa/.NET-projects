using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace iDAL
{
    public interface iDAL
    {
        List<Product> GetProducts();
        Product GetProductByProductID(int productID);
        int InsertProduct(Product objProduct);
    }
}
