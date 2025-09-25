namespace EmpresaFuncionarios;

public abstract class Funcionario
{
    public string Nomes { get; }

    public string Apelidos { get; }

    public string NIF { get; }
    //constructor
    public Funcionario(string nomes, string apelidos, string nif)
    {
        Nomes = nomes;
        Apelidos = apelidos;
        NIF = nif;
    }

    public abstract double Vencimento();

    public override string ToString()
    {
        return $"Nome= {Nomes} {Apelidos} \n NIF= {NIF}\n";
    }
}