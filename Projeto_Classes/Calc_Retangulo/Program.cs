using System;
using System.Globalization;


Retangulo r = new Retangulo();

Console.Write("Digite a largura e altura de um retangulo: ");
r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"Área: {r.Area().ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Perímetro: {r.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"Diagonal: {r.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
