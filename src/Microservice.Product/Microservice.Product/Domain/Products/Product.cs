namespace Microservice.Product.Domain;
public class Product : Entity<Guid>
{
    public string ProductName { get; private set; }
    public string Description { get; private set; }
    public ProductThumbnail Thumbnail { get; private set; }


    public static Product CreateNew(string productname, string desscription,
        string? thumbnailPath, string? thumbnailName, string? thumbnailExtension, int? thumbnailSize)
    {
        return new Product(Guid.NewGuid(), productname, desscription, thumbnailPath, thumbnailName, thumbnailExtension, thumbnailSize);
    }



    private void BuildThumbnail(string? filePath, string? fileName, string? fileExtension, int? fileSize)
    {
        if (string.IsNullOrEmpty(filePath)) return;
        Thumbnail = new ProductThumbnail();
        Thumbnail.FilePath = filePath;
        Thumbnail.FileName = fileName;
        Thumbnail.Extension = fileExtension;
    }

    private Product(Guid id, string productname, string desscription,
        string? thumbnailPath, string? thumbnailName, string? thumbnailExtension, int? thumbnailSize)
    {
        //validation....
        Id = id;
        ProductName = productname;
        Description = desscription;
        BuildThumbnail(thumbnailPath, thumbnailName, thumbnailExtension, thumbnailSize);
    }

    private Product()
    {
    }
}

