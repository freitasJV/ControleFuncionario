using System;
using System.Collections.Generic;
using System.Globalization;

namespace ControleFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            Console.Write("Quantos funcionários deseja registrar: ");
            int qtde = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtde; i++)
            {
                Console.WriteLine($"{i}ºFuncionário:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarios.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Qual o id do funcionário que deseja aumentar o salário? ");
            int idAumento = int.Parse(Console.ReadLine());
           
            var func = funcionarios.Find(x => x.Id == idAumento);

            if (func == null)
                Console.WriteLine("Funcionário não encotrado");
            else
            {
                Console.Write("Porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.AumentarSalario(porcentagem);
            }

            Console.WriteLine();
            Console.WriteLine("Lista de funcionários:");

            foreach (Funcionario f in funcionarios)
                Console.WriteLine(f);
        }
    }
}
