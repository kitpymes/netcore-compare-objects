using System;

namespace CompareObjects
{
    public static class CompareObjectsHelper<T> where T : IEntityBase
    {
        public static void ValuesEquals(T a, T b)
        {
            Console.WriteLine($"- Son iguales por VALOR ?: {a.Equals(b)}");
        }

        public static void ReferenceEquals(T a, T b)
        {
            Console.WriteLine($"- Son iguales por REFERENCIA ?: {object.ReferenceEquals(a, b)}");
        }

        public static void IdentifierEquals(T a, T b)
        {
            Console.WriteLine("- Son iguales por IDENTIFICACION ?:");
            Console.WriteLine($"a.Id.Equals(b.Id): {a.Id.Equals(b.Id)}");
            Console.WriteLine($"(a.Id == b.Id): {a.Id == b.Id}");
        }
    }
}
