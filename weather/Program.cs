
namespace weather;

using lib;

internal static class Program
{
    private static readonly Uri Uri =
        new(
            "https://api.openweathermap.org/data/2.5/weather?q=Tver&appid=9e8f95bba816372a0741d88a3c210322&units=metric");

    private static void Main()
    {
        var service = new Service(Uri);
        var r = service.Weather().Result;
        Console.WriteLine(r);
    }
}