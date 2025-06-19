using Exercicio_Funcionario;
using System;
using System.Globalization;

Funcionario func = new Funcionario();

Console.Write("Nome:");
func.Nome = Console.ReadLine();
Console.Write("Salario Bruto:");
func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Imposto:");
func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Funcionário: " + func);

Console.Write("Digite a porcentagem para aumentar o salario: ");
double porcentAumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
func.AumentarSalario(porcentAumento);

Console.WriteLine("Dados atualizados: " + func);