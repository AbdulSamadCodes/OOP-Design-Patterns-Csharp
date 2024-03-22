
class Vehicle
{
  public string vehicleName;  
   public Vehicle(string vehicleName)
   {
     this.vehicleName = vehicleName;
   }  
   public void Accelerate()
   {
     Console.WriteLine($"The vehicle {this.vehicleName} is  accelerating");
   }

   public void Reverse()
   {
     Console.WriteLine($"The vehicle {this.vehicleName} is  reversing");
   }
}

class Car : Vehicle
{
    public Car(string vehicleName) : base(vehicleName)
    {
      this.vehicleName = vehicleName;           
    }  
}

class Truck : Vehicle
{
    public Truck(string vehicleName) : base(vehicleName)
    {
      this.vehicleName = vehicleName;           
    }
}

class Inheritance
{
  public static void Main(string [] args)
  {
    Car corolla = new Car("Corolla");
    corolla.Accelerate();
    corolla.Reverse();       
  }
}