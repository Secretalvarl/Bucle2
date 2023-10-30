using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucle2.Servicios
{
    internal class OperacionImplementacion : OperacionInterfaz
    {

        public void HacerMultiplicacion(int numero1)
        {
            int i;
         

            for (i = numero1; i >= 1; i--)
            {

                numero1 = i * numero1;
      
            }
            Console.WriteLine("Resultado operacion : " + numero1);
        }

    }
}

