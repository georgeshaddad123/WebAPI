using Microsoft.AspNetCore.Mvc;
using WebAPI.Abstraction;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ImagesController : ControllerBase
{
    private readonly IImageHelper _imageHelper;

    public ImagesController(IImageHelper imageHelper)
    {
        _imageHelper = imageHelper;
    }

    [HttpPost("uploadImage")]
    public IActionResult UploadImage(IFormFile formFile)
    {
        if (!_imageHelper.UploadImage(formFile))
            return BadRequest();
        return Ok();
    }
}