using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDeAdivinhacao.ConsoleApp
{
    internal class Mensagens
    {
        public static void ExibirCabecalho()
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("********|Jogo Da Adivinhação|**********");
            Console.WriteLine("***************************************");
        }

        public static void ExibirOpcoesDeDificuldade()
        {
            // Escolha de dificuldade
            Console.WriteLine("\nEscolha um nível de dificuldade:");
            Console.WriteLine("*************************************");
            Console.WriteLine("*** 1 - Fácil (10 tentativas)  ******");
            Console.WriteLine("*** 2 - Médio (5 tentativas)   ******");
            Console.WriteLine("*** 3 - Difícil (3 tentativas) ******");
            Console.WriteLine("*************************************");
            Console.WriteLine("Digite sua escolha:");
        }

        public static void ExibirTentativaAtual(int tentativa, int totalDeTentativas)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Tentativa {tentativa} de {totalDeTentativas}");
            Console.WriteLine("---------------------------------------------");
        }

        public static void ExibirPontuacao(int pontuacao)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Pontuação atual: {pontuacao}");
            Console.WriteLine("---------------------------------------------");
        }

        public static void ExibirMensagemAcerto(int numeroSecreto)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Parabéns! você acertou!");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Número secreto: {numeroSecreto}");
            Console.WriteLine("-------------------------------------");
        }

        public static void ExibirDica(int numeroDigitado, int numeroSecreto)
        {
            Console.WriteLine("-----------------------------------------------");
            if (numeroDigitado > numeroSecreto)
                Console.WriteLine("O número digitado é maior que o número secreto!");
            else
                Console.WriteLine("O número digitado é menor que o número secreto!");
            Console.WriteLine("-----------------------------------------------");
        }

        public static void ExibirMensagemErro(int numeroSecreto)
        {
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine($"Que pena! Você usou todas as tentativas! O número era {numeroSecreto}.");
            Console.WriteLine("-----------------------------------------------------------------------");
        }
    }
}