namespace CompareObjects.Caso3
{
    public class User : EntityBase
    {
        public User(string id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;  
        }

        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
