namespace EmpresaFuncionarios;

class FuncionarioBaseMaisComissao : FuncionarioComissao
{
    private double vencimento_base;
    // constructor
    public FuncionarioBaseMaisComissao(string nomes, string apelidos, string nif,
        double vendas_totais, double comissao_vendas, double vencimento_base_entra)
        : base(nomes, apelidos, nif, vendas_totais, comissao_vendas)
    {
        vencimento_base = vencimento_base_entra;
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

    public override double Vencimento() { return VencimentoBase + base.Vencimento(); }

    public override string ToString()
    {
        return $"Funcionario Base: {base.ToString()}"
            + $"\nVencimento Base: {VencimentoBase:F2}";
    }
}