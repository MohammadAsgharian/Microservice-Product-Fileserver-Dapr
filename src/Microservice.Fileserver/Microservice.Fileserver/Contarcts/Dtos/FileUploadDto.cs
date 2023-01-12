namespace Microservice.Fileserver.Contarcts.Dtos
{
    public class FileUploadDto
    {
        public string AppName { get; set; }
        public string EntityName { get; set; }
        public Guid UserId { get; set; }
        public IFormFile File { get; set; }
        public string FileName { get; set; }
    }
}
