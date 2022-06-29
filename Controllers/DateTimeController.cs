using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Abstraction;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class DateTimeController : ControllerBase
{
    private readonly IDateTime _dateTime;

    public DateTimeController(IDateTime dateTime)
    {
        _dateTime = dateTime;
    }

    [HttpGet("getCurrentDate")]
    public string GetCurrentDate(string header)
    {
        return _dateTime.GetCurrentDate(header);
    }
}