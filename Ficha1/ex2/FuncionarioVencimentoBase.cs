namespace EmpresaFuncionarios;

class FuncionarioVencimentoBase : Funcionario
{
    private double vencimento_base;

    public FuncionarioVencimentoBase(string nomes, string apelidos, string nif,
        double vencimento_base_entra) : base(nomes, apelidos, nif)
    {
        VencimentoBase = vencimento_base_entra;
    }

    public double VencimentoBase
    {
        get { return vencimento_base; }

        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"O valor {nameof(VencimentoBase)} tem que ser >= 0");
            }
            vencimento_base = value;
        }
    }

    public override double Vencimento() { return VencimentoBase; }

    public override string ToString()
    {
        return $"Funcionario (Vencimento Base): {base.ToString()}"
            + $"Vencimento Base = {VencimentoBase:F2}";
    }
}