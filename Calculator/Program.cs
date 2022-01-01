using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в калькулятор простых чисел!" +
                "\nДля запуска необходимо следовать инструкции и нажать Enter после каждого пункта:" +
                "\n1. Выбрать предложенную операцию +, -, / или * " +
                "\n2. Ввести первую цифру" +
                "\n3. Ввести вторую цифру");
            
            Console.WriteLine("\nВыберите арифметическую операцию, для этого введите на клавиатуре на выбор:  +, -, / или * ");
            string flag = Console.ReadLine();
            Console.WriteLine("Введите первую цифру");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую цифру");
            int secondNum = int.Parse(Console.ReadLine());

            var result = 0;
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

            Console.WriteLine("{0}{1}{2}={3}", firstNum, flag,  secondNum, result);

            Console.ReadLine();





















            /*int num1 = int.Parse(Console.ReadLine());
            string sign = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            var result = 0;
            if (sign == "+")
            {
                result = num1 + num2;
            }
            else if (sign == "-")
            {
                result = num1 - num2;
            }
            else if (sign == "*")
            {
                result = num1 * num2;
            }
            else if (sign == "/")
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Wrong operation sign ...");
            }

            Console.WriteLine("{0}{1}{2}={3}", num1, sign, num2, result);

            Console.ReadLine();*/



        }


    }


}

