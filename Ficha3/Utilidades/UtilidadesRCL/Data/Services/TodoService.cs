using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilidadesRCL.Data.Dtos;
using UtilidadesRCL.Data.Interfaces;

namespace UtilidadesRCL.Data.Services
{
    public class TodoService : ITodoService
    {
        private readonly List<TodoItemDto> _tarefas = [];

        public Task<IEnumerable<TodoItemDto>> GetTodoItemsAsync()
        {
            return Task.FromResult(_tarefas.AsEnumerable());
        }

        public Task AddTodoItemAsync(string titulo)
        {
            _tarefas.Add(new TodoItemDto { Title = titulo });
            return Task.CompletedTask;
        }

        public Task ToggleTodoItemAsync(Guid id)
        {
            var tarefa = _tarefas.FirstOrDefault(t => t.Id == id);
            if (tarefa is not null)
                tarefa.IsCompleted = !tarefa.IsCompleted;
            return Task.CompletedTask;
        }

        public Task DeleteTodoItemAsync(Guid id)
        {
            var tarefa = _tarefas.FirstOrDefault(t => t.Id == id);
            if (tarefa is not null)
                _tarefas.Remove(tarefa);
            return Task.CompletedTask;
        }
    }
}