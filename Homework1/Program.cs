using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как Вас зовут?");
            var name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}! Сегодня {DateTime.Now}."); ;
        }
    }
}
