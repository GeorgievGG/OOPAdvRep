using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.GenericBox
{
    class Controller
    {
        static void Main()
        {
            var incomingLines = int.Parse(Console.ReadLine());
            var strs = new List<double>();
            for (int i = 0; i < incomingLines; i++)
            {
                var input = double.Parse(Console.ReadLine());
                strs.Add(input);
            }
            //var indexes = Console.ReadLine().Split().Select(int.Parse).ToList();
            //Box<int>.Swap(boxes, indexes);
            var comparedElement = double.Parse(Console.ReadLine());
            //foreach (var bx in boxes)
            //{
            //    Console.WriteLine(bx.ToString());
            //}
            Console.WriteLine(Box<double>.Count(strs, comparedElement));
        }
    }
}
