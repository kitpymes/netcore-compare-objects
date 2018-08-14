using System;

namespace CompareObjects.Caso3
{
    /// <summary>
    /// Comparar la igualdad de objetos por identificacion.
    /// </summary>
    public static class Compare
    {
        public static void Start()
        {
            Console.WriteLine("\n------------------Caso3 => Comparar la igualdad de objetos por identificacion.-------------------");

            User a = new User("1", "Juan");
            User b = new User("9", "Pedro");

            Console.WriteLine("\n- Valores iniciales:\nUser a = new User('1', 'Juan');\nUser b = new User('9', 'Pedro');\n");
            CompareObjectsHelper<User>.IdentifierEquals(a, b);

            // Asignamos
            b = new User("1", "Carlos");

            Console.WriteLine("\n- Asignamos:\n b = new User('1', 'Carlos');\n");
            CompareObjectsHelper<User>.IdentifierEquals(a, b);
        }
    }
}
