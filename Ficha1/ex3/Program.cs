// Figura plana é uma classe abstrata. Ela não tem propriedades e tem 3 métodos, área, perímetro e ToString.
// Basicamente é abstrata porque tem algo que não é definido. As propriedades não estão definidas, são diferentes.
// Na classe mãe (Figura Plana) não se pode definir as propriedades porque são todas diferentes e não podem herdar da classe mãe.
//Fórmula De Heron para calcular qualquer tipo de triângulo -> A = sqrt(sp*(sp-a)*(sp-b)*(sp-c))
//sp = P/2
//sp - semi-perímetro

namespace Figuras // Aqui em vez de termos chaveta, podemos por ";" como temos feito (e devemos). 
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r1 = new Retangulo(5, 6);
            Console.WriteLine(r1);

            Triangulo t1 = new Triangulo(3, 4, 5);
            Console.WriteLine(t1);

            Circulo c1 = new Circulo(7);
            Console.WriteLine(c1);

            Console.ReadKey();
        }
    }
}