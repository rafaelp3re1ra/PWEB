namespace Figuras;

class Circulo : FiguraPlana
{
    public double Raio { get; }

    public Circulo(double r = 0)
    {
        Raio = r;
    }
    public override double Area()
    {
        return Math.Pow(Raio, 2) * Math.PI;
    }
    public override double Perimetro()
    {
        return 2 * Math.PI * Raio;
    }
    public override string ToString()
    {
        return $"\nCirculo : Raio= {Raio:F2} \n"
            + $"Área? {Area():F2} Perímetro= {Perimetro():F2}";
    }
}