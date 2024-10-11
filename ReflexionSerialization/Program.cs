﻿namespace ReflexionSerialization
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var obj = F.Get();

            var objects = new List<F>();
            for (int i = 0; i < 100; i++)
            {
                objects.Add(F.GetRandom());
            }

            /*// Сериализация и десериализация с помощью рефлексии
            ICSVSerializator reflectionSerializator = new CSVReflexionSerializator();
            var reflectionResult = reflectionSerializator.CheckSerializationTime(obj);
            var reflectionDeserializationResult = reflectionSerializator.CheckDeserializationTime<F>(reflectionResult.SerializedString);
            Console.WriteLine($"Reflection serialization time: {reflectionResult.SerializationTime} ms");
            Console.WriteLine("Reflection serialized string:");
            Console.WriteLine();
            Console.WriteLine(reflectionResult.SerializedString);
            Console.WriteLine();
            Console.WriteLine($"Reflection deserialization time: {reflectionDeserializationResult.DeserializationTime} ms");
            Console.WriteLine();
            Console.WriteLine();

            var reflectionResult100 = reflectionSerializator.CheckIEnumerableSerializationTime<F>(objects);
            var reflectionDeserializationResult100 = reflectionSerializator.CheckIEnumerableDeserializationTime<F>(reflectionResult100.SerializedString);
            Console.WriteLine($"Reflection serialization time: {reflectionResult100.SerializationTime} ms");
            Console.WriteLine("Reflection serialized string:");
            Console.WriteLine();
            Console.WriteLine(reflectionResult100.SerializedString);
            Console.WriteLine();
            Console.WriteLine($"Reflection deserialization time: {reflectionDeserializationResult100.DeserializationTime} ms");
            Console.WriteLine();
            Console.WriteLine();*/

            // Сериализация и десериализация с помощью Newtonsoft.Json
            ICSVSerializator jsonSerializator = new CSVNewtonsoftSerializator();
            var jsonResult = jsonSerializator.CheckSerializationTime(obj);
            var jsonDeserializationResult = jsonSerializator.CheckDeserializationTime<F>(jsonResult.SerializedString);
            Console.WriteLine($"JSON serialization time: {jsonResult.SerializationTime} ms");
            Console.WriteLine("JSON serialized string:");
            Console.WriteLine();
            Console.WriteLine(jsonResult.SerializedString);
            Console.WriteLine();
            Console.WriteLine($"JSON deserialization time: {jsonDeserializationResult.DeserializationTime} ms");
            Console.WriteLine();
            Console.WriteLine();

            var jsonResult100 = jsonSerializator.CheckIEnumerableSerializationTime(objects);
            var jsonDeserializationResult100 = jsonSerializator.CheckIEnumerableDeserializationTime<F>(jsonResult100.SerializedString);
            Console.WriteLine($"JSON serialization time: {jsonResult100.SerializationTime} ms");
            Console.WriteLine("JSON serialized string:");
            Console.WriteLine();
            Console.WriteLine(jsonResult100.SerializedString);
            Console.WriteLine();
            Console.WriteLine($"JSON deserialization time: {jsonDeserializationResult100.DeserializationTime} ms");
            Console.WriteLine();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
