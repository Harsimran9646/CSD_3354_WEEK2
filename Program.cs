using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0707995
{
    class Program
    {
        static void Main(string[] args)
        {
            var dogs = new List<string>();
            dogs.Add("bulldog");
            dogs.Add("collie");
            dogs.Add("pitbull");
            foreach (var dog in dogs)
            {
                Console.WriteLine(dog + " ");
            }
            Console.ReadLine();
            int[] a1 = new int[] { 1, 3, 5, 7, 7, 9, 11 };
            foreach (int i in a1)
            {
                Console.WriteLine(i + "");
            }
        } 

    }
}
