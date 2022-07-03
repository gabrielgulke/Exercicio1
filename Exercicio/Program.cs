using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double nota, prova1, prova2, mf;

            Console.WriteLine("Informe o nome do aluno: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a nota do trabalho: ");
            nota = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a nota da primeira prova: ");
            prova1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a nota da segunda prova: ");
            prova2 = Convert.ToDouble(Console.ReadLine());

            mf = (nota + prova1 + prova2) / 3;
            Console.WriteLine("A média final é: " + mf);

            if (mf >= 8.5)
                Console.WriteLine("Conceito A");
            else if (mf > 7.0 && mf < 8.4)
                Console.WriteLine("Conceito B");
            else if (mf > 6.0 && mf < 6.9)
                Console.WriteLine("Conceito C");
            else if (mf > 0.1 && mf < 5.9)
                Console.WriteLine("Conceito D");
            else if (mf == 0.0)
                Console.WriteLine("Conceito E");



            Console.ReadKey();
        }
    }
}
