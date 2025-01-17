namespace Todo.Components.Pages
{
    public partial class Todo
    {
        private List<TodoItem> todos = new();
        string newTodo = "";

        void addTodo()
        {

            if (!string.IsNullOrWhiteSpace(newTodo))
            {
                todos.Add(new TodoItem { Title = newTodo });
                newTodo = string.Empty;
            }

        }

        void removeTodo()
        {

            todos = todos.Where(todo => !todo.IsDone).ToList();

        }

    }
}