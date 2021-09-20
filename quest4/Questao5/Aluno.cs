using System;
using System.Collections.Generic;
using System.Text;

namespace quest4
{
    class Aluno
    {
        public string nomeAluno { get; set; }
        double n1, n2, n3, nfinal;

        
        public void setN1(double n1)
        {
            this.n1 = n1;
        }

        public void setN2(double n2)
        {
            this.n2 = n2; 
        }

        public void setN3(double n3)
        {
            this.n3 = n3; 
        }

        public double getnfinal()
        {
            return n1+n2+n3;
        }

        public double getFaltouNota()
        {
            return 60 - (n1 + n2 + n3);
        }
    }
}
