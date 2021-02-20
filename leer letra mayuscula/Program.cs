using System;

namespace leer_letra_mayuscula
{
    class Program

    {

        public class IsLetterSample
        {
            public static void Main()
            {
                char letra = 'A';
                string lee;
                Console.WriteLine("ingrese una letra");
                lee = Console.ReadLine();
                letra = char.Parse(lee);

                if (char.IsUpper(letra))
                {
                    Console.WriteLine("Es mayuscula");
                }

                else
                {
                    Console.WriteLine("Es minuscula");
                }
                Console.ReadKey();
            }





        }
    }
}
