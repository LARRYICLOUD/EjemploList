using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables necesarias
            int opcion,indice;
            string alumno;

            //Instancia de list
            List<string> Alumnos = new List<string>();
            do
            {
                Console.Clear();

                Console.WriteLine("1. Agregar estudiante");
                Console.WriteLine("2. Eliminar estudiante");
                Console.WriteLine("3. Mostrar estudiantes");
                Console.WriteLine("4. Buscar por nombre");
                //Escojer opcion
                Console.Write("Escoge una opcion:  ");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingresa el nombre del alumno: ");
                        alumno = Console.ReadLine();
                        Alumnos.Add(alumno);
                        break;
                    case 2:
                        Console.Write("Ingrese el numero del estudiante que quiera eliminar:");
                        indice = Convert.ToInt32(Console.ReadLine());
                        indice--; //reducimos a 1 a indice, porque el usuario no sabe que el indice empieza en cero, por lo tanto, si se ingresa 1, en realidad sera cero

                        if(indice >= Alumnos.Count() || indice < 0)
                        {
                            Console.WriteLine("El alumno no existe");
                        }
                        else
                        {
                            string alumnoElim = Alumnos[indice];
                            Alumnos.RemoveAt(indice); //quitamos el alumno de la lista
                            Console.WriteLine("{0} se ha eliminado correctamente, alumnoElim");
                        }
                        Console.Write("\nPresione cualquier tecla para regresar al menu");
                        Console.ReadKey();
                        break;

                    case 3:
                        int i = 1;//Nos sireve para mostrar el indice de los alumnos
                        foreach (string estudiante in Alumnos)
                        {
                            Console.WriteLine("{0}. {1}", i++, estudiante);
                        }
                        Console.Write("\nPresione cualquier tecla para regresar al menu");
                        Console.ReadKey();
                        break;

                        case 4:
                        string encontrarAlum;
                        int j;
                        Console.Write("Ingrese el nombre del estudiante a buscar:    ");
                        alumno = Console.ReadLine();
                        //Verificar si ele elemento (alumno) esta o no en la list
                        if (Alumnos.IndexOf(alumno) >= 0)
                        {
                            encontrarAlum = Alumnos[Alumnos.IndexOf(alumno)]; //Alumno[3]
                            j = Alumnos.IndexOf(alumno) + 1;
                            Console.WriteLine("El estudiante {0} se encuentra en el numero {1} de la lista", encontrarAlum, j);
                        }
                        else
                        {
                            Console.WriteLine("El estudiante {0} no s eencuentra en el sistema", alumno);
                        }
                        Console.Write("\nPresione cualquier tecla para regresar al menu");
                        Console.ReadKey();
                        break;
                }

            }while (opcion >= 1 && opcion <= 4);


        }
    }
}
