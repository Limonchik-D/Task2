using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{   /// <summary>
    /// Задание 2. Создать класс Прямоугольник. Функциональность класса обеспечить: приватными полями: длина, ширина; 
    /// конструкторами – без параметров и с параметрами; свойствами без валидации; методом для вывода информации; методами вычисления площади и периметра;
    /// включить валидацию в свойства для проверки корректности данных;
    /// </summary>
    internal class Rectangle
    {
        private double length;
        private double width;
        //Валидация
        public double Length
        {
            get { return length; }
            set
            {
                if (value >= 0)
                {
                    length = value;
                }
                else
                {
                    Console.WriteLine("Длина не может быть меньше или равна 0");
                }
            }
        }
        //Валидация
        public double Width
        {
            get { return width; }
            set
            {
                if (value >= 0)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Длина не может быть меньше или равна 0");
                }
                
            }
        }
        /// <summary>
        /// cБез параметров
        /// </summary>
        public Rectangle()
        {
            length = 1;
            width = 1;
        }
        /// <summary>
        /// С параметрами
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        /// <summary>
        /// свойства без валидации
        /// </summary>

        ///<summary>
        ///метод для вычисления площади
        ///</summary>
        public double Area()
        {
            return length * width;
        }
        /// <summary>
        /// Метод для вычисления периметра
        /// </summary>
        /// <returns></returns>
        public double Perimeter()
        {
            return 2 * (length + width);
        }
        /// <summary>
        /// Метод для вывода информации
        /// </summary>
        /// <returns></returns>
        public override string ToString() 
        {
            return $"Длина: {length}, ширина: {Width}, площадь: {Perimeter()}, периметр: {Perimeter()}";
        }
    }
       
    
}
