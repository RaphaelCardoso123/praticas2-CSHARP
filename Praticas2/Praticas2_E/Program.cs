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
            IShape s1 = new Circle() { Radius = 3.0, Color = Color.Green };
            IShape s2 = new Rectangle() { Width = 55, Height = 4.5, Color = Color.Black};

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.ReadLine();
        }
    }
}
