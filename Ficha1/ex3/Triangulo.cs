using System;

namespace Figuras;

class Triangulo : FiguraPlana
{
    public double LadoA { get; }
    public double LadoB { get; }
    public double LadoC { get; }

    public Triangulo(double ladoA, double ladoB, double ladoC)
    {
        LadoA = ladoA;
        LadoB = ladoB;
        LadoC = ladoC;
    }
    public override double Perimetro()
    {
        return LadoA + LadoB + LadoC;
    }
    public override double Area()
    {
        double sp = Perimetro() / 2;
        return Math.Sqrt(sp * (sp - LadoA) * (sp - LadoB) * (sp - LadoC));
    }
    public override string ToString()
    {
        return $"\nTriângulo : Lado A= {LadoA:F2} Lado B= {LadoB:F2} Lado C= {LadoC:F2}\n"
            + $"Área= {Area():F2} Perímetro= {Perimetro():F2}";
    }
}