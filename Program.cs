using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prost_method
{
    internal class Program
    {
        static bool arif(int _chislo)
        {

            for (int i = 2; i < _chislo; i++) // В For выполняется проверка числа на простоту
            {
                if (_chislo % i == 0)
                {
                    return true; // Если число простое, то возвращается true
                }
            }
            return false; // Если число не простое, то возвращается false
        }


        static void Main(string[] args)
        {
            int _chislo = Convert.ToInt32(Console.ReadLine()); // Ввод числа пользователем
            bool _result;

            if (_chislo < 0) // Если число отрицательное, то оно будет возведено в модуль и все последующие операции продолжатся
            {
                Console.WriteLine("Введёное число является отрицательным и будет преобразовано в положительное: " + Math.Abs(_chislo));
                _chislo = Math.Abs(_chislo);

                _result = arif(_chislo); // В переменную _result присваивается значение, которое вернул метод arif

                if (_result)
                {
                    Console.WriteLine("Число НЕ является простым");
                }
                else
                {
                    Console.WriteLine("Число ЯВЛЯЕТСЯ простым");
                }
            }


            else if (_chislo == 0) // Если число равняется нулю, то программа завершит свою работу без последующих операций над этим числом
            {
                Console.WriteLine("Введёное число равняется нулю, операция не будет корректной");
            }


            else
            {
                _result = arif(_chislo); // В переменную _result присваивается значение, которое вернул метод arif

                if (_result) // Проверка значения переменной и итоговый результат
                {
                    Console.WriteLine("Число НЕ является простым");
                }


                else
                {
                    Console.WriteLine("Число ЯВЛЯЕТСЯ простым");
                }
            }

        }
    }
}
