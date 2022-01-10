using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Два треугольника заданы длинами своих сторон. Определить, площадь какого из них больше
            (создать метод для вычисления  площади  треугольника по длинам его сторон).
            Для решения задачи можно использовать формулу Герона.
            */

            Console.WriteLine("Сравнение площадей двух треугольников, заданных длинами сторон \n");
            Console.WriteLine("Последовательно введите длины сторон первого треугольника:");
            double triangle1EdgeA = Convert.ToDouble(Console.ReadLine());
            double triangle1EdgeB = Convert.ToDouble(Console.ReadLine());
            double triangle1EdgeC = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Последовательно введите длины сторон второго треугольника:");
            double triangle2EdgeA = Convert.ToDouble(Console.ReadLine());
            double triangle2EdgeB = Convert.ToDouble(Console.ReadLine());
            double triangle2EdgeC = Convert.ToDouble(Console.ReadLine());

            double triangle1Area = CalcTriangleArea(triangle1EdgeA, triangle1EdgeB, triangle1EdgeC);
            double triangle2Area = CalcTriangleArea(triangle2EdgeA, triangle2EdgeB, triangle2EdgeC);

            if (triangle1Area != -1 && triangle2Area != -1)
            {
                Console.WriteLine("\nПлощадь первого треугольника - {0}, площадь второго - {1}.",
                                  triangle1Area,
                                  triangle2Area);

                if (triangle1Area > triangle2Area)
                    Console.WriteLine("Площадь первого треугольника больше.");
                else if (triangle1Area < triangle2Area)
                    Console.WriteLine("Площадь второго треугольника больше.");
                else
                    Console.WriteLine("Площади треугольников равны.");
            }
            else
            {
                if (triangle1Area == -1)
                     Console.WriteLine("Длины сторон первой фигуры " +
                                       "недопустимы для треугольника");
                if (triangle2Area == -1)
                    Console.WriteLine("Длины сторон второй фигуры " +
                                      "недопустимы для треугольника");
            }
            Console.ReadKey();

        }
        static double CalcTriangleArea(double edgeA, double edgeB, double edgeC)
        // Вычисление площади треугольника по формуле Герона
        {
            if (edgeA > 0 && edgeB > 0 && edgeC > 0)
            {

                double semiPerimeter = (edgeA + edgeB + edgeC) / 2;
                if ((semiPerimeter - Math.Max(edgeA, Math.Max(edgeB, edgeC))) > 0)
                {

                    double area = Math.Sqrt(semiPerimeter *
                                            (semiPerimeter - edgeA) *
                                            (semiPerimeter - edgeB) *
                                            (semiPerimeter - edgeC));
                    return area;
                }
                else
                    // Возвращаемое значение -1 соответствует ошибке — случаю,
                    // когда сумма длин двух сторон меньше или равна длине третьей стороны
                    return -1;
            }
            else
            {
                // Возвращаемое значение -1 соответствует ошибке — случаю,
                // когда один или несколько аргументов неположительны
                return -1;
            }
        }
    }
}
