namespace Microservice.Product.Domain;

    public class ProductThumbnail : ValueObject<ProductThumbnail>
    {
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public string Extension { get; set; }

        protected override bool EqualsCore(ProductThumbnail other)
        {
            throw new NotImplementedException();
        }

        protected override int GetHashCodeCore()
        {
            throw new NotImplementedException();
        }
    }

