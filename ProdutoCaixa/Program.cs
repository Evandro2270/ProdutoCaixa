using ProdutoCaixa;
using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                Produto p = new Produto();

                Console.WriteLine("Entre com dados do produto: ");
                Console.Write("Nome: ");
                p.Nome = Console.ReadLine();
                Console.Write("Preço: ");
                p.Preco = double.Parse(Console.ReadLine(), CI);
                Console.Write("Quantidade no estoque: ");
                p.Quantidade = int.Parse(Console.ReadLine());

                Console.WriteLine("Dados do produto " + p);
            }
        }
    }
}