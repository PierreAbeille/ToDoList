
    public class TodoItem
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public DateTime DueDate { get; set; }
        public string Category { get; set; }
        public int Priority { get; set; }
        public string Description { get; set; }

    }
