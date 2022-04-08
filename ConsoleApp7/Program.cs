using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    internal class Program
    {

        static int[] GetArrayFromConsole()
        {
            var result = new int[5];
            
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"Введите элемент массива номер {i + 1}");
                result[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.WriteLine();
            return result;
        }
        static int[] SortArray(int[] result)
        {
            Console.WriteLine("Сортировка введенного массива");
            int t = 0;
            for (int j = 0; j < result.Length; j++)
            {
                for (int i = j + 1; i < result.Length; i++)
                    if (result[j] > result[i])
                    {
                        t = result[j];
                        result[j] = result[i];
                        result[i] = t;
                    }
            }
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
            return result;
        }
        

        public static void Main(string[] args)
        {            
            var arrayFromConsole = GetArrayFromConsole();
            SortArray(arrayFromConsole);

            Console.ReadKey();
        }
    }
}
