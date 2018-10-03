using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_string
{
    class Program
    {
        static void Main(string[] args)
        {

            //Escribe un programa que te calcule la largura de un string

            //string nombre;

            //Console.WriteLine("Dime una palabra");
            //nombre = Console.ReadLine();

            //Console.WriteLine(nombre.Length);

            //Console.ReadLine();


            //Escribe un programa que nos cuente el número de vocales en un string

            //string respuesta;
            //int vocales = 0;

            //Console.WriteLine("Dime una palabra");
            //respuesta = Console.ReadLine();
            

            //for (int i=0;i<respuesta.Length;i++)//i++,cada vuelta suma 1 unidad
            //{      // IMPORT cuando accedemos a un caracter,hay que escribir comillas simples
            //    if(respuesta[i]=='a'|| respuesta[i] == 'e'|| respuesta[i] == 'i'|| respuesta[i] == 'o'|| respuesta[i] == 'u')
            //    {    //[] accede a la posicion de las palabras                
            //        vocales++;//IMPORT actua como contador
            //    }
               
            //}
            //Console.WriteLine("La palabra "+ respuesta+ " tienes " + vocales + " vocales");


            //Console.ReadLine();

            //Escribe un programa que evalúe si un string contiene la letra ‘r’.

            string palabra;
           
            Console.WriteLine("Dime una palabra");
            palabra = Console.ReadLine();

            bool found = false;
            for (int i = 0; i < palabra.Length;i++)
            {      
                if (palabra[i] == 'r' || palabra[i] == 'R')
                {
                    found = true;
                }
            }

            if(found)
            {
                Console.WriteLine("La palabra si contiene la letra r");
            }
            else
            {
                Console.WriteLine("La palabra no contiene la letra r");
            }



            Console.ReadLine();



















            //Console.ReadLine();






        }
    }
}
