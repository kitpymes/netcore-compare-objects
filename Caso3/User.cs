namespace CompareObjects.Caso3
{
    public class User : EntityBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public User(string id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;  
        }
    }
}
