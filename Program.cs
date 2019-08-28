using System;

namespace Legos
{
  class Program
  {
    static void Main(string[] args)
    {
      var man = new Man();
      var cart = new Cart();
      var alien = new Alien();

    }
  }

  public class GeneralObject
  {
    public GeneralObject()
    {

    }

    public bool moves { get; set; }
    public string color { get; set; }
  }

  public class Human : GeneralObject
  {
    public Human()
    {

    }

    public string name { get; set; }
  }

  public class Man : Human
  {
    public Man()
    {

    }
    public string name { get; set; }
  }

  public class Woman : Human
  {
    public Woman()
    {

    }
    public string name { get; set; }
  }

  public class Cart : GeneralObject
  {
    public Cart()
    {

    }
    public string manufacturer { get; set; }
  }

  public class Alien : GeneralObject
  {
    public Alien()
    {

    }
    public string planet { get; set; }
  }

  /*public class BullDozer
  {
    public BullDozer(string _color, string _size)
    {
      this.color = _color;
      this.size = _size;
    }

    public string color { get; set; }
    public string size { get; set; }
  }*/
}
