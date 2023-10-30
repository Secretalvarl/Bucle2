using Bucle2.Servicios;

namespace Bucle2.Controladores
{
    class Program
    {

        public static void Main(string[] args)
        {
            int numero1;

            MenuInterfaz alpha = new MenuImplementacion();

            OperacionInterfaz omega = new OperacionImplementacion();

            string eleccion;

            do
            {
                numero1 = alpha.PedirNumero();
                omega.HacerMultiplicacion(numero1);

                eleccion = alpha.LetraEleccion();

            } while (eleccion == "S");


        }


    }


}


