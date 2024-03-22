//An interface is a contract that specifies the capabilities a class should provide

public interface ICalculator
  {
    //Calculator interface has define a basic implementation of a calculator.Now classes which will implement this interface will have to give their implementation of this interface
     double Addition(double num1 , double num2);
     double Subtraction(double num1 , double num);
     double Multiplication(double num1 , double num);
     double Division(double num1 , double num);
  }  

  class ArithmeticCalculator : ICalculator
  {
    public double Addition(double num1 , double num2)
    {
       double result = num1 + num2;
       return result;
    }

    public double Subtraction(double num1 , double num2)
    {
       double result = num1 - num2;
       return result;
    }

    public double Multiplication(double num1 , double num2)
    {
       double result = num1 * num2;
       return result;
    }

    public double  Division(double num1 , double num2)
    {
       double result = num1 / num2;
       return result;
    }

 }

class Program
{
  public static void Main(string [] args)
  {
     ArithmeticCalculator calc = new ArithmeticCalculator();

     Console.WriteLine(calc.Addition(10 , 18.9));
     Console.WriteLine(calc.Subtraction(378 , 188));
     Console.WriteLine(calc.Multiplication(10 , 7.5));
     Console.WriteLine(calc.Addition(10 , 18.9));
  }

}
