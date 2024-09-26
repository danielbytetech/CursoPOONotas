using System;

namespace CursoPOONotas
{
    class Program
    {
        static void Main(string[] args)
        {
            var gerenciador = new Gerenciador();

            while (true)
            {
                Console.WriteLine("1 - Adicionar Nota");
                Console.WriteLine("2 - Exibir todas as Notas");
                Console.WriteLine("3 - Sair");

                var opcao = Console.ReadLine()!;

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Digite uma descrição");
                        var titulo = Console.ReadLine();

                        gerenciador.Adicionar(titulo);
                        break;
                    case "2":
                        gerenciador.ExibirTodas();
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }
            }
        }
    }
}
