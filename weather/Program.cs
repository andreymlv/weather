
namespace weather;

using lib;

public static class Program
{
    private static readonly Uri Uri =
        new(
            "https://api.openweathermap.org/data/2.5/weather?q=Tver&appid=670829040b254ca98df582a6906f4b94&units=metric");

    private static void Main()
    {
        var service = new Service(Uri);
        var r = service.Weather().Result;
        Console.WriteLine(r);
    }
}