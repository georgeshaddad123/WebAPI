using System.Globalization;
using WebAPI.Abstraction;

namespace WebAPI.Helpers;

public class DateTimeHelper : IDateTime
{
    public string GetCurrentDate(string header)
    {
        List<CultureInfo> allCultures = CultureInfo.GetCultures(CultureTypes.AllCultures).ToList();
        try
        {
            CultureInfo cultureInfo = new CultureInfo(header);
            allCultures.Contains(cultureInfo);
            return DateTime.Now.ToString(cultureInfo);
        }
        catch (Exception e)
        {
            Console.WriteLine("The accepted language is not valid!");
            // throw;
        }

        return null;
    }
}