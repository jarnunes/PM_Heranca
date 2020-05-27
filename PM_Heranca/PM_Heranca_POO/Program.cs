using System;

namespace PM_Heranca_POO
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno aluno1 = new Aluno("Jardel", 681810, new DateTime(2000, 02, 28), 4500, 200);
            Aluno aluno2 = new Aluno("Mathias", 671810, new DateTime(1900, 02, 28), 4500, 200);

            
            Professor prof = new Professor("Lucila", 10345, new DateTime(1870, 05, 28), 3000, new DateTime(1996, 12, 10), 6.000);
            Professor prof1 = new Professor("Caram", 15345, new DateTime(1879, 05, 28), 3000, new DateTime(1996, 12, 10), 7.000);

            Pessoa[] bandao = new Pessoa[4];
            bandao[0] = aluno1;
            bandao[1] = aluno2;
            bandao[2] = prof;
            bandao[3] = prof1;

            foreach (Pessoa p in bandao)
            {
                Console.WriteLine(p.imprimir()) ;
            }
        }
    }
}
