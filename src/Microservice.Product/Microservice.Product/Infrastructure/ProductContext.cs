using Microservice.Product.Application.Common.Persistence;

namespace Microservice.Product.Infrastructure;
public class ProductContext : IProductContext
{
    public List<Domain.Product> Products { get; set; } = new();
}


