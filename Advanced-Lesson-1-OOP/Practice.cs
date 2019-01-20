using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
    public class Practice
    {
        /// <summary>
        /// A.L1.P1. Вывести матрицу (двумерный массив) отображающую площадь круга, 
        /// квадрата, равнобедренного треугольника со сторонами (радиусами) от 1 до 10.
        /// </summary>
        public static void A_L1_P1_OOP()
        {
            Random rnd = new Random();
            Figure[,] firure_masive = new Figure[3,10]; 

            for (int i = 0; i < firure_masive.GetLength(0); i++)
            {
                for (int j = 0; j < firure_masive.GetLength(1); j++)
                {
                    if (i == 0)
                        firure_masive[i, j] = new Square(rnd.Next(1, 10));
                    else if (i == 1)
                    {
                        firure_masive[i, j] = new Triangle(rnd.Next(1, 10), rnd.Next(1,10));
                    }
                    else
                    {
                        firure_masive[i, j] = new Circle(rnd.Next(1, 10));
                    }
                }
            }
            for (int i = 0; i < firure_masive.GetLength(0); i++)
            {
                for (int j = 0; j < firure_masive.GetLength(1); j++)
                {
                    Console.Write($"{firure_masive[i, j].Area():##.###} ");
                }
                Console.WriteLine();
            }
        }


        /// <summary>
        /// A.L1.P6. Перегрузить следующие операторы для Transport <>,==/!= на базе физических размеров. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P6_OperatorsOverloading()
        {
        }

        /// <summary>
        /// A.L1.P7.Перегрузить операторы<>,==/!=  для продаваемых вещей в интернет магазине на базе их цены. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P7_OperatorsOverloading()
        {            
        }        
    }

     class Figure
    {
        protected double baseSide;

        public virtual double Area()
        {
            return baseSide;
        }       
    }

    class Square : Figure
    {
        public Square(double basa)
        {
            this.baseSide = basa;
        }

        public override double Area()
        {
            return baseSide * baseSide;
        }
    }

    class Triangle : Figure  //  равнобедренный
    {
        double basуOfTriangle;

        public Triangle(double side, double basa)
        {
            baseSide = side;   // высота
            basуOfTriangle = basa;   //  основание
        }

        public override double Area()
        {
            return  baseSide * basуOfTriangle/2;
        }
    }

    class Circle : Figure
    {
        public Circle(double radius)
        {
            this.baseSide = radius;
        }

        public override double Area()
        {
            return Math.PI * baseSide * baseSide;
        }
    }




}


