using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
            */

            Console.WriteLine("Вычисление объёма и площади поверхности куба \n");
            Console.WriteLine("Введите длину ребра куба:");
            double cubeEdge = Convert.ToDouble(Console.ReadLine());

            CalcCubeAreaAndVolume(cubeEdge, out double cubeArea, out double cubeVolume);

            if (cubeArea != -1 && cubeVolume != -1)
            {
                Console.WriteLine("\nПлощадь поверхности куба {0}, объём куба {1}.",
                                  cubeArea,
                                  cubeVolume);
            }
            else
            {
                Console.WriteLine("\nВведена недопустимая длина ребра");
            }
            Console.ReadKey();

        }
        static void CalcCubeAreaAndVolume(double edge, out double area, out double volume)
        // Вычисление площади поверхности и объёма куба по длине ребра
        {
            if (edge > 0)
            {
                area = 6 * edge * edge;
                volume = Math.Pow(edge, 3);
            }
            else
            {
                area = volume = -1;
            }

        }
    }
}
