using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {

            //// INICIO EXPLICACION DE FUNCIONES GENERICAS


            //// En los arreglos hay que especificar el tamaño obligatoriamente
            //int[] numerosArreglo = new int[10];
            //numerosArreglo[2] = 20;
            ////numerosArreglo[20] = 10;



            //// Lista generica en la que no se especifica el numero de componentes de la lista
            //List<int> numerosLista = new List<int>();
            ////numerosLista.Add(20);


            //// Generamos los numeros de una lista y luego los recogemos
            //for (int i = 1; i <= 10; i++) 
            //{
            //    numerosLista.Add(i);
            //}

            //numerosLista.Remove(3); // Remueves un numero en concreto
            //numerosLista.RemoveAt(0); // Remueve por indice
            //numerosLista.RemoveRange(0, 3); // Remueve por rango 3 elementos. Desde el 0 hasta el 3
            //numerosLista.Clear(); // Serviria para eliminar todos los elementos de la lista

            //numerosLista.Insert(numerosLista.Count - 1,50);

            //for (int i = 0; i < numerosLista.Count; i++) 
            //{
            //    int elemento = numerosLista[i];
            //    Console.WriteLine(elemento);

            //}
            //Console.ReadLine();
            //// FINAL DE LISTAS GENERICAS
            ///





            ////INICIO DE LinkedinList <T>

            // FIFO (First In First Out - El primer nodo que entra es el primer nodo que sale)

            //// LinkedinList no soporta el acceso a la misma como si fuera un arreglo

            //LinkedList<int> numeros = new LinkedList<int>();

            //numeros.AddLast(3); //Se añade numero al final

            //for (int i = 1; i <= 10; i++)
            //{
            //    //Console.WriteLine(numeros.AddLast(i));
            //    Console.WriteLine(numeros.AddFirst(i));
            //}

            //var primero = numeros.AddFirst(300); // Se añade numero al principio

            //// EN FUNCION DEL NODO. Estos dos metodos van en funcion del nodo
            //// y se insertan antes o despues de algun nodo

            //numeros.AddAfter(primero, 200);

            //numeros.AddBefore(primero, 250);

            //var nodo = numeros.First;

            //while (nodo != null) 
            //{
            //    Console.WriteLine(nodo.Value);
            //    nodo = nodo.Next;
            //}

            //// En este caso se recorre la lista de detras hacia delante. Cada vez
            //// que iteramos tiramos del nodo previo
            //for (var nodo2 = numeros.Last; nodo2 != null; nodo2 = nodo2.Previous) 
            //{
            //    Console.WriteLine(nodo2.Value);

            //}

            //numeros.Remove(3);
            //numeros.RemoveFirst();
            //numeros.RemoveLast();



            //foreach (var numero in numeros) 
            //{
            //    Console.WriteLine(numero);
            //}



            //Console.ReadLine();


            //// FINAL DE LINKED LIST




            //// INICIO DE COLECCION QUEUE 

            //Queue<int> numeros = new Queue<int>();

            //numeros.Enqueue(3);

            //// Encolando o añadiendo elementos

            //for (int i = 1; i <= 10; i++) 
            //{

            //    numeros.Enqueue(i);

            //}

            //// Contendra el primer elemento que saldria de nuestra 
            //// estructura de cola. Es un metodo que no lleva argumentos


            //var elemento = numeros.Dequeue();

            //while (numeros.Count > 0) 
            //{
            //    elemento = numeros.Dequeue();
            //    Console.WriteLine(elemento);
            //}



            ////foreach (var numero in numeros) 
            ////{


            ////    Console.WriteLine(numero);
            ////}




            //var elemento2 = numeros.Dequeue();




            //Console.ReadLine();



            // INCIO DE STACK O PILA

            //Estructura de LIFO (Last In First Out) - El ultimo elemento que entra es el primero que sale

            //Stack<int> numeros = new Stack <int>();

            //// Para insertar un elemento se utiliza el metodo Push

            //for (int i = 1; i <= 10, i++) 
            //{
            //    numeros.Push(i);
            //}

            //// Sacar uno de los elementos de esa pila

            //var elemento = numeros.Pop();


            //// Se insertan de arriba abajo es decir el ultimo numero sera el 1 y el primero el 10. Se imprimer del mayor al menor y en las colas del menor al mayor
            //// Pila ----> 10 9 8 7 6 5 4 3 2 1 
            //// Cola ----> 1 2 3 4 5 6 7 8 9 10

            //while (numeros.Count() >0) 
            //{
            //    elemento = numeros.Pop();
            //    Console.WriteLine(elemento);
            //}

            //// FINAL DE STACK O PILA



            // DICCIONARIO GENERICO    DICTIONARY <T>


            //  IMPORTANTE -------------Un arreglo o una lista no pueden contener un indice diferente de un numero entero. Es decir , no podrias meter un caracter, una cadena, un double ...
            

            int[] numeros = new int[3] { 1, 2, 3 };

            numeros[0] = 20;

            Console.ReadLine();

            Dictionary<int, int> diccionario = new Dictionary<int, int>();
            Dictionary<string, string> frases = new Dictionary<string, string>();

            frases.Add("CP", "Alguna frase poetica");
            frases.Add("HP", " Curso de C#");

            foreach (var elemento in frases) 
            {
                string autor = elemento.Key;
                string frase = elemento.Value;

                Console.WriteLine($"{autor},{frase}");
            }

            // A traves de la llave modificamos su value

            frases["HP"] = "Cursos de Xamarin";

            foreach (var elemento in frases)
            {
                string autor = elemento.Key;
                string frase = elemento.Value;

                Console.WriteLine($"{autor},{frase}");
            }


            for (int i = 1; i < 10; i++) 
            {
                diccionario.Add(i, i);
            
            }








            // FINAL DE DICCIONARIO GENERICO





        }
    }
}
