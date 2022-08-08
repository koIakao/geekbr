using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace task4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите числа через enter: ");
            int[] array = new int[3];
 
            for (int i = 0; i < 3; i++)
                array[i] = Convert.ToInt32(Console.ReadLine());
 
            Console.WriteLine("Максимальное число: " + Max(array).ToString());
            Console.ReadLine();
        }
        static int Max(int[] array)
        {
            int max;
            return max = array.Max();
        }
    }
}