using CalculatorLibrary;

class Program
{
    static void Main()
    {
        ICalculator calc = new Calculator();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Console Calculator ===");
            Console.WriteLine("1: Add");
            Console.WriteLine("2: Subtract");
            Console.WriteLine("3: Multiply");
            Console.WriteLine("4: Divide");
            Console.WriteLine("5: Power");
            Console.WriteLine("6: Square Root");
            Console.WriteLine("7: Sin (radians)");
            Console.WriteLine("8: Cos (radians)");
            Console.WriteLine("9: Tan (radians)");
            Console.WriteLine("10: Log");
            Console.WriteLine("11: Factorial");
            Console.WriteLine("12: Degrees to Radians");
            Console.WriteLine("13: Radians to Degrees");
            Console.WriteLine("0: Exit");
            Console.Write("Choose an option: ");

            var choice = Console.ReadLine();
            if (choice == "0") break;

            try
            {
                switch (choice)
                {
                    case "1":
                        var (a1, b1) = ReadTwoInts();
                        Console.WriteLine($"Result: {calc.Add(a1, b1)}");
                        break;
                    case "2":
                        var (a2, b2) = ReadTwoInts();
                        Console.WriteLine($"Result: {calc.Subtract(a2, b2)}");
                        break;
                    case "3":
                        var (a3, b3) = ReadTwoInts();
                        Console.WriteLine($"Result: {calc.Multiply(a3, b3)}");
                        break;
                    case "4":
                        var (a4, b4) = ReadTwoInts();
                        Console.WriteLine($"Result: {calc.Divide(a4, b4)}");
                        break;
                    case "5":
                        var (baseNum, exponent) = ReadTwoDoubles();
                        Console.WriteLine($"Result: {calc.Power(baseNum, exponent)}");
                        break;
                    case "6":
                        Console.Write("Enter number: ");
                        double sq = double.Parse(Console.ReadLine()!);
                        Console.WriteLine($"Result: {calc.SquareRoot(sq)}");
                        break;
                    case "7":
                        Console.Write("Enter radians: ");
                        double rad1 = double.Parse(Console.ReadLine()!);
                        Console.WriteLine($"Result: {calc.Sin(rad1)}");
                        break;
                    case "8":
                        Console.Write("Enter radians: ");
                        double rad2 = double.Parse(Console.ReadLine()!);
                        Console.WriteLine($"Result: {calc.Cos(rad2)}");
                        break;
                    case "9":
                        Console.Write("Enter radians: ");
                        double rad3 = double.Parse(Console.ReadLine()!);
                        Console.WriteLine($"Result: {calc.Tan(rad3)}");
                        break;
                    case "10":
                        Console.Write("Enter positive number: ");
                        double logVal = double.Parse(Console.ReadLine()!);
                        Console.WriteLine($"Result: {calc.Log(logVal)}");
                        break;
                    case "11":
                        Console.Write("Enter integer: ");
                        int fact = int.Parse(Console.ReadLine()!);
                        Console.WriteLine($"Result: {calc.Factorial(fact)}");
                        break;
                    case "12":
                        Console.Write("Enter degrees: ");
                        double deg = double.Parse(Console.ReadLine()!);
                        Console.WriteLine($"Result: {calc.DegreesToRadians(deg)} radians");
                        break;
                    case "13":
                        Console.Write("Enter radians: ");
                        double rad4 = double.Parse(Console.ReadLine()!);
                        Console.WriteLine($"Result: {calc.RadiansToDegrees(rad4)} degrees");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }

    static (int, int) ReadTwoInts()
    {
        Console.Write("Enter first integer: ");
        int a = int.Parse(Console.ReadLine()!);
        Console.Write("Enter second integer: ");
        int b = int.Parse(Console.ReadLine()!);
        return (a, b);
    }

    static (double, double) ReadTwoDoubles()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine()!);
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine()!);
        return (a, b);
    }
}
