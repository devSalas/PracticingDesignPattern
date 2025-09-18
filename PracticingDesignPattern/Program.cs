// See https://aka.ms/new-console-template for more information
using PracticingDesignPattern.Creational.Singleton;

Console.WriteLine("=== Patrón Singleton ===");

var logger1 = Logger.Instance;
logger1.Log("Este es el primer mensaje");

var logger2 = Logger.Instance;
logger2.Log("Este es el segundo mensaje");

Console.WriteLine($"¿Logger1 y Logger2 son la misma instancia? {logger1 == logger2}");
