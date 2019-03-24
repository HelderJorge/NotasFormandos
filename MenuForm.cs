using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Formando
{
    class MenuForm
    {
        public static void Main(string[] args)
        {
            char resp;
            MetForm.LerFormandos();
            do
            {
                switch (Menu())
                {
                    case 1:
                        MetForm.InserirFormandos();
                        break;
                    case 2:
                        MetForm.GerirNotas12();
                        break;
                    case 3:
                        MetForm.GerirNotas13();
                        break;
                    case 4:
                        MetForm.GerirNotas24();
                        break;
                    case 5:
                        MetForm.MostrarNotas();
                        break;
                    case 6:
                        MetForm.MediasMod();
                        break;
                    case 7:
                        MetForm.MediaForm();
                        break;
                    case 8:
                        MetForm.delete();
                        break;
                    case 9:
                        break;
                }
                Console.WriteLine("\nPretende continuar no ***Formandos***?" +
                    "\nDigite S(Sim) / N(Não):");
                resp = char.Parse(Console.ReadLine());
            } while (resp == 's' || resp == 'S');
        }

        static int Menu()
        {
            int escolha = 0;
            while (escolha != 1 && escolha != 2 && escolha != 3 && escolha != 4 && escolha != 5 
                && escolha != 6 && escolha != 7 && escolha !=8 && escolha!=9)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("\t\t**************************************************************");
                Console.WriteLine("\t\t**               *****Formandos*******                      **");
                Console.WriteLine("\t\t**                                                          **");
                Console.WriteLine("\t\t**        Olá, Bem-Vindo! O que deseja fazer?               **");
                Console.WriteLine("\t\t**                                                          **");
                Console.WriteLine("\t\t**        1- Inserir formandos                              **");
                Console.WriteLine("\t\t**        2- Gerir notas mod.12                             **");
                Console.WriteLine("\t\t**        3- Gerir notas mod.13                             **");
                Console.WriteLine("\t\t**        4- Gerir notas mod 24                             **");
                Console.WriteLine("\t\t**        5- Mostrar notas                                  **");
                Console.WriteLine("\t\t**        6- Médias dos Módulos                             **");
                Console.WriteLine("\t\t**        7- Médias dos Formandos                           **");
                Console.WriteLine("\t\t**        8- Apagar formandos                               **");
                Console.WriteLine("\t\t**        9- Sair                                           **");
                Console.WriteLine("\t\t**************************************************************");
                escolha = int.Parse(Console.ReadLine());
            }
            return escolha;
        }
        
    }
}
