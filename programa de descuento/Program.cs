using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace programa_de_descuento
{
    class Cliente
    {
           
        private float descuento;
        private float precio;
        public void Inicio()
        {
            Console.WriteLine("ingrese el precio: ");
            precio = float.Parse(Console.ReadLine());
            Console.Clear();

        }
        public void Descuento()
        {
            if (precio > 300)
            {
                float res = (precio * 20) / 100;
                descuento = precio - res;
                Console.WriteLine("Mega Plaza");
                Console.WriteLine("DESCUENTO DEL 20% POR SUPERAR Q.300");
                Console.WriteLine("PRECIO ES: " + descuento);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("♠\tMega plaza");

                Console.WriteLine("PRECIO ES: " + precio);
                Console.ReadLine();

            }
            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            Console.WriteLine("\tMega plaza");
            Cliente clie = new Cliente();
            clie.Inicio();
            clie.Descuento();

        }






           
            
        
    }
}
