using SegundoExercicioAulaClassesUml;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Produto produto = new Produto();

            Console.WriteLine("Digite os dados do produto.");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CI);
            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());


            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);
            Console.WriteLine();


            Console.Write("Digite o número de produtos a ser " +
                "adicionado ao estoque:");
            int qte = int.Parse(Console.ReadLine());
            produto.AdicionarProduto (qte);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);
            Console.WriteLine();


            Console.Write("Digite o número de produtos a ser " +
                "subtraido do estoque:");
            qte = int.Parse(Console.ReadLine());
            produto.RemoverProdutos (qte);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);
            Console.WriteLine();

        }
    }
}