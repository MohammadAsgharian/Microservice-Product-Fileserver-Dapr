using Microservice.Product.Contracts.Requests;
using Microservice.Product.Shared.DependencyInjection;

namespace Microservice.Product.Application.IServices;
public interface IProductService : IScopedService
{
    void Add(AddProductRequest product);
}

