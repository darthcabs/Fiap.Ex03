using Fiap.Exemplo04.UI.Console.DTOs;
using Fiap.Exemplo04.UI.Console.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exemplo04.UI.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Consumo de API");
            int resp = 0;

            do
            {
                System.Console.WriteLine("\nOpções:");
                System.Console.WriteLine("\t(1): Listar todos os alunos");
                System.Console.WriteLine("\t(2): Listar aluno por Id");
                System.Console.WriteLine("\t(3): Cadastrar novo aluno");
                System.Console.Write("\nDigite a opção desejada: ");
                resp = Convert.ToInt32(System.Console.ReadLine());
            } while (resp < 1 || resp > 3);

            GenericRepository<AlunoDTO> repo = new GenericRepository<AlunoDTO>();

            switch (resp)
            {
                case 1:
                    List<AlunoDTO> alunos = repo.Listar() as List<AlunoDTO>;

                    System.Console.WriteLine("\nAlunos:");
                    foreach (var a in alunos)
                    {
                        System.Console.WriteLine("\nNome: " + a.Nome);
                        System.Console.WriteLine("Data de Nascimento: " + a.DataNascimento);
                        System.Console.WriteLine("Bolsista: " + (a.Bolsa?"Sim":"Não"));
                        System.Console.WriteLine("Desconto: " + a.Desconto);
                        System.Console.WriteLine("Id do Grupo: " + a.GrupoId);
                    }
                    
                    break;
                case 2:
                    System.Console.Write("Qual o id do aluno?: ");
                    int id = Convert.ToInt32(System.Console.ReadLine());

                    AlunoDTO aluno = repo.BuscarPorId(id) as AlunoDTO;
                    System.Console.WriteLine("\nNome: " + aluno.Nome);
                    System.Console.WriteLine("Data de Nascimento: " + aluno.DataNascimento);
                    System.Console.WriteLine("Bolsista: " + (aluno.Bolsa ? "Sim" : "Não"));
                    System.Console.WriteLine("Desconto: " + aluno.Desconto);
                    System.Console.WriteLine("Id do Grupo: " + aluno.GrupoId);

                    break;
                case 3:
                    AlunoDTO alu = new AlunoDTO();
                    System.Console.Write("\nNome: ");
                    alu.Nome = System.Console.ReadLine();

                    System.Console.Write("Data de Nascimento (DD/MM/AAAA): ");
                    alu.DataNascimento = Convert.ToDateTime(System.Console.ReadLine());

                    System.Console.Write("Bolsista (s/n): ");
                    string bolsa = System.Console.ReadLine();
                    if (bolsa.ToUpper() == "S")
                    {
                        alu.Bolsa = true;
                    }
                    else
                    {
                        alu.Bolsa = false;
                    }

                    System.Console.Write("Desconto (em %): ");
                    alu.Desconto = Convert.ToInt32(System.Console.ReadLine());

                    System.Console.Write("Id do Grupo: ");
                    alu.GrupoId = Convert.ToInt32(System.Console.ReadLine());

                    repo.Cadastrar(alu);

                    break;
            }

            System.Console.ReadKey();
        }
    }
}