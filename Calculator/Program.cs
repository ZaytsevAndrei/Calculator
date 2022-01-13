using System;

namespace Calculator
{
    class Program
    {
        private static double firstNum;
        private static double secondNum;

        static void Main(string[] args)
        {
            try
            {
                Calculate();
            }
            catch (Exception e)
            {
                RestartOnException(e);
            }
        }

        private static void RestartOnException(Exception e)
        {
            Console.WriteLine("Во время выполения произошла ошибка: {0}", e.Message);
            Console.WriteLine("Нажмите любую клавишу, чтобы перезапустить программу");
            Console.ReadKey();
            Calculate();
        }

         
        private static void Calculate()
        {
            Console.WriteLine("\nДобро пожаловать в калькулятор простых чисел!" +
                            "\nДля запуска необходимо следовать инструкции и нажать Enter после каждого пункта:" +
                            "\n1. Выбрать одну из операций +, -, / или * " +
                            "\n2. Ввести первую цифру" +
                            "\n3. Ввести вторую цифру");

            Console.WriteLine("\nВыберите арифметическую операцию");
            string flag = Console.ReadLine();
            Console.WriteLine("Введите первую цифру");
            firstNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вторую цифру");
            secondNum = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            if (flag == "+")
            {
                result = firstNum + secondNum;
            }

            else if (flag == "-")
            {
                result = firstNum - secondNum;
            }

            else if (flag == "/")
            {
                result = firstNum / secondNum;
            }

            else if (flag == "*")
            {
                result = firstNum * secondNum;
            }
            else
            {
                Console.WriteLine("Выбрана неправильная операция ...");
            }

            Console.WriteLine("{0}{1}{2}={3}", firstNum, flag, secondNum, result);

            Console.ReadLine();
        }
    }
}
