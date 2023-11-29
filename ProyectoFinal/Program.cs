using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = Interfaces.PantallaPrincipal();
            do
            {
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        opcion = Interfaces.PantallaGestionarProductos();
                        break;
                    case 2:
                        opcion = Interfaces.PantallaGestionarAlmacenes();
                        break;
                    case 3:
                        opcion = Interfaces.PantallaAgregaryExtraerProductos();
                        break;
                    case 0:
                    default:
                        opcion = Interfaces.PantallaPrincipal();
                        break;
                }
            } while (opcion != 4);

            Console.ReadKey();
        }
    }
}