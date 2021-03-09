using System;

namespace joquempo
{
    class Program
    {
        static void Main(string[] args)
        {
            //cria uma instância da classe Program
            Program p = new Program();
            //define as variáveis usadas no programa como do tipo int
            int play1, play2;
            int jogadaEscolhida;
            Console.WriteLine("O COLISEU DA MORTE :");
            try
            {

                Console.WriteLine("AS REGRAS DO JOGO DAMAS E CAVALHEIROS : NÚMEROS IMPARES=TESOURA : NÚMEROS PARES=PAPEL : JÁ O EMPATE MEUS QUERIDOS, SERÁ POR CONTA DA CASA!!!");
                //recebe as jogadas via console
                Console.WriteLine("Jogue Primeiro : ");
                play1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sua vez de jogar !!  :");
                play2 = Convert.ToInt32(Console.ReadLine());
                //chamando o método para definir qual o numero maior
                jogadaEscolhida = p.JogadaMelhor(play1, play2);
                Console.WriteLine("O mais forte é " + jogadaEscolhida);
                //chamando o método para verificar se a jogada foi mais forte
                p.JogadaFraca(jogadaEscolhida);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
        private int JogadaMelhor(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
        private void JogadaFraca(int num)
        {
            int i = 2;
            while (i < num)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("\nSeu ataque foi fraco, vai chorar ?.");
                    break;
                }
                i++;
            }
            //
            if (i == num)
            {
                Console.WriteLine("\nEsse ataque foi bom, continue assim.");
            }
            if (num == 0 || num == 1)
            {
                Console.WriteLine("\nNão há ganhadores, declaro EMPATE.");
            }
        }
    }
}
