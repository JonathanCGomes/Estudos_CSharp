using Exercicio_Aluno;
using System.Xml;
using System.Globalization;

Aluno aluno = new Aluno();

Console.Write("Nome do aluno:");
aluno.Nome = Console.ReadLine();


Console.WriteLine("Digite as tres notas do aluno:");
aluno.NotaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.NotaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.NotaC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


aluno.SituacaoAluno();

