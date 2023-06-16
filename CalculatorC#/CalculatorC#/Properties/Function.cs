using System.Globalization;
using System.Text;

namespace CalculatorC_.Properties
{
    internal class Function
    {
        public string functions { get; set; }
        public float number1 { get; set; }
        public float number2 { get; set; }
        public bool terminada { get; set; } = false;

        public void Calculator(string functions)
        {
            switch (functions)
            {
                case "+":
                    number1 = number1 + number2;
                    Console.WriteLine($"Resultado é: {number1.ToString(CultureInfo.InvariantCulture)}");
                    break;
                case "-":
                    number1 = number1 - number2;
                    Console.WriteLine($"Resultado é: {number1.ToString(CultureInfo.InvariantCulture)}");
                    break;
                case "*":
                    number1 = number1 * number2;
                    Console.WriteLine($"Resultado é: {number1.ToString(CultureInfo.InvariantCulture)}");
                    break;
                case "/":
                    number1 = number1 / number2;
                    Console.WriteLine($"Resultado é: {number1.ToString(CultureInfo.InvariantCulture)}");
                    break;
                default:
                    Console.WriteLine("This function doesn't exist.");
                    break;
            }
        }

        public string Text()
        {
            var text = new StringBuilder();
            text.AppendLine("Calculadora");
            text.Append("Digite o primeiro número: ");
            if(number1 != 0)
            {
                text.Append(number1.ToString(CultureInfo.InvariantCulture));
            }
            text.Append("\nDigite o operador(+, -, *, /): ");
            if (functions != null)
            {
                text.Append(functions);
            }
            text.Append("\nDigite o segundo número: ");
            if (number2 != 0)
            {
                text.Append(number2.ToString(CultureInfo.InvariantCulture));
            }

            return text.ToString();
        }
    }
}
