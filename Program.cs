// See https://aka.ms/new-console-template for more information

using System;

namespace Exercício1
{
    class program
    {
        static void Main(string[] args)
        {
            DetalharData(); 
            CalcularDescontoInss();
        }

        public static void DoisProgramas()
        {
            
        }
        public static void DetalharData()
        {
            Console.WriteLine("Digite uma Data: ");
            DateTime data = DateTime.Parse(Console.ReadLine());

            if (data.DayOfWeek == DayOfWeek.Sunday)
            {
                DateTime HoraDomingo = DateTime.Now;
                string resultado = string.Format("{0:dddd} do mês de  {0:MMMM} ás {1:HH:mm}", data, HoraDomingo);
                Console.WriteLine(resultado);

            }
            else {
                string datanormal = string.Format("{0:dddd} do mês de  {0:MMMM}", data);
                Console.WriteLine(datanormal);
            }
        }

         public static void CalcularDescontoInss()
    {
        Console.WriteLine("Digite o seu salário: ");
        decimal salário =  decimal.Parse(Console.ReadLine());
         if (salário < 0)
            Console.WriteLine("Salário invalido!");

          else if(salário <= 1212)
         { 
            decimal porcentagem = 7.5M;
            decimal ValorInss = (salário / 100 )  * porcentagem;
            decimal NovoSalário = salário - ValorInss;
            Console.WriteLine($"Você pagará {ValorInss}R$ de taxa, e seu Salário final ficará a partir de agora {NovoSalário}R$ ");
         }
         else if (salário <= 2427) 
         {
            decimal porcentagem = 9;
        decimal  ValorInss = (salário / 100) * porcentagem;
           decimal NovoSalário = salário - ValorInss;
            Console.WriteLine($"Você pagará {ValorInss}R$ de taxa, e seu novo salário ficará a partir de agora {NovoSalário}R$");
         }
         else if (salário <= 3641)
         {
            decimal porcentagem = 12;
            decimal ValorInss = (salário / 100) * porcentagem;
            decimal NovoSalário = salário - ValorInss;
            Console.WriteLine($"Você pagará {ValorInss}R$ de taxa, e seu novo salário ficará a partir de agora {NovoSalário}R$ ");

         }
         else {
            decimal porcentagem = 14;
            decimal ValorInss = (salário / 100) * porcentagem;
            decimal NovoSalário = salário - ValorInss;
            Console.WriteLine($"Você pagará {ValorInss} de taxa, e seu novo salário fcará a partir de agora {NovoSalário}");

         }
    }



    }


        
}
   

