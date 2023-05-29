using System;
using System.Threading;

namespace Cronometro
{
    class Program{

        static void Main(string[] args){
            int waitTime = Menu();
            Start(waitTime);
        }


        static int Menu(){
            Console.WriteLine("Informe o tempo que deseja esperar (Em segundos): ");
            int waitTime =  int.Parse(Console.ReadLine());
            return waitTime;
        }



        static void Start(int time){
         
            int currentTime = time;
            while(currentTime >= 0)
            {
                Console.Clear();
                Console.WriteLine($"Aguardando {time} segundos");
                Console.WriteLine(currentTime);
                currentTime--;
                Thread.Sleep(1000);
            }

            Console.Clear();
            Thread.Sleep(1500);
            Console.WriteLine("Contagem finalizada.");
            int waitTime = Menu();
            Start(waitTime);
        }
    }
}