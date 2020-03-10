using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Genius
{
    class Program
    {
        static void Main(string[] args)
        {

            //            int[] vetor = new int[4];
            //
            //            Random rand = new Random();

            //            Console.Write(rand.Next(vetor.Length));

            //            Console.ReadKey();

            Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐" +
                "                                                         BEM VINDO AO JOGO                                                    ");
            Thread.Sleep(3000);
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐" +
                "                                                         COMEÇANDO O JOGO                                                    ");
            Thread.Sleep(3000);
            Console.Clear();


            int[] cores = { 1, 2, 3, 4 };
            Random rand = new Random();

            String[] combinacoes = new String[15];

            int cont = 0;

            for (int i = 0; i < combinacoes.Length; i++)
            {
                cont = cont + 1;


                for (int j = 0; j < cont; j++)
                {
                    int randomico = rand.Next(5);

                    if (randomico <= 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        combinacoes[i] = "AMARELO";

                    }
                    else if (randomico == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        combinacoes[i] = "AZUL";

                    }
                    else if (randomico == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        combinacoes[i] = "VERDE";

                    }
                    else if (randomico >= 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        combinacoes[i] = "VERMELHO";

                    }


                }

                for (int k = 0; k < cont; k++)
                {
                    if (combinacoes[k].Equals("AMARELO"))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐" +
                            "                                                         AMARELO                                                    ");
                    }
                    else if (combinacoes[k].Equals("AZUL"))
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐" +
                            "                                                         AZUL                                                    ");
                    }
                    else if (combinacoes[k].Equals("VERDE"))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐" +
                            "                                                         VERDE                                                    ");
                    }
                    else if (combinacoes[k].Equals("VERMELHO"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐" +
                            "                                                         VERMELHO                                                    ");
                    }

                    Thread.Sleep(1200 - i * 120);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();

                    if (k == cont)
                    {
                        Thread.Sleep(500);
                    }
                    else
                    {
                        Thread.Sleep(200);
                    }
                }

                for (int l = 0; l < cont; l++)
                {
                    Console.WriteLine($"┌─────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐" +
                        $"                                                         DIGITE A {l+1}º COR                                                    ");
                    if (!Console.ReadLine().ToString().ToUpper().Equals(combinacoes[l]))
                    {
                        Console.WriteLine("Você errou\n\n\nO jogo acabou");
                        Thread.Sleep(2000);
                        Environment.Exit(1);
                    }

                }

                Console.Clear();

            }




        }








    }

}

