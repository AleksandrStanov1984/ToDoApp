// Fix for CS8370: Replace 'using var' with traditional 'using' statement for compatibility with C# 7.3  
// Fix for CS0246: Ensure the required namespace for SQLite is included  

using System;
using System.Collections.Generic;
using System.Data.SQLite; // Ensure this namespace is included for SQLiteConnection  
using DbLibrary.Interfaces;
using DbLibrary.Models;

namespace DbLibrary.Repositories
{
    public class SQLiteTodoRepository : ITodoRepository
    {
        private readonly string _connectionString;

        public SQLiteTodoRepository(string dbPath)
        {
            _connectionString = $"Data Source={dbPath};Version=3;";
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string sql = @"CREATE TABLE IF NOT EXISTS Todos (  
                               Id INTEGER PRIMARY KEY AUTOINCREMENT,  
                               Title TEXT NOT NULL,  
                               IsCompleted INTEGER NOT NULL DEFAULT 0  
                             );";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Add(TodoItem todo)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO Todos (Title, IsCompleted) VALUES (@title, @isCompleted);";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@title", todo.Title);
                    command.Parameters.AddWithValue("@isCompleted", todo.IsCompleted ? 1 : 0);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<TodoItem> GetAll()
        {
            var todos = new List<TodoItem>();
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string sql = "SELECT Id, Title, IsCompleted FROM Todos;";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            todos.Add(new TodoItem
                            {
                                Id = reader.GetInt32(0),
                                Title = reader.GetString(1),
                                IsCompleted = reader.GetInt32(2) == 1
                            });
                        }
                    }
                }
            }
            return todos;
        }

        public void Update(TodoItem todo)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string sql = "UPDATE Todos SET Title = @title, IsCompleted = @isCompleted WHERE Id = @id;";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@title", todo.Title);
                    command.Parameters.AddWithValue("@isCompleted", todo.IsCompleted ? 1 : 0);
                    command.Parameters.AddWithValue("@id", todo.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                string sql = "DELETE FROM Todos WHERE Id = @id;";
                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
