using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilidadesRCL.Data.Dtos;

namespace UtilidadesRCL.Data.Interfaces
{
    public interface ITodoService
    {
        Task<IEnumerable<TodoItemDto>> GetTodoItemsAsync();
        Task AddTodoItemAsync(string title);
        Task ToggleTodoItemAsync(Guid id);
        Task DeleteTodoItemAsync(Guid id);

    }
}
