using Temperature;
using Xunit;

namespace TemperatureTests;

public class UnitTest
{
  [Fact]
  public void Given0CelciusOutput32Fahrenheit()
  {
    Conversion conversion = new Conversion();
    double expected = 32;
    double actual = conversion.Convert(Conversion.ConversionMode.Celsius_to_Fahrenheit, 0);
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Given100CelciusOutput212Fahrenheit()
  {
    Conversion conversion = new Conversion();
    double expected = 212;
    double actual = conversion.Convert(Conversion.ConversionMode.Celsius_to_Fahrenheit, 100);
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Given0KelvinOutputMinus459Fahrenheit()
  {
    Conversion conversion = new Conversion();
    double expected = -459.67;
    double actual = conversion.Convert(Conversion.ConversionMode.Kelvin_to_Fahrenheit, 0);
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Given100KelvinOutputMinus279Fahrenheit()
  {
    Conversion conversion = new Conversion();
    double expected = -279.67;
    double actual = conversion.Convert(Conversion.ConversionMode.Kelvin_to_Fahrenheit, 100);
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Given32FahrenheitOutput0Celcius()
  {
    Conversion conversion = new Conversion();
    double expected = 0;
    double actual = conversion.Convert(Conversion.ConversionMode.Fahrenheit_to_Celsius, 32);
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Given100FahrenheitOutput37Celcius()
  {
    Conversion conversion = new Conversion();
    double expected = 37.78;
    double actual = conversion.Convert(Conversion.ConversionMode.Fahrenheit_to_Celsius, 100);
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Given0CelciusOutput273Kelvin()
  {
    Conversion conversion = new Conversion();
    double expected = 273.15;
    double actual = conversion.Convert(Conversion.ConversionMode.Celsius_to_Kelvin, 0);
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Given100CelciusOutput373Kelvin()
  {
    Conversion conversion = new Conversion();
    double expected = 373.15;
    double actual = conversion.Convert(Conversion.ConversionMode.Celsius_to_Kelvin, 100);
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Give0KelvinOutputMinus273Celcius()
  {
    Conversion conversion = new Conversion();
    double expected = -273.15;
    double actual = conversion.Convert(Conversion.ConversionMode.Kelvin_to_Celsius, 0);
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Give100KelvinOutputMinus173Celcius()
  {
    Conversion conversion = new Conversion();
    double expected = -173.15;
    double actual = conversion.Convert(Conversion.ConversionMode.Kelvin_to_Celsius, 100);
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Given0FahrenheitOutput255Kelvin()
  {
    Conversion conversion = new Conversion();
    double expected = 255.37;
    double actual = conversion.Convert(Conversion.ConversionMode.Fahrenheit_to_Kelvin, 0);
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Given100FahrenheitOutput310Kelvin()
  {
    Conversion conversion = new Conversion();
    double expected = 200.93;
    double actual = conversion.Convert(Conversion.ConversionMode.Fahrenheit_to_Kelvin, 100);
    Assert.Equal(expected, actual);
  }
}
