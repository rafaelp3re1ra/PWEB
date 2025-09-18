namespace GestorDeTarefas;

class Main
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
        u.AdicionarTarefa(nome: "Pessoal", categoria: TipoPrioridade.pessoal);
        u.AdicionarTarefa(nome: "Baixa", prioridade, prioridade: TipoPrioridade.baixa);

        //Mock teste
        u.MostraTarefas(u.Tarefas, "\nTodas as Tarefas\n");
        u.MostraTarefas(u.TarefasAtrasdas(DateTime.Now), "\nTarefas Atrasadas\n");

    }
}