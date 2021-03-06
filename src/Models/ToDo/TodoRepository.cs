﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace NetCoreAspTodoApi.Models.ToDo
{
    public class TodoRepository : ITodoRepository
    {
        private static ConcurrentDictionary<string, TodoItem> _todos = new ConcurrentDictionary<string, TodoItem>();

        public TodoRepository()
        {
            //Add(new TodoItem { Name = "Item1" });
            Add(new TodoItem { Name = "Item1" });
            Add(new TodoItem { Name = "Asoka" });
            Add(new TodoItem { Name = "Trippledex" });
            Add(new TodoItem { Name = "It" });
            Add(new TodoItem { Name = "Wrapsafe" });
            Add(new TodoItem { Name = "Viva" });
            Add(new TodoItem { Name = "Greenlam" });
            Add(new TodoItem { Name = "Fintone" });
            Add(new TodoItem { Name = "Wrapsafe" });
            Add(new TodoItem { Name = "Konklux" });
            Add(new TodoItem { Name = "Tampflex" });
            Add(new TodoItem { Name = "Zontrax" });
        }

        public void Add(TodoItem item)
        {
            item.Key = Guid.NewGuid().ToString();
            _todos[item.Key] = item;
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return _todos.Values;
        }

        public TodoItem Find(string key)
        {
            TodoItem item;
            _todos.TryGetValue(key, out item);
            return item;
        }

        public TodoItem Remove(string key)
        {
            TodoItem item;
            _todos.TryRemove(key, out item);
            return item;
        }

        public void Update(TodoItem item)
        {
            _todos[item.Key] = item;
        }
    }
}
