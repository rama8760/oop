using System;

class Car
{
   
    private string brand;
    private string model;
    private int year;

    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public int Year
    {
        get { return year; }
        set { year = value; }
    }


    public void Start()
    {
        Console.WriteLine("The car is starting");
    }

    public void Drive()
    {
        Console.WriteLine("The car is driving");
    }

    public void Stop()
    {
        Console.WriteLine("The car has stopped");
    }
}

class Program
{
    static void Main(string[] args)
    {
      
        Car car1 = new Car();
        car1.Brand = "Toyota";
        car1.Model = "Corolla";
        car1.Year = 2020;

        Car car2 = new Car();
        car2.Brand = "BMW";
        car2.Model = "X5";
        car2.Year = 2023;

     
        car1.Start();
        car1.Drive();
        car1.Stop();

        Console.WriteLine();

        car2.Start();
        car2.Drive();
        car2.Stop();

        Console.WriteLine("\nCar 1:");
        Console.WriteLine("Brand: " + car1.Brand);
        Console.WriteLine("Model: " + car1.Model);
        Console.WriteLine("Year: " + car1.Year);

        Console.WriteLine("\nCar 2 :");
        Console.WriteLine("Brand: " + car2.Brand);
        Console.WriteLine("Model: " + car2.Model);
        Console.WriteLine("Year: " + car2.Year);
    }
}

