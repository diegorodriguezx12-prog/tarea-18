class Program
{
    static void Main()
    {
        double sumaPromedios = 0;
        int totalEstudiantes = 0;
        int aprobados = 0;
        int reprobados = 0;
        int opcion = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("--- CONTROL DE NOTAS ---");
            Console.WriteLine("1. Registrar estudiante");
            Console.WriteLine("2. Mostrar promedio general");
            Console.WriteLine("3. Mostrar aprobados y reprobados");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opcion: ");

            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                // Registro de datos
                Console.Write("Nombre del estudiante: ");
                string nombre = Console.ReadLine();

                Console.Write("Nota 1: ");
                double n1 = double.Parse(Console.ReadLine());
                Console.Write("Nota 2: ");
                double n2 = double.Parse(Console.ReadLine());
                Console.Write("Nota 3: ");
                double n3 = double.Parse(Console.ReadLine());

                // Cálculo del promedio
                double promedio = (n1 + n2 + n3) / 3;

                string estado = "";
                if (promedio >= 61)
                {
                    estado = "Aprobado";
                    aprobados = aprobados + 1;
                }
                else
                {
                    estado = "Reprobado";
                    reprobados = reprobados + 1;
                }

                sumaPromedios = sumaPromedios + promedio;
                totalEstudiantes = totalEstudiantes + 1;

                Console.WriteLine("--- DATOS DEL ESTUDIANTE ---");
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Promedio: " + promedio);
                Console.WriteLine("Estado: " + estado);
            }
            else if (opcion == 2)
            {
                if (totalEstudiantes > 0)
                {
                    double promedioG = sumaPromedios / totalEstudiantes;
                    Console.WriteLine("El promedio general es: " + promedioG);
                }
                else
                {
                    Console.WriteLine("No hay estudiantes registrados.");
                }
            }
            else if (opcion == 3)
            {
                Console.WriteLine("Total Aprobados: " + aprobados);
                Console.WriteLine("Total Reprobados: " + reprobados);
            }

            if (opcion != 4)
            {
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 4);
    }
}