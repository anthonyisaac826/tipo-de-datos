using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipo_de_datos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //la palabra reservada int me sirve para declarar
            //numeros enteros
            int a;
            Console.WriteLine("ejemplo");
            a = 3;
            Console.WriteLine("el valor de a: \n" + a);
            a = 8;
            Console.WriteLine("el valor de a: \n" + a);
            //prueba probando ingresar un valor de 7.8
            // y dime que es lo que pasa
            Console.WriteLine("el valor de a: \n" + a);
            //<-------------------------------------------->
            //numeros decimales o con punto decimal
            //en C# estan estas dos palabras reservadas
            //double y float
            double b;
            float f;
            Console.WriteLine("ejemplo");
            b = 3.1416;
            Console.WriteLine("el valor de B: \n" + b);
            b = 45.15;
            Console.WriteLine("el valor de B: \n" + b);
            Console.WriteLine("ejemplo de flotantes");
            /*declaramos variables de tipo flotante al final se debe colocar
             * el sufrijo f que hace alucion al tipo de dato flotante
             En resumen, la f al final de un numero decimal se utiliza
            para asegurarse de que el valor sea tratado como float y no como dueble.*/
            f = 3.001f;
            Console.WriteLine("el valor de f: \n" + f);
            f = 45.16f;
            Console.WriteLine("el valor de f: \n" + f);
            //declaramos la variable f y le asginamos notacion cientifica como
            //en el ejemplo
            f = 134.45E-2f;
            Console.WriteLine(f);
            // salidad: 1.3445

            //<-----------------------------------------

            //declarar variables del tipo de datos char
            //el espacio en memoria solo de estas variables
            //solo admite un digito o valor ejemplo
            char z = 'A';
            char y = '1';
            char t;
            //al momento de declararlo lo hacemos con comillas simples ''
            Console.WriteLine("el valor de z = {0} y el valor de y = {1}", z, y);
            Console.WriteLine("ingresa un valor o letra");
            t = char.Parse(Console.ReadLine());
            Console.WriteLine("el valor de t:\n"+t);
            Console.ReadKey();

            //<------------------------------------------------->>
            //tipo de datos logicos o booleans
            //este tipo de datos nos sirve para comparar y lo podemos manejar con los
            //siguientes valores
            //true y false
            //verdadero o falso
            //en el ejemplo se encuentra directamente asignando valores a las varibables
            bool verdad=true;
            bool falso=false;
            //normalmento esto nos sirve para manejar respuestas condicionales
            Console.WriteLine("valores de las variables valor de verdad: {0},valor de falso: {1}", verdad, falso);
            Console.ReadKey();
        }
    }
}
