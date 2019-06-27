using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//8.	 Даны объемы и массы двух тел из разных материалов. Материал какого из тел имеет большую плотность?

namespace HW_2._8_25._06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите объем v1:");
            var volume1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите объем v2:");
            var volume2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите массу тела m1:");
            var mass1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите массу тела m2:");
            var mass2 = Convert.ToDouble(Console.ReadLine());

            var density1 = mass1 / volume1;
            var density2 = mass2 / volume2;
            
            Console.Write("Плотность первого тела: ");
            Console.WriteLine(density1);
            Console.Write("Плотность второго тела: ");
            Console.WriteLine(density2);

            if (density1 > density2) Console.WriteLine("Материал первого тела имеет большую плотность, чем материал второго.");
            else Console.WriteLine("Материал второго тела имеет большую плотность, чем материал первого.");
            Console.ReadKey();
        }
    }
}
