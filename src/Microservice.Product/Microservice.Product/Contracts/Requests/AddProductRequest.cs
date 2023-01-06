namespace Microservice.Product.Contracts.Requests
{
    public record AddProductRequest(string productname, string description, IFormFile? Thumbnail);
}
