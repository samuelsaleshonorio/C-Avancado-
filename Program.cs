using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Escola_Completo
{
    class Aluno
    {
     public string Nome, DatadeNascimento;
     public int RG;
    }
    class Funcionario
    {
        public string nome, cargo;
    }
    class Turma
    {
        public string periodo, ensino, sigla,serie;
    }

    class Testa_Aluno_Funcionario_Turma
    {
        static void Main()
        {
            Aluno a1 = new Aluno();
            a1.Nome = "Primeiro Aluno";
            a1.DatadeNascimento = "01 / 01 / 2001";
            a1.RG = 1234;

            Aluno a2 = new Aluno();
            a2.Nome = "Segundo Aluno";
            a2.DatadeNascimento = "02 / 02 / 2002";
            a2.RG = 5678;

            Funcionario f1 = new Funcionario();
            f1.nome = "Primeiro Funcionario";
            f1.cargo = "Cargo 1";

            Funcionario f2 = new Funcionario();
            f2.nome = "Segundo Funcionario";
            f2.cargo = "Cargo 2";

            Turma t1 = new Turma();
            t1.periodo = "Manha";
            t1.serie = "1º";
            t1.sigla = "#";
            t1.ensino = "Medio";

            Turma t2 = new Turma();
            t2.periodo = "Tarde";
            t2.serie = "2º";
            t2.sigla = "¨";
            t2.ensino = "Fundamental";

            Console.WriteLine("                LISTA DE DADOS DA ESCOLA - ALUNOS - FUNCIONARIOS - TURMAS -        ");
            Console.WriteLine("Nome do aluno: " + a1.Nome);
            Console.WriteLine("Data de nascimento: " + a1.DatadeNascimento);
            Console.WriteLine("RG do aluno: " + a1.RG);
            Console.WriteLine("\nNome do aluno: " + a2.Nome);
            Console.WriteLine("Data de nascimento: " + a2.DatadeNascimento);
            Console.WriteLine("RG do aluno: " + a2.RG);
            Console.WriteLine();

            //Console.WriteLine("                         - DADOS ESCOLA - FUNCIONARIOS -                ");
            Console.WriteLine("Nome do funcionario: " + f1.nome);
            Console.WriteLine("Cargo do funcionario: "+f1.cargo);
            Console.WriteLine("\nNome do funcionario: " + f2.nome);
            Console.WriteLine("Cargo do funcionario: " + f2.cargo);

            //Console.WriteLine("                             - DADOS ESCOLA - TURMAS -                ");
            Console.WriteLine("\nPeriodo Turma: "+t1.periodo);
            Console.WriteLine("Serie Turma: "+t1.serie);
            Console.WriteLine("Sigla Turma: "+t1.sigla);
            Console.WriteLine("Tipo de ensino: "+t1.ensino);
            Console.WriteLine("\nPeriodo Turma: " + t2.periodo);
            Console.WriteLine("Serie Turma: " + t2.serie);
            Console.WriteLine("Sigla Turma: " + t2.sigla);
            Console.WriteLine("Tipo de ensino: " + t2.ensino);
    
       
            Console.ReadKey();
        }
    }
}
