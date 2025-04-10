namespace CIDemo;

public interface ICalculator
{
        int Add(int a, int b); // Adds two integers
        int Subtract(int a, int b); // Subtracts two integers
        int Multiply(int a, int b); // Multiplies two integers
        double Divide(int a, int b); // Divides two integers, returns a double
        double Power(double a, double b);
        double SquareRoot(double a);
        double Sin(double angleInRadians);
        double Cos(double angleInRadians);
        double Tan(double angleInRadians);
        double Log(double value);
        double Factorial(int number);
        double DegreesToRadians(double degrees);
        double RadiansToDegrees(double radians);

}
