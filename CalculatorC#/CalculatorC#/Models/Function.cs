namespace CalculatorC_.Models
{
    internal class Function
    {
        public bool terminada { get; set; } = false;
        public float number1 { get; set; }
        public float number2 { get; set; }
        public string functions { get; set; }

        public void Calculator(string function)
        {
            switch (function)
            {
                case "+":
                    number1 = number1 + number2;
                    Console.WriteLine(number1);
                    break;
                case "-":
                    number1 = number1 - number2;
                    Console.WriteLine(number1);
                    break;
                    case "*":
                    number1 = number1 * number2;
                    Console.WriteLine(number1);
                    break;
                    case "/":
                    number1 = number1 / number2;
                    Console.WriteLine(number1);
                    break;
                case "+/-":
                    if (number1 < 0)
                    {
                        number1 = +number1;
                        Console.WriteLine(number1);
                    }
                    else
                    {
                        number1 = -number1;
                        Console.WriteLine(number1);
                    }
                    break;
                default:
                    Console.WriteLine("This function doesn't exist.");
                    break;
            }
        }
    }
}
