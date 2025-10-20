namespace OOP_Intro;

internal class Car
{
      public string brand;
      public string model;
      public int year;
      public string color;
      private int _wheelCount;
      public int WheelCount
      {
            get { return _wheelCount; }
            set
            {
                  if (value != 3 && value != 4)
                  {
                        Console.WriteLine("Wheel count must be either 3 or 4.");
                        return;
                  }
                  _wheelCount = value;
            }
      }
      public string Type { get; }
      private double _price;
      public double Price
      {
            set
            {
                  if (value < 0)
                  {
                        Console.WriteLine("Price cannot be negative.");
                        return;
                  }
                  _price = value;
            }
      }

      public Car(string brand, string model, int year, string color, int wheelCount, double price)
      {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.color = color;
            _wheelCount = wheelCount;
            // this.price = price;
      }

      public Car()
      {
            brand = "Tesla";
            model = "Model S";
            year = 2023;
            color = "Red";
            _wheelCount = 4;
            // price = 79999.99;
      }


      // public int GetWheelCount()
      // {
      //       return _wheelCount;
      // }

      // public void SetWheelCount(int wheelCount)
      // {
      //       if (wheelCount != 3 && wheelCount != 4)
      //       {
      //             System.Console.WriteLine("Wheel count must be either 3 or 4.");
      //             return;
      //       }
      //       _wheelCount = wheelCount;
      // }
      public void GetInfo()
      {
            System.Console.WriteLine($"Brand: {brand}");
            System.Console.WriteLine($"Model: {model}");
            System.Console.WriteLine($"Year: {year}");
            System.Console.WriteLine($"Color: {color}");
            // System.Console.WriteLine($"Price: {price}");
            System.Console.WriteLine($"Wheel Count: {_wheelCount}");
      }

}