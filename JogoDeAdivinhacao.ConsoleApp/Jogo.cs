using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeAdivinhacao.ConsoleApp
{
    internal class Jogo
    {
        public int numeroSecreto;
        public int totalDeTentativas;
        private Random random = new Random();

        public void Iniciar()
        {
            while (true)
            {
                Console.Clear();
                Mensagens.ExibirCabecalho();
                ConfigurarDificuldade();
                SortearNumeroSecreto();
                Jogar();

                if (!DesejaContinuar())
                    break;
            }
        }

        private void ConfigurarDificuldade()
        {
            Mensagens.ExibirOpcoesDeDificuldade();
            string entrada = Console.ReadLine();
            totalDeTentativas = ObterTentativas(entrada);
        }

        public void SortearNumeroSecreto()
        {
            numeroSecreto = random.Next(1, 21);
        }

        public void Jogar()
        {
            Console.Clear();
            for (int tentativa = 1; tentativa <= totalDeTentativas; tentativa++)
            {
                Mensagens.ExibirTentativaAtual(tentativa, totalDeTentativas);
                int numeroDigitado = ObterNumeroDoJogador();

                if (VerificarAcerto(numeroDigitado))
                {
                    Mensagens.ExibirMensagemAcerto(numeroSecreto);
                    break;
                }

                if (tentativa == totalDeTentativas)
                {
                    Mensagens.ExibirMensagemErro(numeroSecreto);
                    break;
                }

                Mensagens.ExibirDica(numeroDigitado, numeroSecreto);
                Console.Write("\nAperte ENTER para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public int ObterNumeroDoJogador()
        {
            Console.Write("\nDigite um número entre 1 e 20: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int ObterTentativas(string nivel)
        {
            switch (nivel)
            {
                case "1": return 10;
                case "2": return 5;
                case "3": return 3;
                default:
                    Console.WriteLine("Opção inválida");
                    return 5;
            }
        }

        public bool VerificarAcerto(int numeroDigitado)
        {
            return numeroDigitado == numeroSecreto;
        }

        public bool DesejaContinuar()
        {
            Console.WriteLine("\nDeseja Continuar (S/N)");
            return Console.ReadLine().ToUpper() == "S";
        }
    }
}