using System;


namespace ExemploVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            AlugarQuarto[] quartos = new AlugarQuarto[10]; 
            Console.WriteLine("Quantos quartos serão resgistrados? ");
            
            int qtd = int.Parse(Console.ReadLine());


            if (qtd < 10)
            {

                for (int i = 0; i < qtd; i++)
                {
                    Console.WriteLine("Dados do " + (i + 1) + "° aluguel: ");
                    Console.WriteLine("Digite seu nome: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Digite seu email: ");
                    string email = Console.ReadLine();
                    quartos[i] = new AlugarQuarto(nome, email);
                }
                    Console.WriteLine("Quartos ocupados: ");
                for (int n = 0; n < qtd; n++)
                {
                    Console.WriteLine((n + 1) + "º Quarto: " + quartos[n]);
                }
            Console.ReadKey();
            }
           
        }
    }
}
