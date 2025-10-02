namespace Figuras;

class Retangulo : FiguraPlana
{
    public double Comprimento { get; }
    public double Largura { get; }
    public Retangulo(double comp = 0, double larg = 0)
    {
        Comprimento = comp;
        Largura = larg;
    }
    public override double Area()
    {
        return Comprimento * Largura;
    }
    public override double Perimetro()
    {
        return 2 * Comprimento + 2 * Largura; // ou 2*(comp+larg)
    }
    public override string ToString()
    {
        return $"\nRectângulo : Comprimento= {Comprimento:F2} Largura= {Largura:F2}\n"
            + $"Área= {Area():F2} Perímetro= {Perimetro():F2}";
    }

}