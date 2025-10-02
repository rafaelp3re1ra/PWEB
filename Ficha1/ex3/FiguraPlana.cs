namespace Figuras;

abstract partial class FiguraPlana // Esta class é partial porque é uma parte, não está completa.
                                   // A esta parte vão se juntar mais coisas (as propriedades).
{
    public abstract double Area();
    public abstract double Perimetro();
    public abstract override string ToString();
}