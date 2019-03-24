using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_Formando
{
    
    public class Formando
    {
        private int numeroaluno;
        private string nome;
        private double nota12, nota13, nota24;
    
        public Formando(){}

        public Formando(int num, string nome)
        {
            numeroaluno = num;
            this.nome = nome;
        }

        public string getnome()
        {
            return this.nome;
        }

        public string getnum()
        {
            return this.nome;
        }

        public double getnota12() { return nota12; }
        public double getnota13() { return nota13; }
        public double getnota24() { return nota24; }

        public void setnota12(double nota) { nota12 = nota; }
        public void setnota13(double nota) { nota13 = nota; }
        public void setnota24(double nota) { nota24 = nota; }
    }
}
