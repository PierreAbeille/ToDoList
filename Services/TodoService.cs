    public class TodoService
    {

        private List<TodoItem> _todos = new List<TodoItem>();

        public List<TodoItem> GetAll() => _todos;
        public TodoItem GetById(Guid id) => _todos.FirstOrDefault(todo => todo.Id == id);


        public void Add(TodoItem todo)
        {
            _todos.Add(todo);
        }
        public void Delete(Guid id)
        {
            var todo = GetById(id);
            if (todo is null)
            {
                return;
            }
            _todos.Remove(todo);
        }
        // public void Update(TodoItem todo)
        // {
        //     var index = _todos.FindIndex(existingTodo => existingTodo.Id == todo.Id);
        //     if (index == -1)
        //     {
        //         return;
        //     }
        //     _todos[index] = todo;
        // }

        // Get by filter
        public List<TodoItem> GetByFilter(TodoFilter filter)
        {
            return filter switch
            {
                TodoFilter.All => _todos,
                TodoFilter.Active => _todos.Where(todo => !todo.IsDone).ToList(),
                TodoFilter.Completed => _todos.Where(todo => todo.IsDone).ToList(),
                _ => throw new NotImplementedException($"Filter {filter} not implemented"),
            };
        } 
    }