using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamaliev2Variant
{
    class Program
    {
        static int GetMax(int[] mass)
        {
            int max = mass[0];
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] > max)
                {
                    max = mass[i];
                }
            }
            return max;
        }

        static int SumEven(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    count += array[i];
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int[] array = { 2, 2, 5, 6, 8, 9 };
            Console.WriteLine("Наибольшое значение из массива = " + GetMax(array));
            int[] arrayChetnie = { 2, 5, 6, 1, 1 };
            Console.WriteLine("Сумма всех четных чисел в массиве = " + SumEven(arrayChetnie));
        }
    }
}
