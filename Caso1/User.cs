namespace CompareObjects.Caso1
{
    public class User : IEntityBase
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }
    }
}
