namespace CompareObjects.Caso3
{
    public abstract class EntityBase : IEntityBase
    {
        public string Id { get; set; }
        protected virtual object Actual => this;

        public override bool Equals(object obj)
        {
            var other = obj as EntityBase;

            if (other is null)
                return false;

            // Verifica la igualdad de referencia.
            if (ReferenceEquals(this, other))
                return true;

            if (Actual.GetType() != other.Actual.GetType())
                return false;

            // Verifica la igualdad del identificador.
            return Id == other.Id;
        }

        public static bool operator ==(EntityBase a, EntityBase b)
        {
            if (a is null && b is null)
                return true;

            if (a is null || b is null)
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(EntityBase a, EntityBase b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (Actual.GetType().ToString() + Id).GetHashCode();
        }
    }
}
