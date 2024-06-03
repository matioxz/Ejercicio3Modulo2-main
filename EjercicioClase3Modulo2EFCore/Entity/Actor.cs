using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Entities/Actor.cs
namespace EjercicioClase3Modulo2EFCore.Entities
{
    public class Actor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string nombre_artistico { get; set; }
        public int Edad { get; set; }
        public string Nacionalidad { get; set; }
        public string Genero { get; set; }
    }
}
