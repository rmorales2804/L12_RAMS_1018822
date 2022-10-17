internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("SUMA DE VECTORES");
        pruebaVector pv = new pruebaVector();
        pv.Cargar();
        pv.Imprimir();
    }
    class pruebaVector
    {
        private int[] numeros;
        public int suma = 0;
        public void Cargar()
        {
            numeros = new int[15];
            for (int f = 0; f < 15; f++)
            {
                Console.WriteLine("Ingresa una nota: ");
                string linea;
                linea = Console.ReadLine();
                numeros[f] = int.Parse(linea);
                suma = suma + numeros[f];
            }
        }
        public void Imprimir()
        {
            
            Console.WriteLine("La suma es : " + suma);
            Console.WriteLine("El promedio es : " + suma/15);

            Console.ReadKey();
        }

    }
}