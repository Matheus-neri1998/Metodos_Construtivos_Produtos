using System;
using Exercício_2___Produtos.Classes;

namespace Exercício_2___Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto product = new Produto();

            Console.WriteLine("Digite o nome do produto desejado: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string Nome = Console.ReadLine(); // nome do produto 1
            Console.ResetColor();

            Console.WriteLine("---------------------");
            Console.WriteLine("Insira o código do produto: ");
            Console.ForegroundColor = ConsoleColor.Green;
            int Codigo = int.Parse(Console.ReadLine()); // código do produto 1
            Console.ResetColor();

            Console.WriteLine("----------------------");
            Console.WriteLine("Escreva a descrição do produto: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string Descricao = Console.ReadLine(); // descrição do produto 1 
            Console.ResetColor();

            Console.WriteLine("----------------------");
            Console.WriteLine("Insira o estoque do produto: ");
            Console.ForegroundColor = ConsoleColor.Black;
            int Estoque = int.Parse(Console.ReadLine()); // estoque do produto 1
            Console.ResetColor(); // fim de produto 1

            Produto product2 = new Produto(Nome, Codigo, Descricao, Estoque);
            // fim de produto 2
            

            Produto product3 = new Produto("Suco de Laranja", 5, "Este suco é natural", 22);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------------");
            Console.Write($"Nome do produto: {product3.Nome ?? "sem nome"} - Código do produto: {product3.Codigo} - " +
            $"Descrição do produto: {product3.Descricao}, Estoque do produto: {product3.Estoque}");
            Console.ResetColor(); // fim de produto 3

            Produto product4 = new Produto ();
            Console.ForegroundColor = ConsoleColor.Yellow;
            product4.Nome = "Refrigerante de Cola";
            product4.Codigo = 7;
            product4.Descricao = "0% de gás";
            product4.Estoque = 14; // fim de produto 4
            Console.ResetColor(); 

            Console.ReadLine();
        }
    }
}
