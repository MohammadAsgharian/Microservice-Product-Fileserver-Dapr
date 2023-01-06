using Microservice.Product.Application.IServices;
using Microservice.Product.Contracts.Requests;

namespace Microservice.Product.Application.Services
{
    public class ProductService : IProductService
    {
        public ProductService()
        {

        }
        public void Add(AddProductRequest product)
        {
            throw new NotImplementedException();
        }
    }
}
