using System;
using System.Collections.Generic;
using System.Linq;
namespace EjerciciosLambda
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // List with eah element of type Student 
            List<Estudiante> details = new List<Estudiante>() {
            new Estudiante{ Id = 1, Nombre = "Liza", Apellido="Zambrano", Promedio= 10, Edad=22 },
                new Estudiante{ Id = 2, Nombre = "Stewart",  Apellido="Rivera",Promedio= 9.9M , Edad=19 },
                new Estudiante{ Id = 3, Nombre = "Tina",  Apellido="Mendoza",Promedio= 7.8M, Edad=20  },
                new Estudiante{ Id = 4, Nombre = "Stefani",  Apellido="Pico",Promedio= 5, Edad=18  },
                new Estudiante { Id = 5, Nombre = "Trish",  Apellido="Restrepo",Promedio= 3, Edad=23  }
        };
            //1. Muestre por pantalla los nombres de los estudiantes
            var listaestudiantes = details.Select(item => new { item.Nombre });
            string nombres_estudiantes = string.Join(Environment.NewLine, listaestudiantes);
            Console.WriteLine("--1.los nombres de los estudiantes:--");
            Console.WriteLine(""+ nombres_estudiantes + "\n");

            //2. Muestre por pantalla los nombres y apellidos de los estudiantes ordenados por promedio de mayor a menor
            var nombre_apellido = details.OrderByDescending(ordenados => ordenados.Promedio).Select(ordena2 => new { ordena2.Nombre, ordena2.Apellido });
            string promedios = string.Join(Environment.NewLine, nombre_apellido);
            Console.WriteLine("--2.nombres y apellidos de los estudiantes ordenados por promedio de mayor a menor:--");
            Console.WriteLine("" + promedios + "\n");

            //3. Muestre por pantalla los apellidos de los estudiantes ordenados ascendente alfabéticamente
            var ascendente = details.OrderBy(alfabeticamente => alfabeticamente.Apellido).Select(alfa => new { alfa.Apellido });
            string orden_alfabetico = string.Join(Environment.NewLine, ascendente);
            Console.WriteLine("--3. apellidos de los estudiantes ordenados ascendente alfabéticamente:--");
            Console.WriteLine("" + orden_alfabetico + "\n");

            //4. Muestre por pantalla los datos del estudiante mas joven
            var edad = details.OrderBy(alumno => alumno.Edad).First();
            Console.WriteLine("-- 4. Muestre por pantalla los datos del estudiante mas joven:--");
            Console.WriteLine("ID:");
            Console.WriteLine(string.Join( "",edad.Id , ""));
            Console.WriteLine("Nombre:");
            Console.WriteLine(string.Join("", edad.Nombre, ""));
            Console.WriteLine("Apellido:");
            Console.WriteLine(string.Join("", edad.Apellido, ""));
            Console.WriteLine("Promedio:");
            Console.WriteLine(string.Join("", edad.Promedio, ""));
            Console.WriteLine("Edad:");
            Console.WriteLine(string.Join("", edad.Edad, "\n"));
          
            //EJERCICIO 2

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6 };
            //Dado la siguiente coleccion de datos, utilizando expresiones Lambda:
            //1. Muestre por pantalla el cuadrado de los números
            var cuadrado = list.Select(numero => numero * 2);
            Console.WriteLine("------EJERCICIO 2------");
            Console.WriteLine("----1. el cuadrado de los números es:----");
            Console.WriteLine(string.Join("  ", cuadrado));

            //2. Muestre por pantalla los números pares
            Func<int, bool> NumerosPares = (numero2) => numero2 % 2 == 0;
            var Pares = list.Where(NumerosPares);
            Console.WriteLine("----2. los números pares son:----");
            Console.WriteLine(string.Join("  ", Pares));

            //3. Muestre por pantalla el resultado de multiplicar por 5 los numero impares
            var Impares = list.Where((numero3) => numero3 % 2 != 0).Select(numero3 => numero3 * 5);
            string imparesporcinco = string.Join(Environment.NewLine, Impares);
            Console.WriteLine("----3. el resultado de multiplicar por 5 los numero impares es:----");
            Console.WriteLine(string.Join("  ", imparesporcinco));
           



        }
    }
}
