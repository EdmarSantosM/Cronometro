using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

         static void Menu()

        {
            System.Console.Clear();
            System.Console.WriteLine();
            System.Console.WriteLine(" S = Segundos => '10s' segundos ");
            System.Console.WriteLine(" M = Minutos => '1m' minutos ");
            System.Console.WriteLine(" E = Sair ");
            System.Console.WriteLine("");
            System.Console.Write(" Quanto tempo deseja contar? ");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1,1));
            System.Console.WriteLine(data);
            System.Console.WriteLine(type);
        }

        static void Start( int time)
        {
           
            int currentTime = 0;

            while(currentTime != time)
            {
                System.Console.Clear();
                currentTime++;
                System.Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            System.Console.Clear();
            System.Console.WriteLine("Cronômentro finalizado !");
            Thread.Sleep(2500);
        }
    }
}
