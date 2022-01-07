using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioD.Jogo
{
    class Program
    {
        static JogoReposit reposit = new JogoReposit();
        static void Main(string[] args)
        {   
            string escolher = ObterEscolha();

            while (escolher.ToUpper() != "X")
            {
                switch (escolher)
                {
                    case "1":
                        ListarJogos();
                        break;
                    case "2":
                        InserirJogos();
                        break;
                    case "3":
                        AtualizarJogos();
                        break;
                    case "4":
                        ExcluirJogos();
                        break;
                    case "5":
                        VisualizarJogos();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                escolher = ObterEscolha();
            }

            System.Console.WriteLine("Obrigado por nos escolher!");
            Console.ReadLine();
        }
        private static void ListarJogos()
        {
            System.Console.WriteLine("Listar Jogos");
            var lista = reposit.Lista();
            if (lista.Count == 0)
            {
                System.Console.WriteLine("Não há jogos ainda");
                return;
            }

            foreach (var jogo in lista)
            {
                System.Console.WriteLine("#ID {0}: - {1}", jogo.retId(), jogo.retNome());
            }
        }

        private static void InserirJogos()
        {
            System.Console.WriteLine("Inserir jogo");

            foreach (int i in Enum.GetValues(typeof(Tipo)))
            {
                System.Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Tipo), i));
            }
            System.Console.WriteLine("Digite o Tipo entre as opções acima: ");
            int entraTipo = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o Nome do jogo: ");
            string entraNome = Console.ReadLine();

            System.Console.WriteLine("Digite o Lançamento do jogo: ");
            int entraAno = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a Descrição do jogo: ");
            string entraDesc = Console.ReadLine();

            Jogo novoJogo = new Jogo(id: reposit.ProxId(),
                                     tipo: (Tipo)entraTipo,
                                     nome: entraNome,
                                     ano: entraAno,
                                     descrever: entraDesc);

            reposit.Inserir(novoJogo);
        }

        private static void AtualizarJogos()
        {
            System.Console.WriteLine("Digite o Id do jogo");
            int indiceJogo = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Tipo)))
            {
                System.Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Tipo), i));
            }
            System.Console.WriteLine("Digite o Tipo entre as opções acima: ");
            int entraTipo = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o Nome do jogo: ");
            string entraNome = Console.ReadLine();

            System.Console.WriteLine("Digite o Lançamento do jogo: ");
            int entraAno = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a Descrição do jogo: ");
            string entraDesc = Console.ReadLine();

            Jogo atualizarJogo = new Jogo(id: indiceJogo,
                                     tipo: (Tipo)entraTipo,
                                     nome: entraNome,
                                     ano: entraAno,
                                     descrever: entraDesc);

            reposit.Atualizar(indiceJogo, atualizarJogo);
        }

        private static void ExcluirJogos()
        {
            System.Console.WriteLine("Digite o Id da série: ");
            int indiceJogo = int.Parse(Console.ReadLine());

            reposit.Excluir(indiceJogo);
        }

        private static void VisualizarJogos()
        {
            System.Console.WriteLine("Digite o Id da série: ");
            int indiceJogo = int.Parse(Console.ReadLine());

            var jogo = reposit.RetornoId(indiceJogo);

            System.Console.WriteLine(jogo);
        }
        private static string ObterEscolha()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Bem vindo ao APS Aperte Start");
            System.Console.WriteLine("Escolha uma opção a seguir: ");

            System.Console.WriteLine("1 - Listar Jogos");
            System.Console.WriteLine("2 - Inserir Jogo");
            System.Console.WriteLine("3 - Atualizar Jogo");
            System.Console.WriteLine("4 - Excluir Jogo");
            System.Console.WriteLine("5 - Visualizar Jogo");
            System.Console.WriteLine("C - Limpar a tela");
            System.Console.WriteLine("X - Sair");
            System.Console.WriteLine();

            string escolher = Console.ReadLine().ToUpper();
            System.Console.WriteLine();
            return escolher;
        }
    }
}
