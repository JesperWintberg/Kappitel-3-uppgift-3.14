using System;
using System.Globalization;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut Gymnasiet?");
            Console.WriteLine("Svara med J eller N || J = ja  N = nej");
            string skola = Console.ReadLine();
            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());

            if (skola == "J" && ålder < 22)
            {
                Console.WriteLine("Vi vill gärna anställa dig");
            }

            else
            {
                Console.WriteLine("Vi letar tyvärr efter\r\nannan personal just nu");
            }
        }
    }
}
