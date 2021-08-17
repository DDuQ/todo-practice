using Microsoft.WindowsAzure.Storage.Table;
using System;

namespace todoPractice.Functions.Entities
{
    internal class TodoEntity : TableEntity
    {
        public DateTime CreatedTime { get; set; }

        public string TaskDescription { get; set; }

        public bool IsCompleted { get; set; }
    }
}
