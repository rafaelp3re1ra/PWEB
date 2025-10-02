namespace EmpresaFuncionarios;

class EmpresaFuncionariosMain
{
    static void Main(string[] args)
    {
        // Lista dos funcionarios da empresa

        List<Funcionario> funcionarios = new(); // Lista genérica onde cabem todos os funcionários

        double premio = 100.00;

        // Funcionarios
        var f_vencimento_base = new FuncionarioVencimentoBase("João", "Silva", "123123123", 1000.00);
        funcionarios.Add(f_vencimento_base);
        var f_vencimento_hora = new FuncionarioVencimentoHora("Mariana", "Semedo", "234234234", 10.0, 180, 20);
        funcionarios.Add(f_vencimento_hora);
        var f_comissao = new FuncionarioComissao("Nelson", "Barros", "345345345", 10000.00, .06);
        funcionarios.Add(f_comissao);
        var f_base_mais_comissao = new FuncionarioBaseMaisComissao("Renato Miguel", "Neves", "456456456", 5000.0, .04, 600.00);
        funcionarios.Add(f_comissao);

        // Descrição do tipo de funcionarios da empresa
        for (int j = 0; j < funcionarios.Count; j++)
            Console.WriteLine($"Funcionario {j} : {funcionarios[j].GetType()}"); // Imprime de acordo com o tipo de funcionario.
                                                                                 // Utiliza o ToString() que já está formatado para tal.
        Console.WriteLine();

        foreach (var func in funcionarios)
        {
            Console.WriteLine(func); // usa ToString();

            if (premio > 0.0 && funcionarios is FuncionarioBaseMaisComissao) // O is compacta melhor o código
            {
                var func_premio = (FuncionarioBaseMaisComissao)func;

                func_premio.VencimentoBase += premio;
                Console.WriteLine($"Vencimento Base com premio= {func_premio.VencimentoBase}");
            }
            Console.WriteLine($"Vencimento Final = {func.Vencimento():F2}\n");
        }
        Console.ReadKey();
    }
}