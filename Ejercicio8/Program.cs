using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Insertar();

            //Creo un metodo donde capturo toda la info
            void Insertar() {
            Console.WriteLine("***** BIENVENIDO APP COLEGIO AGUILAR *****");
            Console.WriteLine();
            Console.WriteLine("----- MODO INSERTAR");

                //pido datos del aula para meterlo en el objeto
            Console.WriteLine("---- Inserte datos del aula: ");
            Console.WriteLine("ID: ");
            string id_aula = Console.ReadLine();
            Console.WriteLine("Nº máximo de estudiantes: ");
            string num_estudiantes = Console.ReadLine();
            Console.WriteLine("Asignatura/materia (Matemáticas | Filosofía | Física ): ");
            string materia = Console.ReadLine();

                //pido datos del profe
            Console.WriteLine();
            Console.WriteLine("---- Inserta datos del profesor");
            Console.WriteLine("Nombre y apellidos: ");
            string nombre_profe = Console.ReadLine();
            Console.WriteLine("Sexo (H o M): ");
            string sexo_profe = Console.ReadLine();
            Console.WriteLine("Edad: ");
            string edad_profe = Console.ReadLine();
            Console.WriteLine("Materia que imparte (Matemáticas | Filosofía | Física ): ");
            string materia_profe = Console.ReadLine();

                //creo el objeto aula, q a su vez tiene como atributo un objeto profe
            Aula A1 = new Aula(Convert.ToInt32(id_aula),Convert.ToInt32(num_estudiantes),materia,new Profesor(nombre_profe,Convert.ToChar(sexo_profe),Convert.ToInt32(edad_profe),materia_profe));

                //genero un array de objetos estudiantes de tamaño del número del aula
            Estudiante[] ListaEstudiantes = new Estudiante[Convert.ToInt32(num_estudiantes)];


            Random aleatorio = new Random();

                //listas de nombres y apellidos
            string[] nombresHombre = { "Luis", "Pedro", "Manuel", "Francisco", "Juan", "Andrés", "Santi", "Carlos", "Jorge", "Diego", "Mario", "Alex", "Antonio" };
            string[] nombresMujer = { "Lucía", "Ana", "Andrea", "Cristina", "María", "Lara", "Bea", "Cris", "Paula", "Pilar", "Rocio", "Esther", "Raquel", "Daniela" };
            string[] apellidos = { "García", "Marín", "Gómez", "Castaño", "del Valle", "Longas", "Carrasco", "Cano", "Martínez", "Sanchez", "Martín", "Álvarez", "Mateo", "Ramos", "Carvajal", "Fernández" };
            string nombre_estudiante = "";

                //recorro array estudiantes
            for (int i = 0; i < ListaEstudiantes.Length; i++)
            {
                char sexo_estudiante = ' ';
                if (aleatorio.Next(1, 3) == 1) // a partir de un aleatorio determino si es hombre o mujer
                {
                        //si es hombre cojo sexo y genero nombre de chico
                    sexo_estudiante = 'H'; 
                    nombre_estudiante = nombresHombre[aleatorio.Next(0,nombresHombre.Length-1)] + " " + apellidos[aleatorio.Next(0, apellidos.Length - 1)];

                }
                else
                {
                        //si es mujer cojo sexo y genero nombre de chica
                        sexo_estudiante = 'M';
                    nombre_estudiante = nombresMujer[aleatorio.Next(0, nombresMujer.Length - 1)] + " " + apellidos[aleatorio.Next(0, apellidos.Length - 1)];

                }

                //guardo un objeto estudiante con sus atributos en la posicion i del array
                ListaEstudiantes[i] = new Estudiante(nombre_estudiante,sexo_estudiante,aleatorio.Next(12,30),aleatorio.Next(0,11));
            }

            Console.WriteLine();
            Console.WriteLine();

                //llamo al metodo q muestra la info
                Mostar(ListaEstudiantes, A1);
            }

            void Mostar(Estudiante[] ListaEstudiantes,Aula A1) {
                Console.WriteLine("----- RESULTADO");
                Console.WriteLine();
                Console.WriteLine("Información del profesor: " + A1.Profe.ToString());//muestro datos profe
                Console.WriteLine();

                int contador_disponibles = 0;

                //compruebo cuantos alumnos han ido a clase
                for (int i = 0; i < ListaEstudiantes.Length; i++)
                {
                    if (ListaEstudiantes[i].Disponible == true)
                    {
                        contador_disponibles++;
                    }
                }

                //conclusion final. compruebo las 3 condiciones
                if (A1.Profe.Disponible == true && A1.Materia == A1.Profe.Materia && Convert.ToDouble(contador_disponibles) / Convert.ToDouble(num_estudiantes) >= 0.5)
                {
                    //sii se cumplen muestro el % de asistencia y muestro chicas y chicos
                    Console.WriteLine("IMPORTANTE: Si que se puede dar clase. Ha asistido el {0}% de estudiantes", Convert.ToDouble(contador_disponibles) / Convert.ToDouble(num_estudiantes) * 100);
                    Console.WriteLine();
                    Console.WriteLine("Listado de alumnas: ");
                    for (int i = 0; i < ListaEstudiantes.Length; i++)
                    {
                        if (ListaEstudiantes[i].Sexo == 'M')
                            Console.WriteLine(ListaEstudiantes[i].ToString());
                    }
                    Console.WriteLine();
                    Console.WriteLine("Listado de alumnos: ");
                    for (int i = 0; i < ListaEstudiantes.Length; i++)
                    {
                        if (ListaEstudiantes[i].Sexo == 'H')
                            Console.WriteLine(ListaEstudiantes[i].ToString());
                    }
                }
                else
                {
                    // si no se cumple fuera
                    Console.WriteLine("IMPORTANTE: No se puede dar clase.");
                }




            }
        }
    }
}
