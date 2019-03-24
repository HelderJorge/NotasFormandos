using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Formando
{
    class MetForm
    {
        static SortedDictionary<int, Formando> formandos = new SortedDictionary<int, Formando>();

        public static void LerFormandos()
        {
            string path = @"formandos.txt";
            StreamReader sr;
            if (File.Exists(path))
            {
                sr = File.OpenText(path);
                string linha = " ";
                while ((linha = sr.ReadLine()) != null)
                {
                    string[] campos = new string[5];
                    campos = linha.Split(';');
                    int num = Convert.ToInt16(campos[0]);
                    string nome = campos[1];
                    Formando form = new Formando(num, nome);
                    formandos.Add(num, form);
                    formandos[num].setnota12(Convert.ToDouble(campos[2]));
                    formandos[num].setnota13(Convert.ToDouble(campos[3]));
                    formandos[num].setnota24(Convert.ToDouble(campos[4]));
                }
                sr.Close();
            }
            else { Console.WriteLine("Começe por inserir formandos.\n"); }
        }

        public static void EscreverFormandos()
        {
            string path = @"formandos.txt";
            FileStream sc = File.Create(path);
            sc.Close();
            foreach (KeyValuePair<int, Formando> x in formandos)
            {
                StreamWriter sw = File.AppendText(path);
                string linha = x.Key + ";" + x.Value.getnome() + ";" + x.Value.getnota12() + ";" + x.Value.getnota13() + ";" + x.Value.getnota24();
                sw.WriteLine(linha);
                sw.Close();
            }
        }

        public static void InserirFormandos()
        {
            MostrarNotas();
            int i;
            Console.WriteLine("Quantos formandos deseja inserir");
            int n = int.Parse(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Qual o nº do formando");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual o nome do formando");
                string nome = Console.ReadLine();
                Formando form = new Formando(num, nome);
                formandos.Add(num, form);
            }
            EscreverFormandos();
            MostrarNotas();
        }

        public static void GerirNotas12()
        {
            MostrarNotas();
            Console.WriteLine("Quantos notas pretende adicionar:");
            int n = int.Parse(Console.ReadLine());
            int i;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o nº do Formando pretendido:");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a nota do " + formandos[num].getnome());
                double nota = double.Parse(Console.ReadLine());
                formandos[num].setnota12(nota);
            }
            EscreverFormandos();
            MostrarNotas();
        }

        public static void GerirNotas13()
        {
            MostrarNotas();
            Console.WriteLine("Quantos notas pretende adicionar:");
            int n = int.Parse(Console.ReadLine());
            int i;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o nº do Formando pretendido:");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a nota do " + formandos[num].getnome());
                double nota = double.Parse(Console.ReadLine());
                formandos[num].setnota13(nota);
            }
            EscreverFormandos();
            MostrarNotas();
        }

        public static void GerirNotas24()
        {
            MostrarNotas();
            Console.WriteLine("Quantos notas pretende adicionar:");
            int n = int.Parse(Console.ReadLine());
            int i;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o nº do Formando pretendido:");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a nota do " + formandos[num].getnome());
                double nota = double.Parse(Console.ReadLine());
                formandos[num].setnota24(nota);
            }
            EscreverFormandos();
            MostrarNotas();
        }

        public static void MostrarNotas()
        {
            Console.WriteLine("Registos dos Formandos");
            foreach (KeyValuePair<int,Formando>x in formandos)
            {
                Console.WriteLine("Num: {0} ; Nome: {1} ; Mod12: {2} ; Mod13: {3} ; Mod24: {4}"
                    ,x.Key, x.Value.getnome(), x.Value.getnota12(),x.Value.getnota13(),x.Value.getnota24());
            }
        }

        public static void MediasMod()
        {
            int count12=0, count13=0, count24=0;
            double soma12=0, soma13=0, soma24=0;
            foreach (KeyValuePair<int, Formando> x in formandos)
            {
                soma12 += x.Value.getnota12();
                if (x.Value.getnota12() != 0) { count12++; }
                soma13 += x.Value.getnota13();
                if (x.Value.getnota13() != 0) { count13++; }
                soma24 += x.Value.getnota24();
                if (x.Value.getnota24() != 0) { count24++; }
            }
            Console.WriteLine("Média do Mod.12: "+soma12/count12);
            Console.WriteLine("Média do Mod.13: " + soma13 / count13);
            Console.WriteLine("Média do Mod.24: " + soma24 / count24);
        }

        public static void MediaForm()
        {
            MostrarNotas();
            Console.WriteLine("Digite o nº do Formando:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nº de módulos completados:");
            int nummod = int.Parse(Console.ReadLine());
            Console.WriteLine("Num: {0} ; Nome: {1} ; Media: {2}", num, formandos[num].getnome(),
                  (formandos[num].getnota12()+formandos[num].getnota13()+formandos[num].getnota24())/nummod);
        }

        public static void delete()
        {
            MostrarNotas();
            Console.WriteLine("Digite o nº do Formando que pretende apagar:");
            int num = int.Parse(Console.ReadLine());
            if(formandos.Remove(num))
            {
                Console.WriteLine("Formando Removido.");
                EscreverFormandos();
                MostrarNotas();
            }
            else { Console.WriteLine("Formando não Existe."); }
        }
    }
}
