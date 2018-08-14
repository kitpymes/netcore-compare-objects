using System;

namespace CompareObjects.Caso2
{
    /// <summary>
    /// Comparar la igualdad de objetos por valores.
    /// </summary>
    public static class Compare
    {
        public static void Start()
        {
            Console.WriteLine("\n------------------Caso2 => Comparar la igualdad de objetos por valores.-------------------");

            User a = new User("Juan", "Perez");
            User b = new User("Pedro", "Perez");

            Console.WriteLine("\n- Valores iniciales:\nUser a = new User('Juan', 'Perez');\nUser b = new User('Pedro', 'Perez');\n");
            CompareObjectsHelper<User>.ValuesEquals(a, b);

            // Asignamos
            b = new User("Juan", "Perez");

            Console.WriteLine("\n- Asignamos:\n b = new User('Juan', 'Perez');\n");
            CompareObjectsHelper<User>.ValuesEquals(a, b);
        }
    }
}
