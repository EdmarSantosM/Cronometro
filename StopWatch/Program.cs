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
            System.Console.WriteLine(" ================================= ");
            System.Console.WriteLine("     Cronômetro  via Console ");
            System.Console.WriteLine(" ================================= ");
            System.Console.WriteLine();
            System.Console.WriteLine(" S = Segundos => '10s' segundos ");
            System.Console.WriteLine(" M = Minutos => '1m' minutos ");
            System.Console.WriteLine(" E = Sair ");
            System.Console.WriteLine("");
            System.Console.WriteLine(" ================================= ");
            System.Console.WriteLine("    Quanto tempo deseja contar? ");
            System.Console.WriteLine(" ================================= ");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1,1));
            int time = int.Parse(data.Substring(0,data.Length - 1));

           int multiplier = 1;

           if(type == 'm')
            multiplier = 60;

            if ( time == 0)
                System.Environment.Exit(0);

                PreStart(time * multiplier);


                

          
        }

        static void PreStart(int time)
        {
            System.Console.Clear();
            System.Console.WriteLine();
            System.Console.WriteLine(" Um ...");
            Thread.Sleep(1200);
            System.Console.WriteLine(" Dois ...");
            Thread.Sleep(1200);
            System.Console.WriteLine(" Três ...");
            Thread.Sleep(1200);
            System.Console.WriteLine(" Começa agora ...");
            Thread.Sleep(1500);

            Start(time);
        }
        static void Start( int time)
        {
           
            int currentTime = 0;

            while(currentTime != time)
            {
                System.Console.Clear();
                currentTime++;
                System.Console.Write($"\n\n...{currentTime} ");
                Thread.Sleep(1000);
            }

            System.Console.Clear();
            System.Console.WriteLine(" Cronômentro finalizado !");
            Thread.Sleep(2300);
            Menu();
        }
    }
}
