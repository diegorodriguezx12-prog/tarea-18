static void Main(string[] args)
{
    double sumaPromediosGlobal = 0;
    int contadorEstudiantes = 0;
    int aprobados = 0;
    int reprobados = 0;
    int opcion;

    do
    {
        Console.Clear();
        Console.WriteLine("----- CONTROL DE NOTAS -----");
        Console.WriteLine("1. Registrar estudiante");
        Console.WriteLine("2. Mostrar promedio general");
        Console.WriteLine("3. Mostrar cantidad de aprobados y reprobados");
        Console.WriteLine("4. Salir");
        Console.Write("Seleccione una opción: ");

        opcion = int.Parse(Console.ReadLine());

        if (opcion == 1)
        {
            Console.Write("Nombre del estudiante: ");
            string nombre = Console.ReadLine();

            Console.Write("Nota 1: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Nota 2: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.Write("Nota 3: ");
            double n3 = double.Parse(Console.ReadLine());

            double promedio = (n1 + n2 + n3) / 3;

            string estado = "Reprobado";
            if (promedio >= 61)
            {
                estado = "Aprobado";
                aprobados++;
            }
            else
            {
                reprobados++;
            }

            sumaPromediosGlobal += promedio;
            contadorEstudiantes++;

            Console.WriteLine("--- RESULTADO ---");
            Console.WriteLine("Estudiante: " + nombre);
            Console.WriteLine("Promedio: " + promedio.ToString("F2"));
            Console.WriteLine("Estado: " + estado);
        }
        else if (opcion == 2)
        {
            if (contadorEstudiantes > 0)
            {
                double promedioG = sumaPromediosGlobal / contadorEstudiantes;
                Console.WriteLine("Promedio General: " + promedioG.ToString("F2"));
            }
            else
            {
                Console.WriteLine("No hay estudiantes registrados.");
            }
        }
        else if (opcion == 3)
        {
            Console.WriteLine("Cantidad de Aprobados: " + aprobados);
            Console.WriteLine("Cantidad de Reprobados: " + reprobados);
        }
        else if (opcion == 4)
        {
            Console.WriteLine("Saliendo...");
        }

        if (opcion != 4)
        {
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

    } while (opcion != 4);
}