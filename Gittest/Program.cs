using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Gittest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // test
            Console.WriteLine("FEL");

            // LÖS


            Console.WriteLine(" Hallå jonte");

            string head1 = " 0 ";
            string body1 = "!T!";
            string legs1 = "/  \\";
            string legs2 = " | ";
            string numberOfSpaces = "";
            bool legsShouldPrint = true;
            Console.WriteLine(head1);
            Console.WriteLine(body1);
            for (int i = 0; i < 72; i++)
            {
                Console.Clear();
                Console.WriteLine(" " + head1);
                Console.WriteLine(" " + body1);
                if (legsShouldPrint)
                {
                    Console.WriteLine(legs1);
                }
                else
                {
                    Console.WriteLine(legs2);
                }
                legsShouldPrint = !legsShouldPrint;
                Thread.Sleep(80);
            }
            Console.ReadLine();


        }
    }
}
