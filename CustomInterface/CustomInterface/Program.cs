using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interfaces *****\n");

            Hexagon hex = new Hexagon();
            Console.WriteLine("Points: {0}", hex.Points);

            Console.ReadLine();
        }
    }
}
