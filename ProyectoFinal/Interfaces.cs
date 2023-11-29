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
        public static void PantallaPrincipal()
        {
            string txt = "==================================================\n" +
                "|| ||\n" +
                "|| Sistema de Inventario \"Mi Tiendita\" ||\n" +
                "|| ||==================================================\n" +
                "|| 1. Gestionar Productos ||\n" +
                "|| 2. Gestionar Almacenes ||\n" +
                "|| 3. Agregar y Extraer Productos ||\n" +
                "==================================================\n" +
                "Seleccione una opción y presione Enter: ";
            Console.WriteLine(txt);
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {

            }

        }
        public static void PantallaGestionarProductos()
        {
            string txt = "--------------------------------------------------" +
                "||       Gestionar Productos - Mi Tiendita      ||" +
                "--------------------------------------------------" +
                "||  1.Agregar Producto                          ||" +
                "||  2.Eliminar Producto                         ||" +
                "||  3.Modificar Producto                        ||" +
                "||  4.Mostrar Inventario                        ||" +
                "||  5.Volver al Menú Principal                  ||" +
                "--------------------------------------------------" +
                "Seleccione una opción: ";
            Console.WriteLine(txt);
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {

            }
            

        }
        public static void agregarProducto ()
        {
            Console.Write("alonso main edgar");
            // giaco se la come
        }
       
    }
}
