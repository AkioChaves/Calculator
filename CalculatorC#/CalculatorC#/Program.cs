using CalculatorC_.Properties;
using System;
class Program
{
    static void Main(string[] args)
    {
        Function function = new Function();

        Console.WriteLine(function.Text());
        function.number1 = float.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine(function.Text());
        function.functions = Console.ReadLine();
        Console.Clear();
        Console.WriteLine(function.Text());
        function.number2 = float.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine(function.Text());
        function.Calculator(function.functions);
        Console.ReadLine();
        Console.Clear();

        while (!function.terminada)
        {
            function.functions = null;
            function.number2 = 0;
            Console.WriteLine(function.Text());
            function.functions = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(function.Text());
            function.number2 = float.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(function.Text());
            function.Calculator(function.functions);
            Console.ReadLine();
            Console.Clear();
        }
    }
}