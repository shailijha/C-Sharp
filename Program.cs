using System;

namespace Legos
{
  class Program
  {
    static void Main(string[] args)
    {
      //var worker = new FactoryWorker();
      //Console.WriteLine(worker.addNumbers(4, 5));
      SaloonCar car1 = new SaloonCar(2);
      SaloonCar car2 = new SaloonCar(3, "Nissan");
      SaloonCar car3 = new SaloonCar(4, "Ford", "purple");
      Console.WriteLine(car3.numberOfSeats);
      Console.WriteLine("Car3 color is " + car3.color + " and its manufacturer is " + car3.manufacturer);
    }

  }

  public class FactoryWorker
  {
    public FactoryWorker()
    {

    }

    public int addNumbers(int num1, int num2)
    {
      var result = num1 + num2;
      result += 100; result -= 100;
      return result;
    }
  }

}
