using System;
using CoreEscuela.Entidades;

namespace Estapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Howarts", 1990);
            escuela.pais = "Inglaterra";
            escuela.ciudad = "Londres";
            escuela.typeSchool = TiposEscuela.Primaria;
            Console.WriteLine("Bienvenido a " + escuela.Nombre);
        }
    }
}