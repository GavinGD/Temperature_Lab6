namespace TemperatureWeb.Models;

public class TemperatureModel
{
  public string? tempTo { get; set; }
  public string? tempFrom { get; set; }
  public double temp { get; set; }
}

public enum Temperatures {
  Celcius,
  Fahrenhiet,
  Kelvin
}