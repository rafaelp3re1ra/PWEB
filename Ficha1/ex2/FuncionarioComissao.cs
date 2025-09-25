namespace EmpresaFuncionarios;

public class FuncionarioComissao : Funcionario
{
    private double vendas_totais;
    private double comissao_vendas;
    //construtor

    public FuncionarioComissao(string nomes, string apelidos, string nif,
        double vendas_totais_entra, double comissao_vendas_entra) : base(nomes, apelidos, nif)
    {
        vendas_totais = vendas_totais_entra;        // valida as vendas
        comissao_vendas = comissao_vendas_entra;    // valida a comissao
    }

    public double VendasTotais
    {
        get { return vendas_totais; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(vendas_totais)} tem que ser >= 0");
            }
            vendas_totais = value;
        }
    }

    public double ComissaoVendas
    {
        get { return comissao_vendas; }
        set
        {
            if (value <= 0 || value >= 1)
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(ComissaoVendas)} tem que ser > 0 e < 1");
            }
            comissao_vendas = value;
        }
    }

    public override double Vencimento() { return comissao_vendas * vendas_totais; }

    public override string ToString()
    {
        return $"Funcionario (por comissao): {base.ToString()}\n"
            + $"Vendas Totais: {vendas_totais:F2}\n"
            + $"Comissao de Vendas: {comissao_vendas:F2}\n"
            + $"Componente do Vencimento Por Comissões: {comissao_vendas * vendas_totais}";
    }
}