using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TemperatureWeb.Models;
using Temperature;

namespace TemperatureWeb.Controllers;
public class HomeController : Controller
{
  private readonly ILogger<HomeController> _logger;

  public HomeController(ILogger<HomeController> logger)
  {
    _logger = logger;
  }

  public IActionResult Index()
  {
    return View();
  }

  [HttpPost]
  public IActionResult Index(TemperatureModel temper)
  {
    Conversion c = new Conversion();

    string tempFrom = temper.tempFrom;
    string tempTo = temper.tempTo;
    double tempCon = temper.temp;
    double converted = 0;

    if (tempFrom == Temperatures.Celcius.ToString() && tempTo == Temperatures.Fahrenhiet.ToString())
    {
      converted = c.Convert(Conversion.ConversionMode.Celsius_to_Fahrenheit, tempCon);
    }
    else if (tempFrom == Temperatures.Celcius.ToString() && tempTo == Temperatures.Kelvin.ToString())
    {
      converted = c.Convert(Conversion.ConversionMode.Celsius_to_Kelvin, tempCon);
    }
    else if (tempFrom == Temperatures.Fahrenhiet.ToString() && tempTo == Temperatures.Celcius.ToString())
    {
      converted = c.Convert(Conversion.ConversionMode.Fahrenheit_to_Celsius, tempCon);
    }
    else if (tempFrom == Temperatures.Fahrenhiet.ToString() && tempTo == Temperatures.Kelvin.ToString())
    {
      converted = c.Convert(Conversion.ConversionMode.Fahrenheit_to_Kelvin, tempCon);
    }
    else if (tempFrom == Temperatures.Kelvin.ToString() && tempTo == Temperatures.Celcius.ToString())
    {
      converted = c.Convert(Conversion.ConversionMode.Kelvin_to_Celsius, tempCon);
    }
    else if (tempFrom == Temperatures.Kelvin.ToString() && tempTo == Temperatures.Fahrenhiet.ToString())
    {
      converted = c.Convert(Conversion.ConversionMode.Kelvin_to_Fahrenheit, tempCon);
    } else {
        ViewBag.test = tempCon;

        return View();
    }

    ViewBag.test = converted;

    return View();
  }

  public IActionResult Privacy()
  {
    return View();
  }

  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
  public IActionResult Error()
  {
    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
  }
}
