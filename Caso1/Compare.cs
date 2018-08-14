using System;

namespace CompareObjects.Caso1
{
    /// <summary>
    /// Comparar la igualdad de objetos por referencia.
    /// </summary>
    public static class Compare
    {
        public static void Start()
        {
            Console.WriteLine("\n------------------Caso1 => Comparar la igualdad de objetos por referencia.-------------------");

            User a = new User("Juan");
            User b = new User("Juan");

            Console.WriteLine("\n- Valores iniciales:\nUser a = new User('Juan');\nUser b = new User('Juan');\n");
            CompareObjectsHelper<User>.ReferenceEquals(a, b);

            // Asignamos
            b = a;

            Console.WriteLine("\n- Asignamos:\n b = a;\n");
            CompareObjectsHelper<User>.ReferenceEquals(a, b);
        }
    }
}
