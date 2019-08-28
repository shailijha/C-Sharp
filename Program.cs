using System;

namespace Legos
{
  class Program
  {
    static void Main(string[] args)
    {
      var worker = new FactoryWorker();
      worker.count(4);
      worker.count(5);

      worker.count(4.5f);
    }

  }

  public class FactoryWorker
  {
    public FactoryWorker()
    {

    }

    public void count(int number)
    {
      if (Total == null)
        Total = 0;
      Total += Convert.ToSingle(number);
      Console.WriteLine(Total.ToString());
    }

    public void count(float number)
    {
      Total += number;
      Console.WriteLine(Total.ToString());
    }

    public float Total { get; set; }
  }

}
