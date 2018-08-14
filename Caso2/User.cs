using System;

namespace CompareObjects.Caso2
{
    public class User : IEntityBase
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public User(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        #region Equals

        protected virtual object Actual => this;

        public override bool Equals(object obj)
        {
            var other = obj as User;

            if (other is null)
                return false;

            if (Actual.GetType() != other.Actual.GetType())
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
            return (Actual.GetType().ToString() + Guid.NewGuid()).GetHashCode();
        }

        #endregion Equals
    }
}
