using System.Collections.Generic;
using webapiproject.Model;

namespace webapiproject.Services
{
    public interface IProductServices
    {
        IEnumerable<Product> GetAllProducts();
        int AddProduct(Product prod);
        int ModifyProduct(Product prod);
        int DeleteProduct(int id);


    }
}
