using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Aluno
{
    internal class Aluno
    {
        public string Nome;
        public double NotaA, NotaB, NotaC;

        public void SituacaoAluno()
        {
            double resultado = NotaA + NotaB + NotaC;
            double notaFaltante = 60.00 - resultado;

            Console.WriteLine($"Nota Final: {resultado:F2}");

            if (resultado >= 60.00)
            {
                Console.WriteLine($"Aprovado");
            }
            else
            {
                Console.WriteLine($"Reprovado");
                Console.WriteLine($"Faltaram {notaFaltante:F2} pontos");
            }
        }
    }
}
