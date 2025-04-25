using DbLibrary.Interfaces;
using DbLibrary.Models;
using DbLibrary.Repositories;

namespace DbLibrary
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ITodoRepository repo = new SQLiteTodoRepository("todos.db") as ITodoRepository;
            if (repo == null)
            {
                throw new InvalidCastException("Failed to cast SQLiteTodoRepository to ITodoRepository.");
            }

            repo.Add(new TodoItem { Title = "Проверить библиотеку", IsCompleted = false });

            var items = repo.GetAll();
        }
    }
}
