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

            //string palabra;

            //Console.WriteLine("Dime una palabra");
            //palabra = Console.ReadLine();

            //bool found = false;
            //for (int i = 0; i < palabra.Length; i++)
            //{
            //    if (palabra[i] == 'r' || palabra[i] == 'R')
            //    {
            //        found = true;// el booleano actua de paron porque cuando encuentra la accion para,y sale del bucle.
            //        //Entonces se haria el if
            //    }
            //}

            //if (found)//si lo encuentra,realizaria el if
            //{
            //    Console.WriteLine("La palabra si contiene la letra r");
            //}
            //else
            //{
            //    Console.WriteLine("La palabra no contiene la letra r");
            //    }



            //Console.ReadLine();

            //Escribe un programa que devuelva un string en minúsculas en mayúsculas y al revés

            //string palabracamb;

            //Console.WriteLine("Dime una palabra");
            //palabracamb = Console.ReadLine();

            //for (int i = 0; i < palabracamb.Length; i++)//segregamos la palabra
            //{
            //    if (palabracamb[i] >= 'a' && palabracamb[i] <= 'z')//buscamos si alguna letra es cualquiera de esos valores
            //    {
            //        palabracamb = palabracamb.ToUpper();//si encuentra 1,transforma la palabra a mayuscula
            //    }
            //    else
            //    {
            //        palabracamb = palabracamb.ToLower();//si no encuentra.transforma la palabra a minuscula
            //    }
            //}
            //Console.WriteLine(palabracamb); //escribe la que cumple     

            //Console.ReadLine();

            //Escribe un programa que te calcule el total de palabras que hay en un string.

            //string frase;
            //int palabras = 1; //partimos de 1 porque lo que cuenta son espacios

            //Console.WriteLine("Dime una palabra");
            //frase = Console.ReadLine();

            //for (int i = 0; i < frase.Length; i++) 
            //{
            //    if(frase[i]== ' ')
            //    {
            //        palabras++;
            //    }
            //}

            //Console.ReadLine();

            ////Escribe un programa que copia un string a otro string.

            //string a= "pilar";// se le da un valor inicial
            //String b; //un string vacio que vamos a rellenar

            //Console.WriteLine(a);

            //b = String.Copy(a);
            //Console.WriteLine(b);


            //Console.ReadLine();//escribiria 2 veces pilar porque uno es a y otro b que es la copia de a

            //Escribe un programa en el que dada una frase sacará su carácter central. Nota:
            //Si la largura de la frase es par deberá sacar los dos caracteres centrales correspondientes.
            //Si es impar deberá sacar su único carácter central.

            //string frase;

            //Console.WriteLine("Dame una frase");
            //frase = Console.ReadLine();

            //if (frase.Length % 2 == 0)
            //{
            //    Console.WriteLine("" + frase[frase.Length / 2 - 1] + frase[(frase.Length / 2)]);//hemos tenido que poner ""
            //    //porque si no,nos lee en asci y asi entiende que hay que poner strings
            //}
            //else
            //{
            //    Console.WriteLine(frase[frase.Length / 2]);
            //}

            //Console.ReadLine();

            //Escribe un programa el cual analizará si la contraseña introducida es correcta o no. Para que la contraseña sea correcta deberá cumplir estas directivas:
            //Debe tener 8 caracteres como mínimo.
            //La contraseña deberá contener números.
            //Deberá contener al menos dos dígitos. 

            //string contraseña;
            //int contador=0;          
            //bool correcto = false;

            //do//ponemos un do para que si es incorrecta que nos la vuelva a pedir pero que siempre la pida por lo menos 1 vez
            //{
            //  Console.WriteLine("Dame una contraseña");
            //  contraseña = Console.ReadLine();

            //    if (contraseña.Length >= 8)//no hace falta bucle
            //    {
            //        for (int i = 0; i < contraseña.Length; i++)// nos segrega la contraseña
            //        {
            //            if (char.IsDigit(contraseña[i]) == true)//busca digitos en la contraseña
            //            {
            //                contador++;//cuenta los numeros

            //                if (contador >= 2)
            //                {
            //                    correcto = true;//aqui hay un booliano que da por hecho que es falso,solo se activa si todo es verdadero
            //                }
            //            }
            //        }

            //    }

            //} while (correcto == false);

            //Console.WriteLine("La contraseña es correcta");// esto hay que escribirlo fuera del bucle porque si no me 
            //                                              //lo va a repetir i veces

            //Console.ReadLine();


            //   }
            //   else
            //   {
            //       Console.WriteLine("La contraseña es incorrecta");
            //   }


            //else
            //{
            //        Console.WriteLine("La contraseña debe de tener 8 caracteres como minimo");

            //}
            //for (int i = 0; i < contraseña.Length; i++)
            //{

            //    if (char.IsDigit(contraseña[i]) == true)
            //    {
            //        numero++;
            //        if (numero < 2)
            //        {
            //            Console.WriteLine("La contraseña debe de tener 2 numeros como minimo");
            //            break;
            //        }
            //    }
            //    if (char.IsLetter(contraseña[i]) == true)
            //    {
            //        letra++;

            //        if (letra < 2)
            //        {
            //            Console.WriteLine("La contraseña debe de tener 2 digitos como minimo");
            //            break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Contraseña correcta");
            //    }

            //}



            //Escribe un programa que al meter tres números por teclado identifique el mínimo
            //y el máximo(usa el método correspondiente). 

            //int num1, num2, num3;
            //int maximo = 0;
            //int minimo = 0;


            //Console.WriteLine("Dame 3 numeros");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //num2 = Convert.ToInt32(Console.ReadLine());
            //num3 = Convert.ToInt32(Console.ReadLine());


            //if (num1 > num2 && num1 > num3 && num2 != num3)
            //{
            //    maximo = num1;
            //}
            //if (num2 > num1 && num2 > num3 && num1 != num3)
            //{
            //    maximo = num2;
            //}
            //if (num3 > num1 && num3 > num2 && num1 != num2)
            //{
            //    maximo = num3;
            //}
            //Console.WriteLine("El maximo es " + maximo);
            //if (num1 < num2 && num1 < num3 && num2 != num3)
            //{
            //    minimo = num1;
            //}
            //if (num2 < num1 && num2 < num3 && num1 != num3)
            //{
            //    minimo = num2;
            //}
            //if (num3 < num1 && num3 < num2 && num1 != num2)
            //{
            //    minimo = num3;
            //}
            //Console.WriteLine("El minimo es " + minimo);
            //Console.ReadLine();


            //int num1, num2, num3;// este metodo es mucho mejor que el anterior

            //int max;
            //int min;


            //Console.WriteLine("Dame 3 numeros");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //num2 = Convert.ToInt32(Console.ReadLine());
            //num3 = Convert.ToInt32(Console.ReadLine());
            //max = Math.Max(num1, num2); //elige el maximo entre 2 numeros,peeero...
            //min = Math.Min(num1, num2);

            //if(max>num3)//... como son 3,comparamos el resultado con el tercero
            //{
            //    Console.WriteLine("El maximo es " + max);
            //}
            //else
            //{
            //    Console.WriteLine("El maximo es " + num3);
            //}
            //if(min<num3)
            //{
            //    Console.WriteLine("El minimo es " + min);
            //}
            //else
            //{
            //    Console.WriteLine("El minimo es " + num3);
            //}
            //Console.ReadLine();


            //Escribe un programa que muestre la fecha de hoy

           
            Console.WriteLine("La fecha de hoy es " + DateTime.Now);          
            Console.WriteLine("La fecha de hoy es " + DateTime.Today.ToString("dd/mm/yyyy"));// con tostring cambia el 
                                                                                           //formato al que pongamos
            Console.WriteLine("La fecha de hoy es " + DateTime.Now.ToString("dd/mm/yyyy H:m"));//aqui poniendo horas
            Console.ReadLine();

























        }





































    }

      
}
    


        


              
              







            











    


                

            










           




        

    
