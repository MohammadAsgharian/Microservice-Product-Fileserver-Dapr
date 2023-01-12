using System.Text.RegularExpressions;

namespace Microservice.Fileserver.Infrastructure
{
    public class FileUtility
    {
        public string GenerateFolderPathFromFileInfo(FileUploadDto fileUploadInfo, string fileExtension)
        {
            var path = fileExtension switch
            {
                ".png" or "png" or ".jpg" or "jpg" or ".jpeg" or "jpeg" =>
                     Path.Combine("Files", fileUploadInfo.AppName, fileUploadInfo.EntityName, "Images"),


                ".mp4" or "mp4" or ".ogg" or "ogg" =>
                    Path.Combine("Files", fileUploadInfo.AppName, fileUploadInfo.EntityName, "Videos"),


                ".pdf" or "pdf" or ".docx" or "docx" =>
                       Path.Combine("Files", fileUploadInfo.AppName, fileUploadInfo.EntityName, "Documents"),

                _ =>
                    Path.Combine("Files", fileUploadInfo.AppName, fileUploadInfo.EntityName, "Others")
            }
                   
        }

return path;
        }

    public string RemoveSpecialCharacters(string str)
    {
        return Regex.Replace(str, "[^a-zA-Z0-9_.]+", string.Empty, RegexOptions.Compiled);
    }

    private readonly Regex Whitespace = new(@"\s+");

    public string ReplaceWhitespace(string input, string replacement)
    {
        return Whitespace.Replace(input, replacement);
    }

    public string NextAvailableFilename(string path)
    {
        if (!System.IO.File.Exists(path))
        {
            return path;
        }

        if (Path.HasExtension(path))
        {
            return GetNextFilename(path.Insert(path.LastIndexOf(Path.GetExtension(path), StringComparison.Ordinal), NumberPattern));
        }

        return GetNextFilename(path + NumberPattern);
    }

    private const string NumberPattern = "-{0}";

    public string GetNextFilename(string pattern)
    {
        string tmp = string.Format(pattern, 1);

        if (!System.IO.File.Exists(tmp))
        {
            return tmp;
        }

        int min = 1, max = 2;

        while (System.IO.File.Exists(string.Format(pattern, max)))
        {
            min = max;
            max *= 2;
        }

        while (max != min + 1)
        {
            int pivot = (max + min) / 2;
            if (System.IO.File.Exists(string.Format(pattern, pivot)))
            {
                min = pivot;
            }
            else
            {
                max = pivot;
            }
        }

        return string.Format(pattern, max);
    }
}
}
