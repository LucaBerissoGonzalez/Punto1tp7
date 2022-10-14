using System;

namespace Punto1tp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string curso, turno;
            int cAlumnos, nota = 0 , acumulador = 0;
            float promedio;

            Console.WriteLine("Bienvenido al Programa que Promedia las notas de los alumnos de un curso!");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ingrese el Año del curso:");
            curso = Console.ReadLine();

            Console.WriteLine("Ingrese el turno del curso(Turno Mañana - Turno Tarde - Turno Noche):");
            turno = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Ingrese la Cantidad de alumnos del curso:");
            cAlumnos = Convert.ToInt32(Console.ReadLine());


            for(int i=1; i < cAlumnos+1; i++)
            {
                Console.Clear();

                Console.WriteLine("Ingrese la nota del Alumno {0}", i);
                nota = Convert.ToInt32(Console.ReadLine());

                nota = nota + acumulador;
                acumulador = nota;

            }

            Console.Clear();

            promedio = nota / cAlumnos;

            Console.WriteLine("{0} - {1} - Promedio: {2}",curso, turno, promedio);
            Console.ReadKey();


        }
    }
}
