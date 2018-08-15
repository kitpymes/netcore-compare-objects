namespace CompareObjects.Caso2
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public User(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        #region Equals

        public override bool Equals(object obj)
        {
            var other = obj as User;

            if (other is null)
                return false;

            if (this.GetType() != other.GetType())
                return false;

            // Verificamos la igualdad de valores.
            return (Name == other.Name) && (Surname == other.Surname);
        }

        public static bool operator ==(User a, User b)
        {
            if (a is null && b is null)
                return true;

            if (a is null || b is null)
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(User a, User b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (this.GetType().ToString() + Name + Surname).GetHashCode();
        }

        #endregion Equals
    }
}
