﻿using System;

public class Retangulo
{
    public double Largura;
    public double Altura;

    public double Area()
    {
        return Largura * Altura;

    }
    public double Perimetro()
    {
        return 2.00 * (Largura + Altura);
    }

    public double Diagonal()
    {
        return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
    }

}
