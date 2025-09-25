namespace GestorDeTarefas;

class Program
{
    static void Main(string[] args)
    {
        Utilizador u = new Utilizador("Miguel Renato", new List<Tarefa>());

        //Mock Data
        u.AdicionarTarefa();
        u.AdicionarTarefa("Compras", categoria: TipoCategoria.pessoal); //Aqui precisamos de "categoria:" indicar para que parâmetro queremos saltar quando estamos a omitir parâmetros
        u.AdicionarTarefa("Exame", TipoPrioridade.normal, dataLimite: "30/09/2024 09:30");
        u.AdicionarTarefa("Recurso", TipoPrioridade.normal);
        u.AdicionarTarefa(dataLimite: "30/09/2024 09:30", prioridade: TipoPrioridade.alta);
        u.AdicionarTarefa(dataLimite: "15/05/2024 15:30", estado: TipoEstado.concluida);

        u.AdicionarTarefa(nome: "Concluida", estado: TipoEstado.concluida);
        u.AdicionarTarefa(nome: "Pessoal", categoria: TipoCategoria.pessoal);
        u.AdicionarTarefa(nome: "Baixa", prioridade: TipoPrioridade.baixa);

        //Mock teste
        u.MostraTarefas(u.Tarefas, "\nTodas as Tarefas\n");
        u.MostraTarefas(u.TarefasAtrasadas(DateTime.Now), "\nTarefas Atrasadas\n");

        Console.ReadKey();

        //Porque usamos o Enum.GetValues?
        //Porque vamos iterar as listas onde é possível aparecerem todos os tipos e assim o "Enum.GetValues" automatiza e evita código repetitivo

        foreach (TipoCategoria tipo in Enum.GetValues(typeof(TipoCategoria)))
            u.MostraTarefas(u.ListaDeTarefas(tipo), $"\nCategoria: {tipo.ToString()}\n");

        foreach (TipoPrioridade tipo in Enum.GetValues(typeof(TipoPrioridade)))
            u.MostraTarefas(u.ListaDeTarefas(tipo), $"\nCategoria: {tipo.ToString()}\n");

        foreach (TipoEstado tipo in Enum.GetValues(typeof(TipoEstado)))
            u.MostraTarefas(u.ListaDeTarefas(tipo), $"\nCategoria: {tipo.ToString()}\n");

        u.MostraTarefas(u.RemoverTarefas(TipoEstado.concluida), "\nRetirdas das concluidas");
        u.MostraTarefas(u.RemoverTarefas(TipoCategoria.pessoal), "\nRetirdas das pessoais");
        u.MostraTarefas(u.RemoverTarefas(TipoPrioridade.baixa), "\nRetirdas das baixas");

        Console.ReadKey();
    }
}