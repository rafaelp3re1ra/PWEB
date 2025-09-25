namespace EmpresaFuncionarios;

class FuncionarioVencimentoHora : Funcionario
{
    private double vencimento_hora; // vencimentos por hora
    private int horas_trabalho;     // horas realizadas num mês
    private int dias_uteis_mes;     // dias uteis no mês
    // constructor

    public FuncionarioVencimentoHora(string nomes, string apelidos,
        string nif, double vencimento_hora, int horas_trabalho, int dias_mes)
        : base(nomes, apelidos, nif)
    {
        VencimentoHora = vencimento_hora;   // valida
        HorasTrabalho = horas_trabalho;     // valida
        NumeroDiasUteis = dias_mes;         // valida
    }

    public double VencimentoHora
    {
        get { return vencimento_hora; }

        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                value, $"{nameof(VencimentoHora)} tem que ser > 0 e < 1");
            }
            vencimento_hora = value;
        }
    }

    public int NumeroDiasUteis
    {
        get { return dias_uteis_mes; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(NumeroDiasUteis)} tem que ser >= 0");
            }
            dias_uteis_mes = value;
        }
    }

    public int HorasTrabalho
    {
        get { return horas_trabalho; }

        set
        {
            if (value < 0 || value > 230)
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                    value, $"{nameof(HorasTrabalho)} tem que ser >= 0 e <= 10 * Numero dias");
            }
            horas_trabalho = value;
        }
    }

    public override double Vencimento()
    {
        int max_horas_normais = 8 * NumeroDiasUteis;

        int max_horas_pagas = 10 * NumeroDiasUteis;

        if (HorasTrabalho > max_horas_pagas)
            HorasTrabalho = max_horas_pagas;

        if (HorasTrabalho <= max_horas_normais)     // sem horas extra
            return VencimentoHora * HorasTrabalho;
        else
            return (max_horas_normais * VencimentoHora) +
                ((HorasTrabalho - max_horas_normais) * VencimentoHora * 1.5);
    }

    public override string ToString() =>
        $"Funcionario (Vencimento Hora): {base.ToString()}" +
        $"Vencimento por Hora: {VencimentoHora:F2}\nDias de trabalho: " +
        $"{NumeroDiasUteis}\nHoras de trabalho: {HorasTrabalho}";
}