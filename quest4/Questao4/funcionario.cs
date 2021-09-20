using System;
using System.Collections.Generic;
using System.Text;

namespace quest4
{
    class funcionario
    {
        string nome;
        double salarioB, imposto, porcentagem;
        
        public string getNome()
        {
            return nome; // Retorne o nome da pessoa
        }
        public void setNome(string nome)
        {
            this.nome = nome; //Altere o nome da pessoa
        }

        public void setSalario(double salarioB)
        {
            this.salarioB = salarioB;//Altere o nome da pessoa
        }

        public void setImposto(double imposto)
        {
            this.imposto = imposto; //Altere o nome da pessoa
        }

        public void setPorcentagem(double porcentagem)
        {
            this.porcentagem = porcentagem;
        }

        public double getSalario()
        {
            return salarioB - imposto;
        }

        public double getNovoSalario()
        {
            return ((salarioB * (porcentagem/100))+salarioB)-imposto;
        }


    }
}
