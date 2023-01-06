using Microservice.Product.Application.Common.Persistence;
using Microservice.Product.Application.IServices;
using Microservice.Product.Contracts.Requests;
using System.Runtime.CompilerServices;

namespace Microservice.Product.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductContext productContext;

        public ProductService(IProductContext _productContext)
        {
            this.productContext = _productContext;
        }
        public void Add(AddProductRequest product)
        {
            var model = Product.Domain.Product.CreateNew(product.productname,product.description,product.Thumbnail.,product.Thumbnail.FileName,t);
            productContext.Products.Add(Pro)
        }
    }
}
