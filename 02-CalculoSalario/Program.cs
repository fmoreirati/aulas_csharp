using System;

namespace CalculoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantFunc = 1;
            Funcionario[] funcionarios = new Funcionario[quantFunc];
            for (int index = 0; index < quantFunc; index++)
            {
                Funcionario funcionario = Cadastrar();
                ReajustarSalario(funcionario);
                funcionarios[index] = funcionario;
            }

            string listFuncionarios = ListarUsuarios(funcionarios);
            Console.WriteLine(listFuncionarios);
            Console.ReadKey();
        }

        public static Funcionario Cadastrar()
        {
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Salario:");
            float salario = float.Parse(Console.ReadLine());
            Funcionario funcionario = new Funcionario(nome, salario);
            return funcionario;
        }

        public static Funcionario ReajustarSalario(Funcionario funcionario)
        {
            funcionario.salario = funcionario.salario <= 300.00f ? funcionario.salario * 1.5f : funcionario.salario * 1.3f;
            return funcionario;
        }

        public static String ListarUsuarios(Funcionario[] funcionarios)
        {
            string result = @"
                Lista de Usuarios:
                ----------------------------------------------------------------------------------------
                Nome    - Salario
                ----------------------------------------------------------------------------------------
                ";
            for (int index = 0; index < funcionarios.Length; index++)
            {
                result += String.Format("{0}\t - {1}", funcionarios[index].nome, funcionarios[index].salario);
            }
            return result;
        }


    }

    public class Funcionario
    {
        public Funcionario(string nome, float salario)
        {
            this.nome = nome;
            this.salario = salario;
        }

        public string nome;
        public float salario;
    }
}
