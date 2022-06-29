using Microsoft.AspNetCore.Mvc;
using WebAPI.Abstraction;

namespace WebAPI.Helpers;

public class ImageHelper: IImageHelper
{
    private readonly IWebHostEnvironment _webHostEnvironment;
    
    public ImageHelper(IWebHostEnvironment webHostEnvironment)
    {
        _webHostEnvironment = webHostEnvironment;
    }
    public Boolean UploadImage(IFormFile formFile)
    {
        string path = Path.Combine(_webHostEnvironment.WebRootPath);
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        string file = Path.GetFileName(formFile.FileName);
        FileStream fileStream = new FileStream(Path.Combine(path, file), FileMode.Create);
        formFile.CopyTo(fileStream);
        fileStream.Close();
        return true;
    }
}