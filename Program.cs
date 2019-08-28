using System;

namespace Legos
{
  class Program
  {
    static void Main(string[] args)
    {
      var worker = new FactoryWorker();
      Console.WriteLine(worker.addNumbers(4, 5));
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
