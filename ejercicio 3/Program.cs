class Program
{
    static void Main()
    {
        int opcion = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("--- UTILIDADES MATEMATICAS ---");
            Console.WriteLine("1. Area de un circulo");
            Console.WriteLine("2. Area de un triangulo");
            Console.WriteLine("3. Factorial de un numero");
            Console.WriteLine("4. Par o Impar");
            Console.WriteLine("5. Salir");
            Console.Write("Opcion: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("Ingrese el radio: ");
                double radio = double.Parse(Console.ReadLine());
                double resultado = CalcularAreaCirculo(radio);
                MostrarResultado("Area del circulo", resultado.ToString());
            }
            else if (opcion == 2)
            {
                Console.Write("Ingrese la base: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Ingrese la altura: ");
                double h = double.Parse(Console.ReadLine());
                double resultado = CalcularAreaTriangulo(b, h);
                MostrarResultado("Area del triangulo", resultado.ToString());
            }
            else if (opcion == 3)
            {
                Console.Write("Ingrese un numero: ");
                int num = int.Parse(Console.ReadLine());
                long resultado = CalcularFactorial(num);
                MostrarResultado("Factorial", resultado.ToString());
            }
            else if (opcion == 4)
            {
                Console.Write("Ingrese un numero: ");
                int num = int.Parse(Console.ReadLine());
                string resultado = DeterminarParImpar(num);
                MostrarResultado("El numero es", resultado);
            }

            if (opcion != 5)
            {
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            }

        } while (opcion != 5);

        double CalcularAreaCirculo(double r)
        {
            return 3.1416 * (r * r);
        }

        double CalcularAreaTriangulo(double baseT, double alturaT)
        {
            return (baseT * alturaT) / 2;
        }

        long CalcularFactorial(int n)
        {
            long fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

        string DeterminarParImpar(int n)
        {
            if (n % 2 == 0)
            {
                return "Par";
            }
            else
            {
                return "Impar";
            }
        }

        void MostrarResultado(string operacion, string valor)
        {
            Console.WriteLine(operacion + ": " + valor);
        }
    }
}
    