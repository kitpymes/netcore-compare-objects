using System;

namespace CompareObjects.Caso3
{
    /// <summary>
    /// Comparar la igualdad de objetos por identificacion.
    /// ¿ Como hacemos para saber si dos objetos del mismo tipo son iguales, cuando NO tienen los mismos valores en sus campos y NO tienen la misma referencia en memoria ?
    /// </summary>
    public static class Compare
    {
        public static void Start()
        {
            Console.WriteLine("\n------------------Caso3 => Comparar la igualdad de objetos por identificacion.-------------------");

            Caso3.User a = new Caso3.User("1", "Juan", "Garcia");
            Caso3.User b = new Caso3.User("9", "Pedro", "Morales");

            Console.WriteLine("\n- Valores iniciales:\nUser a = new User('1', 'Juan', 'Garcia');\nUser b = new User('9', 'Pedro', 'Morales');\n");
            CompareIdentifierEquals(a, b);

            // Asignamos
            b.Id = "1";

            Console.WriteLine("\n- Asignamos:\nb.Id = '1';\n");
            CompareIdentifierEquals(a, b);
        }

        public static void CompareIdentifierEquals(Caso3.User a, Caso3.User b)
        {
            Console.WriteLine($"a = b por IDENTIFICACION ? ");
            Console.WriteLine($"a.Id.Equals(b.Id): {a.Id.Equals(b.Id)}");
            Console.WriteLine($"(a.Id == b.Id): {a.Id == b.Id}");
        }
    }
}
