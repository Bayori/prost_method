using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace prost_method
{
    internal class Program
    {
        static bool isPrime(int _number) // Метод проверки числа на простоту
        {
            for (int i = 2; i <= Math.Sqrt(_number); i++)
            {
                if (_number % i == 0)
                {
                    return false; // Число составное             
                }
            }
            return true; // Число простое
        }

        static void Main(string[] args)
        {
            int _number = Convert.ToInt32(Console.ReadLine());

            if (_number < 0) // Преобразование отрицательного числа в положительное
            {
                _number = Math.Abs(_number);
                Console.WriteLine("Введёное число было преобразовано в положительное");
            }
            else if (_number == 0) // Завершение программы, если _number == 0
            {
                Console.WriteLine("0 недопустим к вводу");
                return;
            }

            if (isPrime(_number)) // Проверка и вывод результата напрямую из метода isPrime
            {
                Console.WriteLine("Это простое число");
            }
            else
            {
                Console.WriteLine("Это составное число");
            }
        }
    }
}
