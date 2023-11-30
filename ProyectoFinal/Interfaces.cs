using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Interfaces
    {
        public static string[] Producto = new string[100];
        public static float[] Precio = new float[100];
        public static int[] Cantidad = new int[100];
        public static string[] Almacen = new string[100];
        public static int contador = 0;

        public static int PantallaPrincipal()
        {
            Console.Clear();
            string txt = "==================================================\n" +
                "||                                              ||\n" +
                "||      Sistema de Inventario ¨Mi Tiendita¨     ||\n" +
                "||                                              ||\n" +
                "==================================================\n" +
                "|| 1. Gestionar Productos                       ||\n" +
                "|| 2. Gestionar Almacenes                       ||\n" +
                "|| 3. Agregar y Extraer Productos               ||\n" +
                "==================================================\n";
            Console.WriteLine(txt);

            return Operaciones.getEntero("Seleccione una opción y presione Enter: ", txt);
        }


        public static int PantallaGestionarProductos()
        {
            Console.Clear();
            string txt = "--------------------------------------------------\n" +
                "||       Gestionar Productos - Mi Tiendita      ||\n" +
                "--------------------------------------------------\n" +
                "||  1.Agregar Producto                          ||\n" +
                "||  2.Eliminar Producto                         ||\n" +
                "||  3.Modificar Producto                        ||\n" +
                "||  4.Mostrar Inventario                        ||\n" +
                "||  5.Volver al Menú Principal                  ||\n" +
                "--------------------------------------------------\n" +
                "Seleccione una opción: ";
            Console.WriteLine(txt);

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    PantallaAgregarProducto();
                    break;
                case 2:
                    PantallaEliminarProducto();
                    break;
                case 3:
                    PantallaModificarProducto();
                    break;
                case 4:
                    PantallaMostrarInventario();
                    break;
                case 5:
                    PantallaPrincipal();
                    break;
            }
            return opcion;
        }

        public static int PantallaAgregarProducto()
        {
            Console.Clear();
            string txt = "===== Pantalla para Agregar Producto =====\n" +
                "--------------------------------------------------\n" +
                "Ingrese el nombre del producto:  ";
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
        public static void PantallaModificarProducto()
        {
            string txt = "===== Pantalla para Modificar Producto =====" +
                "--------------------------------------------------" +
                "Ingrese el nombre del producto a modificar:" +
                "[Usuario ingresa el nombre]" +
                "Ingrese el nuevo precio:" +
                "[Usuario ingresa el nuevo precio]" +
                "Ingrese la nueva cantidad:" +
                "[Usuario ingresa la nueva cantidad]" +
                "--------------------------------------------------" +
                "Confirmación: Producto modificado exitosamente.";
            Console.WriteLine(txt);
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

        public static int PantallaAgregaryExtraerProductos()
        {
            string txt = "--------------------------------------------------\n" +
                "|| Agregar y Extraer Productos - Mi Tiendita ||" +
                "--------------------------------------------------" +
                "|| 1. Ingresar Producto en Almacén ||" +
                "|| 2. Extraer Producto de Almacén ||" +
                "|| 3. Ver Stock Actual ||" +
                "|| 4. Volver al Menú Principal ||" +
                "--------------------------------------------------";
            Console.Write(txt);

            return Operaciones.getEntero("Seleccione una opción: ", txt);
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
                "--------------------------------------------------\n";
            Console.Write(txt);

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    PantallaAgregarAlmacen();
                    break;
                case 2:
                    PantallaEliminarAlmacen();
                    break;
                case 3:
                    PantallaMostrarAlmacenes();
                    break;
                case 4:
                    PantallaPrincipal();
                    break;
            }
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

            Almacen[contador] = nombreAlmacen;
            contador++;

            Console.ReadLine();
            return PantallaGestionarAlmacenes();
        }

        public static int PantallaEliminarAlmacen()
        {
            Console.Clear();
            string txt = "===== Pantalla para Eliminar Almacén =====\n" +
                "--------------------------------------------------\n" +
                "Ingrese el nombre del almacén a eliminar:[Usuario ingresa el nombre]\n" +
                "--------------------------------------------------\n" +
                "Confirmación: Almacén eliminado exitosamente. \n";
            Console.Write(txt);

            Console.ReadLine();
            return PantallaGestionarAlmacenes();
        }

        public static int PantallaMostrarAlmacenes()
        {
            Console.Clear();
            string txt = "===== Pantalla para Mostrar Almacenes =====\n" +
                "--------------------------------------------------\n" +
                "Lista de Almacenes:\n";
            Console.Write(txt);

            if (contador == 0)
            {
                Console.WriteLine("No se registro ningún Almacen");
            }

            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine("Almacén " + (i + 1) + ": " + Almacen[i]);
            }

            Console.ReadLine();
            return PantallaGestionarAlmacenes();
        }
        public static int Pantallao()
        {
            Console.Clear();
            string txt = "===== Pantalla para Mostrar Inventario =====\n" +
                "--------------------------------------------------\n" +
                "Inventario Actual: \n";
            Console.Write(txt);
        }
    }
}