using System;

namespace C__Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int des;
            do {
                Console.WriteLine("");
                Console.WriteLine("Elige el tipo de operación que deseas realizar\n" + //Instrucciones para el usuario
                "\n1.- Suma" +
                "\n2.- Resta" +
                "\n3.- Multiplicacíon" +
                "\n4.- División" +
                "\n5.- Módulo" +
                "\n6.- Salir\n");
                String s1 = null;
                s1 = Console.ReadLine().ToString();
                //Inicio del case Switch
                switch (s1) 
                {
                    case "1":
                        Console.WriteLine("");
                        Console.WriteLine("Suma");
                        Console.WriteLine("");
                        Console.WriteLine("Introduzca el 1er. Número: "); //Captura del primer número
                        int número0 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Introduzca el 2do. Número: "); //Captura del segundo número
                        int número1 = Convert.ToInt16(Console.ReadLine());
                        int res = número0 + número1;
                        Console.WriteLine($"El resultado de la suma es: " + res ); //Impresión del resultado
                        break;

                    case "2":
                        Console.WriteLine("");
                        Console.WriteLine("Resta");
                        Console.WriteLine("");
                        Console.WriteLine("Introduzca el 1er. Número: "); //Captura del primer número
                        int número2 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Introduzca el 2do. Número: "); //Captura del segundo número
                        int número3 = Convert.ToInt16(Console.ReadLine());
                        int res1 = número2 - número3;
                        Console.WriteLine($"El resultado de la resta es: " + res1 ); //Impresión del resultado
                        break;

                    case "3":
                        Console.WriteLine("");
                        Console.WriteLine("Multiplicación");
                        Console.WriteLine("");
                        Console.WriteLine("Introduzca el 1er. Número: "); //Captura del primer número
                        int número4 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Introduzca el 2do. Número: "); //Captura del segundo número
                        int número5 = Convert.ToInt16(Console.ReadLine());
                        int res2 = número4 * número5;
                        Console.WriteLine($"El resultado de la multiplicación es: " + res2 ); //Impresión del resultado
                        break;

                    case "4":  
                        Console.WriteLine("");
                        Console.WriteLine("División");
                        Console.WriteLine("");
                        Console.WriteLine("Introduzca el 1er. Número: "); //Captura del primer número
                        int número6 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Introduzca el 2do. Número: "); //Captura del segundo número
                        int número7 = Convert.ToInt16(Console.ReadLine());
                        
                        if (número6 <= 0 || número7 <= 0)
                            Console.WriteLine("Uno de los números que ingreso es igual a 0");

                        else {
                            int res3 = número6 / número7;
                            Console.WriteLine("El resultado de la división es: " + res3);
                        }
                        break;

                    case "5":
                        Console.WriteLine("");
                        Console.WriteLine("Módulo");
                        Console.WriteLine("");
                        Console.WriteLine("Introduzca el 1er. Número: "); //Captura del primer número
                        int número8 = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Introduzca el 2do. Número: "); //Captura del segundo número
                        int número9 = Convert.ToInt16(Console.ReadLine());
                        int res4 = número8 % número9;
                        Console.WriteLine($"El resultado del módulo es: " + res4 ); //Impresión del resultado
                        break;
                    
                    case "6":
                        Console.WriteLine("");
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Default case");
                        break;
                }
                Console.WriteLine("");
                Console.WriteLine("¿Desea continuar?");
                Console.WriteLine("1. Si || 2. No");
                Console.WriteLine("");
                des = Convert.ToUInt16(Console.ReadLine());
            } while(des == 1);
        }   
    }
}
