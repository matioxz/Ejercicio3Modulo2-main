using EjercicioClase3Modulo2EFCore.Data;
using EjercicioClase3Modulo2EFCore.Entities;
using System;
using System.Linq;

namespace EjercicioClase3Modulo2EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ApplicationDbContext())
            {
                // Ejercicio 1: Obtener un listado de todos los actores y actrices de la tabla actor
                var allActors = context.Actor.ToList();
                Console.WriteLine("Todos los actores y actrices:");
                foreach (var actor in allActors)
                {
                    Console.WriteLine($"{actor.Nombre} {actor.Apellido}");
                }

                // Ejercicio 2: Obtener listado de todas las actrices de la tabla actor
                var allActresses = context.Actor.Where(a => a.Genero == "F").ToList();
                Console.WriteLine("\nTodas las actrices:");
                foreach (var actress in allActresses)
                {
                    Console.WriteLine($"{actress.Nombre} {actress.Apellido}");
                }


                // Ejercicio 3: Obtener un listado de todos los actores y actrices mayores de 50 años de la tabla actor
                var actors50 = context.Actor.Where(a => a.Edad > 50).ToList();
                Console.WriteLine("\nActores y actrices mayores de 50 años:");
                foreach (var actor in actors50)
                {
                    Console.WriteLine($"{actor.Nombre} {actor.Apellido} - Edad: {actor.Edad}");
                }

                // Ejercicio 4: Obtener la edad de la actriz "Julia Roberts"
                var juliaRoberts = context.Actor.FirstOrDefault(a => a.Nombre == "Julia" && a.Apellido == "Roberts");
                if (juliaRoberts != null)
                {
                    Console.WriteLine($"\nEdad de Julia Roberts: {juliaRoberts.Edad}");
                }


                // Ejercicio 5: Insertar un nuevo actor en la tabla actor
                var nuevoActor = new Actor
                {
                    Nombre = "Ricardo",
                    Apellido = "Darin",
                    Edad = 67,
                    nombre_artistico = "Ricardo Darin",
                    Nacionalidad = "argentino",
                    Genero = "M"
                };
                context.Actor.Add(nuevoActor);
                context.SaveChanges();
                Console.WriteLine("\nNuevo actor agregado: Ricardo Darin");
               

                // Ejercicio 6: Obtener la cantidad de actores y actrices que no son de Estados Unidos
                var nonUsActorsCount = context.Actor.Count(a => a.Nacionalidad != "USA");
                Console.WriteLine($"\nCantidad de actores y actrices que no son de Estados Unidos: {nonUsActorsCount}");

                // Ejercicio 7: Obtener los nombres y apellidos de todos los actores masculinos
                var maleActors = context.Actor.Where(a => a.Genero == "M").Select(a => new { a.Nombre, a.Apellido }).ToList();
                Console.WriteLine("\nNombres y apellidos de todos los actores masculinos:");
                foreach (var actor in maleActors)
                {
                    Console.WriteLine($"{actor.Nombre} {actor.Apellido}");
                }
            }
        }
    }
}