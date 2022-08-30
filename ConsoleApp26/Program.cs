using System;
using System.Globalization;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Nota a = new Nota();


            Console.WriteLine("Qual nome desse aluno?");
            a.Nome= Console.ReadLine();
            Console.WriteLine("Qual a nota desse aluno no Primeiro semestre:");
            a.Nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Qual a nota desse aluno no Segundo semestre:");
            a.Nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Qual a nota desse aluno no Terceiro semestre:");
            a.Nota3 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            //Dados aluno
            Console.WriteLine(a);
        }
    }
}
