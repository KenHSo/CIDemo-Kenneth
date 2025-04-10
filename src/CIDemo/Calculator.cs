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

    double ICalculator.Power(double a, double b)
    {
        return Math.Pow(a, b);
    }

    double ICalculator.SquareRoot(double a)
    {
        if (a < 0)
            throw new ArgumentException("Cannot take the square root of a negative number.");

        return Math.Sqrt(a);
    }
}

