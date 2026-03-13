class Program
{
    static void Main()
    {
        double acumuladoVentas = 0;
        int contadorVentas = 0;
        double ventaMayor = 0;
        int opcion = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("1. Registrar venta");
            Console.WriteLine("2. Total vendido");
            Console.WriteLine("3. Promedio de ventas");
            Console.WriteLine("4. Venta mayor");
            Console.WriteLine("5. Salir");
            Console.Write("Opcion: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("Producto: ");
                string producto = Console.ReadLine();
                Console.Write("Cantidad: ");
                int cant = int.Parse(Console.ReadLine());
                Console.Write("Precio: ");
                double precio = double.Parse(Console.ReadLine());

                double totalVenta = cant * precio;

                acumuladoVentas = acumuladoVentas + totalVenta;
                contadorVentas = contadorVentas + 1;

                if (totalVenta > ventaMayor)
                {
                    ventaMayor = totalVenta;
                }

                Console.WriteLine("--- TICKET ---");
                Console.WriteLine("Producto: " + producto);
                Console.WriteLine("Total: " + totalVenta);
            }
            else if (opcion == 2)
            {
                Console.WriteLine("Total acumulado: " + acumuladoVentas);
            }
            else if (opcion == 3)
            {
                if (contadorVentas > 0)
                {
                    double promedioV = acumuladoVentas / contadorVentas;
                    Console.WriteLine("Promedio: " + promedioV);
                }
            }
            else if (opcion == 4)
            {
                Console.WriteLine("Venta mas alta: " + ventaMayor);
            }

            if (opcion != 5)
            {
                Console.WriteLine("Presione una tecla...");
                Console.ReadKey();
            }
        } while (opcion != 5);
    }
}