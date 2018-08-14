namespace CompareObjects.Caso3
{
    public class User : EntityBase
    {
        public User(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Name { get; set; }
    }
}
