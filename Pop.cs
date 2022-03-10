using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanyaCSharp
{
    internal class pop
    {
        public static int Pop(int num, int[] array)
        {
            int a = array[num - 1];
            int[] arra = new int[array.Length - 1];
            for (int i = 0; i < arra.GetLength(0); i++)
                arra[i] = array[i];
            var str = string.Join(" ", arra);
            Console.WriteLine(str);
            return a;
        }
    }
}
/*
int num = 10;
int[] arr = new int[num];
Random random = new Random();

for (int i = 0; i < arr.GetLength(0); i++)  
   arr[i] = random.Next(12);

var stri = string.Join(" ", arr);
Console.WriteLine(stri);
var str = string.Join(" ", "Удалённый элемент: " + (pop.Pop(num, arr)));
Console.WriteLine(str);
*/