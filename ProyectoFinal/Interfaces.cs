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
        public static int[] Precio = new int[100];
        public static int[] Cantidad = new int[100];
        public static string[] Almacen = new string[100];
        public static int contador = 0;
        public static int PantallaPrincipal()
        {
            string txt = "==================================================\n" +
                "||                                       ||\n" +
                "|| Sistema de Inventario \"Mi Tiendita\" ||\n" +
                "||                                       ||\n" +
                "==================================================\n" +
                "|| 1. Gestionar Productos ||\n" +
                "|| 2. Gestionar Almacenes ||\n" +
                "|| 3. Agregar y Extraer Productos ||\n" +
                "==================================================\n";
            Console.WriteLine(txt);
            int opcion = int.Parse(Console.ReadLine());

            return Operaciones.getEntero("Seleccione una opción y presione Enter: ", txt);
        }

        public static int PantallaGestionarProductos()
        {
            string txt = "--------------------------------------------------" +
                "||       Gestionar Productos - Mi Tiendita      ||" +
                "--------------------------------------------------" +
                "||  1.Agregar Producto                          ||" +
                "||  2.Eliminar Producto                         ||" +
                "||  3.Modificar Producto                        ||" +
                "||  4.Mostrar Inventario                        ||" +
                "||  5.Volver al Menú Principal                  ||" +
                "--------------------------------------------------";
            Console.WriteLine(txt);

            return Operaciones.getEntero("Seleccione una opción: ", txt);
        }

        public static void PantallaAgregarProducto()
        {
            string txt = "===== Pantalla para Agregar Producto =====\n" +
                "--------------------------------------------------\n" +
                "Ingrese el nombre del producto:[Usuario ingresa el nombre]\n" +
                "Ingrese el precio del producto:[Usuario ingresa el precio]\n" +
                "Ingrese la cantidad del producto:[Usuario ingresa la cantidad]\n" +
                "--------------------------------------------------\n" +
                "Confirmación: Producto agregado exitosamente.\n";
                Console.Write(txt);

        }

        public static int PantallaEliminarProducto() 
        { 
            string txt = "===== Pantalla para Eliminar Producto =====\n" + 
                "--------------------------------------------------\n" + 
                "Ingrese el nombre del producto a eliminar: \n" +
                "[Usuario ingresa el nombre]"; 
            Console.Write(txt);

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
            string txt = "===== Pantalla para Mostrar Inventario =====\n" +
                "--------------------------------------------------\n" +
                "Inventario Actual:" +
                "Producto 1: [Nombre] - Precio: $[Precio] - Cantidad: [Cantidad]\n" +
                "Producto 2: [Nombre] - Precio: $[Precio] - Cantidad: [Cantidad]\n" +
                "...";
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
    }
}
