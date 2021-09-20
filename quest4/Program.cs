using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace quest4
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            int questao;
            Console.WriteLine("Qual questão você quer visualizar? Digite 9, para sair do programa. ");
            Console.WriteLine("QUESTÃO 1: Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.");
            Console.WriteLine("    ");
            Console.WriteLine("QUESTÃO 2: Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários.  ");
            Console.WriteLine("    ");
            Console.WriteLine("QUESTÃO 3: Fazer um programa para ler os valores da largura e altura de um retângulo. Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe como mostrado no projeto ao lado.");
            Console.WriteLine("    ");
            Console.WriteLine("QUESTÃO 4: Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto). Em seguida, mostrar os dados do funcionário (nome e salário líquido). Em seguida, aumentar o salário do funcionário com base em uma porcentagem dada (somente o salário bruto é afetado pela porcentagem) e mostrar novamente os dados do funcionário. ");
            Console.WriteLine("    ");
            Console.WriteLine("QUESTÃO 5: Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver este problema.");

            questao = (int.Parse(Console.ReadLine()));
            switch (questao)
            {
                case 1:
                    Console.Clear();
                    questao1();
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case 2:
                    Console.Clear();
                    questao2();
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case 3:
                    Console.Clear();
                    questao3();
                    Console.ReadKey();
                    Menu();
                    break;
                case 4:
                    Console.Clear();
                    questao4();
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case 5:
                    Console.Clear();
                    questao5();
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case 9:
                    Console.Clear();
                    Console.ReadKey();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Escolha uma questão valida!");
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
            }
        }

        static void questao1()
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            p2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.nome);
            }
            else if (p2.idade > p1.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p2.nome);
            }
            else
            {
                Console.WriteLine("Os dois têm a mesma idade.");
            }

        }

        static void questao2()
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            f1.nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            f1.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            f2.nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            f2.salario = double.Parse(Console.ReadLine());

            double salarioMedio = (f1.salario + f2.salario) / 2;
            Console.WriteLine("Salário médio = R$ " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));
        }

        static void questao3()
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            Console.Write("Altura: ");
            r.altura = double.Parse(Console.ReadLine());
            Console.Write("Largura: ");
            r.largura = double.Parse(Console.ReadLine());
            double c;

            double area = r.altura * r.largura;
            double perimetro = (r.altura * 2) + (r.largura * 2);
            double calcularDiagonal = (Math.Pow(r.altura, 2)) + (Math.Pow(r.largura, 2));
            double resultDiagonal = Math.Sqrt(calcularDiagonal);



            Console.WriteLine("ÁREA = " + area);
            Console.WriteLine("PERÍMETRO = " + perimetro);
            Console.WriteLine("DIAGONAL = " + resultDiagonal);
        }
        static void questao4()
        {
            funcionario f = new funcionario();

            Console.WriteLine("Qual o nome do funcionario?: ");
            f.setNome(Console.ReadLine());

            Console.WriteLine("Qual o salário bruto do funcionario?: ");
            f.setSalario(Double.Parse(Console.ReadLine()));

            Console.WriteLine("Qual o imposto?: ");
            f.setImposto(Double.Parse(Console.ReadLine()));

            Console.WriteLine("                                                                  ");
            Console.WriteLine("Funcionário: " + f.getNome() + ", R$ " + f.getSalario());
            Console.WriteLine("                                                                  ");
            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            f.setPorcentagem(Double.Parse(Console.ReadLine()));
            Console.WriteLine("                                                                  ");
            Console.WriteLine("Dados atualizados: " + f.getNome() + ", R$ " + f.getNovoSalario());
            return;
        }

        static void questao5()
        {
            double notaVerif = 0;

            Aluno a = new Aluno();

            Console.WriteLine("Digite o nome do aluno: ");
            a.nomeAluno = Console.ReadLine();

            do
            {
                notaVerif = 0;
                Console.WriteLine("Qual a 1° nota desse aluno?");
                notaVerif = Double.Parse(Console.ReadLine());
                if (notaVerif > 30)
                {
                    Console.WriteLine("A nota do 1° trimestre não pode ser maior que 30");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    a.setN1(notaVerif);
                }

            } while (notaVerif > 30);



            do
            {
                notaVerif = 0;
                Console.WriteLine("Qual a 2° nota desse aluno?");
                notaVerif = Double.Parse(Console.ReadLine());
                if (notaVerif > 35)
                {
                    Console.WriteLine("A nota do 2° trimestre não pode ser maior que 35");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    a.setN2(notaVerif);
                }

            } while (notaVerif > 35);

            do
            {
                notaVerif = 0;
                Console.WriteLine("Qual a 3° nota desse aluno?");
                notaVerif = Double.Parse(Console.ReadLine());
                if (notaVerif > 35)
                {
                    Console.WriteLine("A nota do 3° trimestre não pode ser maior que 35");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    a.setN3(notaVerif);
                }

            } while (notaVerif > 35);

            Console.WriteLine("NOME DO ALUNO: " + a.nomeAluno);
            Console.WriteLine("NOTA FINAL = " + a.getnfinal());
            if (a.getnfinal() < 60)
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("NOTA FINAL = " + a.getFaltouNota());
            }
            else
            {
                Console.WriteLine("APROVADO");
            }
            return;
        }



    }
}
