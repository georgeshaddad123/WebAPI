using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Abstraction;

public interface IImageHelper
{
    public bool UploadImage(IFormFile formFile);
}