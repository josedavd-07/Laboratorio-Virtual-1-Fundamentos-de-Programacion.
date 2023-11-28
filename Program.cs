/* _______________________________________________________________
   |                                                             |
   | -Nombre del estudiante: Jose David Carranza Angarita        |
   |                                                             |                                       
   |  - Grupo: 213022_77                                         |  
   |                                                             |
   | - Carrera: Ingeniería de Sistemas.                           |                                                              
   |                                                             |              
   |  - Número: Problema #1 - Ejercicio #4                       |
   |                                                             |
   | -Código Fuente: autoría propia.                             |
   |                                                             |
   | -Laboratorio Virtual Paso 5  - fundamentos de programación. |                
   |_____________________________________________________________|
  */


/*_______________________________________________________________________________________________
  |                                                                                              |
  |  - Para una tienda de ropa femenina se requiere un programa que:                             |
  |                                                                                              |
  |  - Mediante ciclos permita ingresar por consola n número de productos y sus valores.         |
  |                                                                                              |
  |  - Debe calcular y mostrar en pantalla el subtotal, IVA y valor total a pagar.               | 
  |                                                                                              |
  |  - Con condicionales debe hallar si la compra es mayor a $50.000 hacer un descuento del 5%   |
  |                                                                                              |
  |  - Nota: el descuento se evalúa y se hace sobre el subtotal o valor neto.                    |
  |______________________________________________________________________________________________|
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace josedavd_fashion
{
    class program
    {
        static void Main(string[] args)
        {
            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/

            // Damos titulo a la consola del programa
            Console.Title = "Store josedavd_fashion";

            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/

            // Configuracion de la consola para  introducir y mostrar emojis por consola usando codificación UTF-8
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/

            //llamamos a la funcion que nos muestra el baner de la tienda
            banerTienda();

            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/

            //llamamos a la funcion bienvenidaAlSistema
            string usuario = Convert.ToString(bienvenidaAlSistema());

            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/

            // Llamada a la función para almacenar el número de productos que el usuario desea comprar
            int[] numeroDeProductos = llenarNumerosProductos();

            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/

            // Llamada a la función para asignar nombres a los productos
            string[] nombresDeProductos = llenarNombresProductos(numeroDeProductos);

            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
            // Llamada a la función para asignar precios a los productos
            double[] preciosDeProductos = llenarPreciosProductos(numeroDeProductos);

            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
            // Llamada a la función para aplicar descuento si la compra es mayor a 50.000
            double subtotal = aplicarDescuento(preciosDeProductos);

            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
            // Llamada a la función para calcular totales y mostrar detalle de la compra
            calcularTotales(preciosDeProductos, nombresDeProductos, subtotal);

            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
            /*--------------------------------------------------------------------------------------------------------------------------------------------------*/

            Console.ReadKey();
        }
        /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
        /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
        /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
        /*--------------------------------------------------------------------------------------------------------------------------------------------------*/

        // creamos una funcion que nos muestre el banner de la tienda
        static void banerTienda()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n     👔👕👘👗👔👕👘👗👔👕👘👗👔👕👘👗👔👕👘👗👔👕👘👗👔👕👘👗👔👕👘👗👔👕👘👗👔👗👔👕👘👗👔👕👘👗\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("                                   BIENVENIDOS A JOSEDAVD_FASHION                 \n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("     👔👕👘👗👔👕👘👗👔👕👘👗👔👕👘👗👔👕👘👗👔👕👘👗👔👕👘👗👔👕👘👗👔👕👘👗👔👗👔👕👘👗👔👕👘👗");

        }
        /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
        /*--------------------------------------------------------------------------------------------------------------------------------------------------*/

        // creamos una funcion que nos muestra el saludo al usuario y nos pide el nombre del usuario
        static string bienvenidaAlSistema()
        {
            Console.WriteLine("\n\n🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒\n");
            Console.Write("Digita tu  nombre de usuario como asesor de la tienda para ingresar al sistema: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string usuario = Console.ReadLine();
            // Validación de entrada de datos solo letras si no es una letra se repite el ciclo while
            // system.text.regularexpressions.regex.ismatch es una expresion regular que valida que solo se ingresen letras
            //y esto se hace con el metodo ismatch que devuelve un valor booleano si es verdadero se sale del ciclo while
            //si es falso se repite el ciclo while
            while (!System.Text.RegularExpressions.Regex.IsMatch(usuario, @"^[a-zA-ZñÑ\s]+$"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Entrada inválida. Por favor, ingrese solo letras.\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Digita tu  nombre de usuario como asesor de la tienda para ingresar al sistema: ");
                Console.ForegroundColor = ConsoleColor.Green;
                usuario = Console.ReadLine();
            }
            Console.WriteLine($"\n¡Hola 👋 {usuario} bienvenid@ al sistema!\n");
            Console.WriteLine("🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒");
            Console.ForegroundColor = ConsoleColor.White;
            return usuario;
        }
        /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
        /*--------------------------------------------------------------------------------------------------------------------------------------------------*/

        // Función para almacenar el número de productos que el usuario desea comprar
        static int[] llenarNumerosProductos()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n¿Cuantos productos desea ingresar al sistema?: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string input = Console.ReadLine();
            int cantidadDeProductos;
            // Validación de entrada de datos solo números si no es un número se repite el ciclo while
            while (!int.TryParse(input, out cantidadDeProductos))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n¿Cuantos productos desea ingresar al sistema?: ");
                Console.ForegroundColor = ConsoleColor.Green;
                input = Console.ReadLine();
            }
            int[] numeroDeProductos = new int[cantidadDeProductos];
            Console.WriteLine($"\nEl usuario ingresará {numeroDeProductos.Length} productos.");
            Console.WriteLine("\n🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒\n");
            return numeroDeProductos;
        }

        /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
        /*--------------------------------------------------------------------------------------------------------------------------------------------------*/

        // Función para asignar nombres a los productos
        static string[] llenarNombresProductos(int[] numeroDeProductos)
        {
            string[] nombresDeProductos = new string[numeroDeProductos.Length];
            for (int i = 0; i < numeroDeProductos.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ingrese el nombre del producto " + (i + 1) + ": ");
                Console.ForegroundColor = ConsoleColor.Green;
                string nombreProducto = Console.ReadLine();
                // Validación de entrada de datos solo letras si no es una letra se repite el ciclo while
                // system.text.regularexpressions.regex.ismatch es una expresion regular que valida que solo se ingresen letras
                //y esto se hace con el metodo ismatch que devuelve un valor booleano si es verdadero se sale del ciclo while
                //si es falso se repite el ciclo while
                while (!System.Text.RegularExpressions.Regex.IsMatch(nombreProducto, @"^[a-zA-ZñÑ\s]+$"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Entrada inválida. Por favor, ingrese solo letras.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Ingrese el nombre del producto " + (i + 1) + ": ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    nombreProducto = Console.ReadLine();
                }
                nombresDeProductos[i] = nombreProducto;
            }
            return nombresDeProductos;
        }
        /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
        /*--------------------------------------------------------------------------------------------------------------------------------------------------*/

        // Función para asignar precios a los productos
        static double[] llenarPreciosProductos(int[] numeroDeProductos)
        {
            Console.WriteLine("\n🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒\n");
            double[] preciosDeProductos = new double[numeroDeProductos.Length];
            for (int i = 0; i < numeroDeProductos.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ingrese el precio del producto " + (i + 1) + ": $ ");
                Console.ForegroundColor = ConsoleColor.Green;
                string input = Console.ReadLine();
                double precioProducto;
                while (!double.TryParse(input, out precioProducto))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Ingrese el precio del producto " + (i + 1) + ": $ ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    input = Console.ReadLine();
                }
                preciosDeProductos[i] = precioProducto;
            }
            Console.ResetColor(); // Restablece el color a la configuración predeterminada
            return preciosDeProductos;
        }
        /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
        /*--------------------------------------------------------------------------------------------------------------------------------------------------*/

        // Función para aplicar descuento si la compra es mayor a 50.000
        static double aplicarDescuento(double[] preciosDeProductos)
        {
            double subtotal = 0;
            for (int i = 0; i < preciosDeProductos.Length; i++)
            {
                subtotal += preciosDeProductos[i];
            }
            if (subtotal > 50000)
            {
                double descuento = subtotal * 0.05; // Descuento del 5%
                subtotal -= descuento;
                Console.Write("\nPor tener una compra mayor a $50.000 pesos se ha aplicado un descuento del 5% al subtotal de la cuenta los cuales son: $ ");
                Console.ForegroundColor = ConsoleColor.Green; Console.Write($"{descuento}\n");
            }
            return subtotal;
        }
        /*--------------------------------------------------------------------------------------------------------------------------------------------------*/
        /*--------------------------------------------------------------------------------------------------------------------------------------------------*/

        // función para calcular totales y mostrar detalle de la compra
        static void calcularTotales(double[] preciosDeProductos, string[] nombresDeProductos, double subtotal)
        {
            Console.WriteLine("\n🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nDetalle de la compra:\n");
            for (int i = 0; i < preciosDeProductos.Length; i++)
            {
                //esta es la impresion de los productos de una forma sencilla de un solo color 
                //se  dejo comentada para que se vea la diferencia de la impresion de los productos

                /* Console.ForegroundColor = ConsoleColor.Green;
                 Console.WriteLine("Producto " + (i + 1) + ": " + nombresDeProductos[i] + " - Precio: " + preciosDeProductos[i]);
                */

                Console.ForegroundColor = ConsoleColor.White; Console.Write("Producto " + (i + 1) + ": ");
                Console.ForegroundColor = ConsoleColor.Green; Console.Write(nombresDeProductos[i]);
                Console.ForegroundColor = ConsoleColor.White; Console.Write(" - Precio: $ ");
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(preciosDeProductos[i]);
                Console.ResetColor(); // Restablece el color a la configuración predeterminada
            }
            double iva = subtotal * 0.19; // Asumiendo que el IVA es del 19%
            double total = subtotal + iva;

            // esta es la impresion de los totales de una forma sencilla de un solo color 
            //se  dejo comentada para que se vea la diferencia de la impresion de los totales sin color

            /*Console.WriteLine("\nSubtotal: " + subtotal);
            Console.WriteLine("IVA: " + iva);
            Console.WriteLine("Total: " + total);*/

            Console.ForegroundColor = ConsoleColor.White; Console.Write("\nSubtotal: $ ");
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(subtotal);
            Console.ForegroundColor = ConsoleColor.White; Console.Write("IVA: $ ");
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(iva);
            Console.ForegroundColor = ConsoleColor.White; Console.Write("Total: $ ");
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(total);
            Console.ResetColor(); // Restablece el color a la configuración predeterminada
            Console.WriteLine("\n🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒🛒");

        }

    }
}

