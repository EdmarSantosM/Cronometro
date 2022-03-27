using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Start(6);
        }

         static void Menu()

        {
            System.Console.Clear();
            System.Console.WriteLine();
            System.Console.WriteLine(" S = Segundos ");
            System.Console.WriteLine(" M = Minutos ");
            System.Console.WriteLine(" E = Sair ");
            System.Console.WriteLine(" Quanto tempo deseja contar? ");
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
