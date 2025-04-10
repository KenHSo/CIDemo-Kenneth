namespace CIDemo;

public class Calculator : ICalculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public double Divide(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero.");

        return (double)a / b;
    }

    public double Power(double a, double b)
    {
        return Math.Pow(a, b);
    }

    public double SquareRoot(double a)
    {
        if (a < 0)
            throw new ArgumentException("Cannot take the square root of a negative number.");

        return Math.Sqrt(a);
    }

    public double Sin(double angleInRadians)
    {
        return Math.Sin(angleInRadians);
    }

    public double Cos(double angleInRadians)
    {
        return Math.Cos(angleInRadians);
    }

    public double Tan(double angleInRadians)
    {
        return Math.Tan(angleInRadians);
    }

    public double Log(double value)
    {
        if (value <= 0)
            throw new ArgumentException("Logarithm undefined for non-positive values.");
        return Math.Log(value);
    }

    public double Factorial(int number)
    {
        if (number < 0)
            throw new ArgumentException("Factorial is undefined for negative numbers.");
        if (number == 0 || number == 1)
            return 1;

        double result = 1;
        for (int i = 2; i <= number; i++)
            result *= i;

        return result;
    }

    public double DegreesToRadians(double degrees)
    {
        return degrees * (Math.PI / 180);
    }

    public double RadiansToDegrees(double radians)
    {
        return radians * (180 / Math.PI);
    }
}

