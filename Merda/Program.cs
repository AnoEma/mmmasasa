using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merda
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] num = new[] { 1, 2, 3, 4, 5 };
            // foreach(var nu in num)
            // {
            //     Console.WriteLine(nu);
            // }
            // Console.ReadLine();

            // int[] nums = new[] { 5, 6, 9, 4, 8, 98, 25, 35 };
            //
            // int sum = 0;
            //
            // foreach (var nn in nums)
            // {
            //     sum = sum + nn;
            // }
            // Console.WriteLine(sum); 

            //int[] mun = new[] { 4, 53, 6, 4, 5, 9, 8 };

            //foreach (var i in mun)
            //{
            //    Console.Write( i + " ");
            //}
            //Console.WriteLine();

            int[] mon = new[] { 2, 6, 5, 4, 8, 65, 9, 98, 23, 64, 78 };
            
            foreach (var mi in mon)
            {
                if (mi % 2 == 0)
                {
                    Console.Write(mi+ " ");
                }
                
               
            }
            Console.WriteLine();
            foreach(var mi in mon)
            {
                if (mi % 2 != 0)
                {
                    Console.Write(mi + " ");
                }
            }

            Console.ReadLine();

        }
    }
}
