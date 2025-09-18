namespace GestorDeTarefas;


class Utilizador
{
    public string Nome { get; }
    public List<Tarefa> Tarefas { get; }

    public Utilizador(string nome, List<Tarefa> tarefas)
    {
        Nome = nome;
        Tarefas = tarefas;
    }

    //Os valores que estão nos tipos são os valores default.
    //Quando chamamos o método, podemos omitir esses valores que
    //são preenchidos. Caso se indique alguma coisa, ele preenche
    //com o que foi indicado.

    public void AdicionarTarefa(string nome = null,
        TipoPrioridade prioridade = TipoPrioridade.alta,
        TipoCategoria categoria = TipoCategoria.trabalho,
        TipoEstado estado = TipoEstado.executar,
        string dataLimite = null) //Está em string porque o html é só texto. Assim recebe tudo "mastigado"
    {
        DateTime dataReg = DateTime.Now;

        if (string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome)) nome = "Tarefa";

        //Aqui tenta converter o dataLimite de string para DateTime
        //Out é um parâmetro de saída. É como se fosse um return. (Coloca o valor de dataLimite em dataLim?)
        if (!DateTime.TryParse(dataLimite, out DateTime dataLim))
            dataLim = dataReg.AddHours(24);

        Tarefas.Add(new Tarefa(nome, prioridade, categoria, estado, dataReg, dataLim));
    }

    //NOTA IMPORTANTE:
    //int a; -> a = 5, ok | a = null, no no
    //int? b; -> b = 10 ok | b = null, ok

    public List<Tarefa> TarefasAtrasadas(DateTime data)
    {
        List<Tarefa> tarefasAtrasadas = new List<Tarefa>();

        foreach (Tarefa tarefa in Tarefas)
            if (tarefa.DataLimite < data && tarefa.Estado != TipoEstado.concluida)
                tarefasAtrasadas.Add(tarefa);

        return tarefasAtrasadas;
    }

    public List<Tarefa> ListaDeTarefas(TipoPrioridade tipo)
    {
        List<Tarefa> lista = new List<Tarefa>();
        foreach (Tarefa tarefa in Tarefas)
            if (tarefa.Prioridade == tipo) lista.Add(tarefa);
        return lista;
    }

    public List<Tarefa> ListaDeTarefas(TipoCategoria tipo)
    {
        List<Tarefa> lista = new List<Tarefa>();
        foreach (Tarefa tarefa in Tarefas)
            if (tarefa.Categoria == tipo) lista.Add(tarefa);
        return lista;
    }

    public List<Tarefa> ListaDeTarefas(TipoEstado tipo)
    {
        List<Tarefa> lista = new List<Tarefa>();
        foreach (Tarefa tarefa in Tarefas)
            if (tarefa.Estado == tipo) lista.Add(tarefa);
        return lista;
    }

    public List<Tarefa> RemoverTarefas(TipoEstado tipo)
    {
        foreach (Tarefa p in ListaDeTarefas(tipo)) Tarefas.Remove(p);
        return Tarefas;
    }

    public List<Tarefa> RemoverTarefas(TipoCategoria tipo)
    {
        foreach (Tarefa p in ListaDeTarefas(tipo)) Tarefas.Remove(p);
        return Tarefas;
    }

    public List<Tarefa> RemoverTarefas(TipoPrioridade tipo)
    {
        foreach (Tarefa p in ListaDeTarefas(tipo)) Tarefas.Remove(p);
        return Tarefas;
    }

    public void MostraTarefas(List<Tarefa> lista, string titulo = null)
    {
        if (titulo != null) Console.WriteLine(titulo);

        foreach (Tarefa tarefa in lista) tarefa.MostrarTarefa();
    }
}