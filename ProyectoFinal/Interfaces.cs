using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Interfaces
    {
        public static string[] Producto = new string[100];
        public static float[] Precio = new float[100];
        public static int[] Cantidad = new int[100];
        public static int contador = 0;
        public static int contadorAL = 0;

        public static string[] Almacen = new string[100];

        public static int PantallaPrincipal()
        {
            Console.Clear();
            string txt = "==================================================\n" +
                "                                              \n" +
                "      Sistema de Inventario ¨Mi Tiendita¨     \n" +
                "                                              \n" +
                "==================================================\n" +
                " 1. Gestionar Productos                       \n" +
                " 2. Gestionar Almacenes                       \n" +
                " 3. Agregar y Extraer Productos               \n" +
                "==================================================\n";
            Console.WriteLine(txt);

            return Operaciones.getEntero("Seleccione una opción y presione Enter: ", txt);
        }
        public static int PantallaGestionarProductos()
        {
            Console.Clear();
            string txt = "--------------------------------------------------\n" +
                "       Gestionar Productos - Mi Tiendita      \n" +
                "--------------------------------------------------\n" +
                "  1.Agregar Producto                          \n" +
                "  2.Eliminar Producto                         \n" +
                "  3.Modificar Producto                        \n" +
                "  4.Mostrar Inventario                        \n" +
                "  5.Volver al Menú Principal                  \n" +
                "--------------------------------------------------\n" +
                "Seleccione una opción: ";
            Console.Write(txt);

            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1) return PantallaAgregarProducto();
            if (opcion == 2) return PantallaEliminarProducto();
            if (opcion == 3) return PantallaModificarProducto();
            if (opcion == 4) return PantallaMostrarInventario();
            if (opcion == 5) return PantallaPrincipal();

            return opcion;
        }
    }
}
