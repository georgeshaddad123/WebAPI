using System.Globalization;
using WebAPI.Abstraction;

namespace WebAPI.Helpers;

public class DateTimeHelper : IDateTime
{
    public string GetCurrentDate(string header)
    {
        CultureInfo cultureInfo = new CultureInfo(header);
        return DateTime.Now.ToString(cultureInfo);
    }
}