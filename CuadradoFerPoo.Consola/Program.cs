using CuadradoFerPoo.Entidades;

namespace CuadradoFerPoo.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trabajo con Cuadrados");
            Console.Write("Ingrese la medida del lado:");
            var medidaLado = int.Parse(Console.ReadLine());
            Cuadrado c = new Cuadrado(medidaLado);
            Cuadrado c2 = c;
            if (c.Validar())
            {
                Console.WriteLine($"Cuadrado de lado {c.Lado} tiene un perímetro de {c.GetPerimetro()}");
                Console.WriteLine($"Cuadrado de lado {c.Lado} tiene una superficie de {c.GetSuperficie()}");

            }
            else
            {
                Console.WriteLine("Cuadrado no válido... Chequear el valor del lado!!!");
            }
            c2.Lado = 15;
            if (c2.Validar())
            {
                Console.WriteLine($"Cuadrado de lado {c.Lado} tiene un perímetro de {c.GetPerimetro()}");
                Console.WriteLine($"Cuadrado de lado {c.Lado} tiene una superficie de {c.GetSuperficie()}");

            }
            else
            {
                Console.WriteLine("Cuadrado no válido... Chequear el valor del lado!!!");
            }

        }
    }
}