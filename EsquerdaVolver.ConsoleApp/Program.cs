using System;

namespace EsquerdaVolver.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int numeroComandos = 0;

            do
            {

                Console.WriteLine("Insira o numero de comandos:");
                numeroComandos = Convert.ToInt32(Console.ReadLine());
                char visao = 'N';

                if (numeroComandos == 0)
                {
                    break;

                }

                Console.WriteLine("Insira os comandos:");
                string comandos = Console.ReadLine();

                if (comandos.Length != numeroComandos)
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Numero de comandos não correspondem ao valor informado! Tente novamente.");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;

                }

                for (int i = 0; i < numeroComandos; i++)
                {

                    if (comandos[i] == 'E' && visao == 'N')
                    {

                        visao = 'O';

                    }
                    else if (comandos[i] == 'E' && visao == 'L')
                    {

                        visao = 'N';

                    }
                    else if (comandos[i] == 'E' && visao == 'S')
                    {

                        visao = 'L';

                    }
                    else if (comandos[i] == 'E' && visao == 'O')
                    {

                        visao = 'S';

                    }
                    else if (comandos[i] == 'D' && visao == 'N')
                    {

                        visao = 'L';

                    }
                    else if (comandos[i] == 'D' && visao == 'L')
                    {

                        visao = 'S';

                    }
                    else if (comandos[i] == 'D' && visao == 'S')
                    {

                        visao = 'O';

                    }
                    else if (comandos[i] == 'D' && visao == 'O')
                    {

                        visao = 'N';

                    }

                }

                Console.WriteLine(visao);

            } while (numeroComandos > 0);

            Console.ReadKey();
        }
    }
}
