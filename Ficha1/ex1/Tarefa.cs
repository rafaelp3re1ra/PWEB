namespace ex1;

enum TipoPrioridade { baixa, normal, alta };
enum TipoCategoria { pessoal, trabalho };
enum TipoEstado { executar, execucao, concluida };

class Tarefa
{
    public TipoPrioridade Prioridade { get; }
    public TipoCategoria Categoria { get; }
    public TipoEstado Estado { get; }
    public string Nome { get; }
    public DateTime DataRegisto { get; }
    public DateTime DataLimite { get; }
    public Tarefa(string nome,
                    TipoPrioridade prioridade, TipoCategoria categoria,
                    TipoEstado estado, DateTime dataRegisto, DateTime dataLimite)
    {
        Prioridade = prioridade;
        Categoria = categoria;
        Estado = estado;
        Nome = nome;
        DataRegisto = dataRegisto;
        DataLimite = dataLimite;
    }
}