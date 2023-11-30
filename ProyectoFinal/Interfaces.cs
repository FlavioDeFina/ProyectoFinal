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

        public static int PantallaAgregarProducto()
        {
            Console.Clear();
            string txt = "===== Pantalla para Agregar Producto =====\n" +
                "--------------------------------------------------\n" +
                "Ingrese el nombre del producto: ";
            Console.Write(txt);

            string nombreProducto = Console.ReadLine();

            float precioProducto = Operaciones.getDecimal("Ingrese el precio del producto: ", txt);

            int cantidadProducto = Operaciones.getEntero("Ingrese la cantidad del producto: ", txt);

            string txt2 = "--------------------------------------------------\n" +
                "Confirmación: Producto agregado exitosamente.\n";
            Console.Write(txt2);

            Producto[contador] = nombreProducto;
            Precio[contador] = precioProducto;
            Cantidad[contador] = cantidadProducto;
            contador++;

            Console.ReadLine();

            return PantallaGestionarProductos();
        }

        public static int PantallaEliminarProducto()
        {
            Console.Clear();
            string txt = "===== Pantalla para Eliminar Producto =====\n" +
                 "--------------------------------------------------\n" +
                 "Ingrese el nombre del producto a eliminar: ";
            Console.Write(txt);

            string elementoAEliminar = Console.ReadLine();

            int indiceAEliminar = -1;
            for (int i = 0; i < contador; i++)
            {
                if (Producto[i] == elementoAEliminar)
                {
                    indiceAEliminar = i;
                }
            }

            if (indiceAEliminar != -1)
            {
                for (int i = indiceAEliminar; i < contador - 1; i++)
                {
                    Producto[i] = Producto[i + 1];
                    Precio[i] = Precio[i + 1];
                    Cantidad[i] = Cantidad[i + 1];
                }

                contador--;
            }

            string txt2 = "--------------------------------------------------\n" +
                "Confirmación: Producto eliminado exitosamente\n";
            Console.Write(txt2);

            Console.ReadLine();
            return PantallaGestionarProductos();
        }

        public static int PantallaModificarProducto()
        {
            Console.Clear();
            string txt = "===== Pantalla para Modificar Producto =====\n" +
             "--------------------------------------------------\n" +
             "Ingrese el nombre del producto a modificar: ";
            Console.Write(txt);

            string product = Console.ReadLine();
            float nuevoPrecio = Operaciones.getDecimal("Ingrese el nuevo precio: ", txt);
            int nuevaCantidad = Operaciones.getEntero("Ingrese la nueva cantidad: ", txt);

            int posicion = 0;
            for (int i = 0; i < contador; i++)
            {
                if (Producto[i] == product)
                {
                    posicion = i;

                    Precio[posicion] = nuevoPrecio;
                    Cantidad[posicion] = nuevaCantidad;
                }
            }

            string txt2 = "--------------------------------------------------\n" +
                "Confirmación: Producto modificado exitosamente.";
            Console.Write(txt2);

            Console.ReadLine();
            return PantallaGestionarProductos();
        }

        public static int PantallaMostrarInventario()
        {
            Console.Clear();
            string txt = "===== Pantalla para Mostrar Inventario =====\n" +
                "--------------------------------------------------\n" +
                "Inventario Actual: \n";
            Console.Write(txt);

            if (contador == 0)
            {
                Console.WriteLine("No existe inventario");
            }

            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine("Producto " + (i + 1) + ": " + Producto[i] + " - Precio: " + Precio[i] + " - Cantidad: " + Cantidad[i]);
            }
            Console.ReadLine();
            return PantallaGestionarProductos();
        }
        public static int PantallaGestionarAlmacenes()
        {
            Console.Clear();
            string txt = "--------------------------------------------------\n" +
                " Gestionar Almacenes - Mi Tiendita \n" +
                "--------------------------------------------------\n" +
                " 1. Agregar Almacén \n" +
                " 2. Eliminar Almacén \n" +
                " 3. Mostrar Almacenes \n" +
                " 4. Volver al Menú Principal \n" +
                "--------------------------------------------------\n" +
                "Seleccione una opción: ";
            Console.Write(txt);

            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1) return PantallaAgregarAlmacen();
            if (opcion == 2) return PantallaEliminarAlmacen();
            if (opcion == 3) return PantallaMostrarAlmacenes();
            if (opcion == 4) return PantallaPrincipal();
            return opcion;
        }

        public static int PantallaAgregarAlmacen()
        {
            Console.Clear();
            string txt = "===== Pantalla para Agregar Almacén =====\n" +
                "--------------------------------------------------\n" +
                "Ingrese el nombre del nuevo almacén: ";
            Console.Write(txt);

            string nombreAlmacen = Console.ReadLine();

            string txt2 = "--------------------------------------------------\n" +
                "Confirmación: Almacén agregado exitosamente. \n";
            Console.Write(txt2);


            Almacen[contadorAL] = nombreAlmacen;
            contadorAL++;

            Console.ReadLine();
            return PantallaGestionarAlmacenes();
        }
    }
}
