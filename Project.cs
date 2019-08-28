using System;

namespace Legos
{
  public class Car
  {
    public string color { get; set; }
    public string manufacturer { get; set; }
  }

  public class SaloonCar: Car
  {
    public SaloonCar(int _numberOfSeats) {
      this.numberOfSeats = _numberOfSeats;
    }

    public SaloonCar(int _numberOfSeats, string _manufacturer) {
      this.numberOfSeats = _numberOfSeats;
      this.manufacturer = _manufacturer;
    }

    public SaloonCar(int _numberOfSeats, string _manufacturer, string _color) {
      this.numberOfSeats = _numberOfSeats;
      this.manufacturer = _manufacturer;
      this.color = _color;
    }
    public int numberOfSeats {get;set;}
  }
}