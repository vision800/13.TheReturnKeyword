using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.TheReturnKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Cube(5));
        }

        static int Cube(int n) { 
         int result = n*n*n;
            return result;
        }
    }
}
