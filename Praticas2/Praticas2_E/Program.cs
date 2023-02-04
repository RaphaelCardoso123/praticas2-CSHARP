using System;
using Praticas2_E.Entities;
using Praticas2_E.Enums;
using Praticas2_E.Model.Entities;

namespace Praticas2_E
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Circle() { Radius = 2.0, Color = Color.White };
            Shape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black};

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.ReadLine();
        }
    }
}
