using System;

namespace CompareObjects.Caso2
{
    /// <summary>
    /// Comparar la igualdad de objetos por valores.
    /// ¿ Como hacemos para saber si dos objetos del mismo tipo son iguales, cuando NO tienen una key que los identifique(ej. Id unico) y NO tienen la misma referencia en memoria ?
    /// </summary>
    public static class Compare
    {
        public static void Start()
        {
            Console.WriteLine("\n------------------Caso2 => Comparar la igualdad de objetos por valores.-------------------");

            Caso2.User a = new Caso2.User("Juan", "Perez");
            Caso2.User b = new Caso2.User("Pedro", "Perez");

            Console.WriteLine("\n- Valores iniciales:\nUser a = new User('Juan', 'Perez');\nUser b = new User('Pedro', 'Perez');\n");
            CompareValuesEquals(a, b);

            // Asignamos
            b.Name = "Juan";

            Console.WriteLine("\n- Asignamos:\nb.Name = 'Juan';\n");
            CompareValuesEquals(a, b);
        }

        public static void CompareValuesEquals(Caso2.User a, Caso2.User b)
        {
            Console.WriteLine($"- Son iguales por VALOR ?: {a.Equals(b)}");
        }
    }
}
