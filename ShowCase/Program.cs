using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConvertor inputConvertor = new InputConvertor();
                CalculatorEngine calculatorEngine = new CalculatorEngine();
                Console.WriteLine("Input 1st Number");
                double firstNumber = inputConvertor.ConvertInputToNumber(Console.ReadLine());
                Console.WriteLine("Input 2nd Number");
                double secondNumber = inputConvertor.ConvertInputToNumber(Console.ReadLine());
                Console.WriteLine("Type the Operation to perform");
                string operation = Console.ReadLine();
                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}