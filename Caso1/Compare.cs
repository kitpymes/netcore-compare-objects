using System;

namespace CompareObjects.Caso1
{
    /// <summary>
    /// Comparar la igualdad de objetos por referencia.
    /// ¿ Como hacemos para saber si dos objetos del mismo tipo son iguales, cuando NO tienen una key que los identifique(ej. Id unico) y NO tienen los mismos valores en sus campos ?
    /// </summary>
    public static class Compare
    {
        public static void Start()
        {
            Console.WriteLine("\n------------------Caso1 => Comparar la igualdad de objetos por referencia.-------------------");

            Caso1.User a = new Caso1.User("Juan", "Perez");
            Caso1.User b = new Caso1.User("Juan", "Perez");

            Console.WriteLine("\n- Valores iniciales:\nUser a = new User('Juan','Perez');\nUser b = new User('Juan', 'Perez');\n");
            Console.WriteLine($"a = b por REFERENCIA ?: {object.ReferenceEquals(a, b)}");

            // Asignamos
            b = a;

            Console.WriteLine("\n- Asignamos:\n b = a;\n");
            Console.WriteLine($"a = b por REFERENCIA ?: {object.ReferenceEquals(a, b)}");
        }
    }
}
