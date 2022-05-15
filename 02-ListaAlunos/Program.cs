using System;

namespace ListaAlunos
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int quantAlunos = 0;

            Console.WriteLine("Quantidade de alunos:");
            quantAlunos = int.Parse(Console.ReadLine());
            Console.Clear();

            Aluno[] alunos = CadastraAlunos(quantAlunos);
            ProjecaoResultadoAlunos alunosEscolidos = VerificaAlunos(alunos);
            ResultadoSelecao(alunosEscolidos);
        }

        public static Aluno[] CadastraAlunos(int quantAlunos)
        {
            Aluno[] alunos = new Aluno[quantAlunos];

            for (int index = 0; index <= (alunos.Length - 1); index++)
            {
                Aluno aluno = new Aluno();

                Console.WriteLine("Matricula:");
                aluno.matricula = Console.ReadLine();

                Console.WriteLine("Altura:");
                aluno.altura = float.Parse(Console.ReadLine());
                alunos[index] = aluno;
            }
            return alunos;
        }


        public static ProjecaoResultadoAlunos VerificaAlunos(Aluno[] alunos)
        {
            int indexMaior = 0;
            int indexMenor = 0;
            float maxValor = 0;
            float minValor = float.MaxValue;

            for (int index = 0; index < alunos.Length; index++)
            {
                if (alunos[index].altura > maxValor)
                {
                    indexMaior = index;
                    maxValor = alunos[indexMaior].altura;
                }

                if (alunos[index].altura < minValor)
                {
                    indexMenor = index;
                    minValor = alunos[indexMenor].altura;
                }
            }

            return new ProjecaoResultadoAlunos()
            {
                MenorAltura = alunos[indexMenor],
                MaiorAltura = alunos[indexMaior]
            };
        }


        public static void ResultadoSelecao(ProjecaoResultadoAlunos alunos)
        {
            Console.WriteLine("Resultdados: \n");
            Console.WriteLine(" - Matricula com maior Altura: " + alunos.MaiorAltura.matricula + "\n");
            Console.WriteLine(" - Matricula com menor Altura: " + alunos.MenorAltura.matricula + "\n");
            Console.ReadKey();
        }
    }

    //Classes
    public class Aluno
    {
        public Aluno() { }
        public Aluno(string matricula, float altura)
        {
            this.matricula = matricula;
            this.altura = altura;
        }

        public string matricula { get; set; }
        public float altura { get; set; }
    }

    public class ProjecaoResultadoAlunos
    {
        public Aluno MenorAltura;
        public Aluno MaiorAltura;
    }
}