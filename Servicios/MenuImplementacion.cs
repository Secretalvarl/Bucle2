using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucle2.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int PedirNumero()
        {

            int numero1;

            Console.WriteLine("Escriba un numero <0.");

            numero1 = Convert.ToInt32(Console.ReadLine());

            return numero1;
        }


        public string LetraEleccion() 
        {
            string eleccion;

            Console.WriteLine("Escreiba una S si decea seguir calculando");
            eleccion = Console.ReadLine();

            return eleccion;
        }
    }
}
