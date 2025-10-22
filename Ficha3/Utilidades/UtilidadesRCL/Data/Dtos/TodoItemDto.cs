using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilidadesRCL.Data.Dtos
{
    public class TodoItemDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now; 
    }
}
