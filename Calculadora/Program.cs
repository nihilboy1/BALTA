using System;


namespace Calculator
{
    class Program{
        static void Main(string[] args){
         
            (float v1, float v2, short operationType) = Menu();

            Console.WriteLine($"{operationType}, {v1}, {v2}");
            
        }

        static (float v1, float v2, short operationType) Menu(){
            Console.WriteLine("Informe o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o tipo de operação: ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            short operationType = short.Parse(Console.ReadLine());
            return (v1, v2, operationType);
        }

        static void Soma(float v1, float v2){
            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da operação é: {resultado}");
            Console.ReadKey();
        }

        static void Sub(float v1, float v2){
            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da operação é: {resultado}");
            Console.ReadKey();
        }

        static void Divisao(float v1, float v2){
            
            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da operação é: {resultado}");
            Console.ReadKey();
        }

        static void Multi(float v1, float v2){
            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da operação é: {resultado}");
            Console.ReadKey();
        }
    }
}