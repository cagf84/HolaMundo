using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EjerciciosDeEstructuras : MonoBehaviour
{
    public List<int> listaNumeros = new List<int>();
    public List<int> listaOrdenada = new List<int>();
    public HashSet<int> hashSetInts = new HashSet<int>();
    public Stack<string> pilaString = new Stack<string>();
    public Queue<string> colaString = new Queue<string>();

    // Start is called before the first frame update
    void Start()
    {

        ///1
        miFuncion(20, Random.Range(0, 10), Random.Range(11, 20));
        Debug.Log("---------------------------------------------");

        ///2
        miFuncionOrdenada();
        Debug.Log("Ej2 - Lista de numeros ordenada");
        foreach (var numero in listaOrdenada)
        {
            Debug.Log(numero);
        }
        Debug.Log("---------------------------------------------");

        ///3
        listaNumeros.Clear();
        for (int i = 0; i < 20; i++)
        {
            listaNumeros.Add(Random.Range(0, 10));
        }
        miFuncionOrdenadaHashset(listaNumeros);
        Debug.Log("---------------------------------------------");

        ///4
        pilaString.Push("Tarea");
        pilaString.Push("Modulo");
        pilaString.Push("11v2");
        pilaString.Push("EBAC");
        pilaString.Push("2024");
        miFuncionPila(pilaString);
        Debug.Log("---------------------------------------------");
    }


    ///1.
    //Crea una funci�n que reciba como par�metros tres n�meros, llene una lista de
    //n�meros aleatorios del tama�o del primer n�mero y los rangos de los n�meros
    //aleatorios est�n dados por el segundo y tercer par�metro, la firma de la funci�n
    //ser� algo similar a: public List<int> miFuncion(int tama�o, int rangoInferior, int
    //rangoSuperior)
    private void miFuncion(int tama�o, int rangoInferior, int rangoSuperior)
    {
        for (int i = 0; i < tama�o; i++)
        {
            listaNumeros.Add(Random.Range(rangoInferior, rangoSuperior));
        }
        Debug.Log("Ej1 - Lista de numeros");
        foreach (var numero in listaNumeros)
        {
            Debug.Log(numero);
        }
    }

    ///2
    ///Crea una funci�n que reciba como entrada un arreglo de enteros, y regrese un 
    ///arreglo con los mismos n�meros pero ordenados de manera descendente.
    private List<int> miFuncionOrdenada()
    {
        listaNumeros.Clear();
        Debug.Log("Ej2 - Lista Original");
        for (int i = 0; i < 20; i++)
        {
            listaNumeros.Add(Random.Range(0, 20));
        }
        foreach (var numero in listaNumeros)
        {
            Debug.Log(numero);
        }
        listaOrdenada = listaNumeros.OrderByDescending(p => p).ToList();
        return listaOrdenada;
    }

    ///3
    ///Crea una funci�n que reciba una lista previamente llena de n�meros o strings 
    ///que contenga elementos repetidos, y de salida regresa un hashset sin elementos
    ///repetidos, puedes usar la funci�n contains o linq para simplificar esto.
    private void miFuncionOrdenadaHashset(List<int> ListaAOrdenar)
    {
        //Opcion A v2
        Debug.Log("Ej3 - Lista Original");
        foreach (var numero in ListaAOrdenar)
        {
            Debug.Log(numero);
            hashSetInts.Add(numero);
        }
        Debug.Log("Ej3 - Lista de numeros ordenada hashSet");
        foreach (var numero in hashSetInts)
        {
            Debug.Log(numero);
        }

        //Opcion B
        //Debug.Log("Lista Original");
        //foreach (var numero in ListaAOrdenar)
        //{
        //    Debug.Log(numero);
        //}
        //var QueryLinq = ListaAOrdenar.Distinct().ToList();
        //Debug.Log("lista de numeros ordenada");
        //foreach (var numero in QueryLinq)
        //{
        //    Debug.Log(numero);
        //}

        //Opcion C
        //Revision de Tarea otra opcion de aplicarlo
        //hashSetInts = new HashSet<int>(ListaAOrdenar);

        //Opcion A v1
        //Debug.Log("Lista Original");
        //foreach (var numero in ListaAOrdenar)
        //{
        //    Debug.Log(numero);
        //}
        //Debug.Log("lista de numeros ordenada hashSet");
        //for (int i = 0; i < ListaAOrdenar.Count; i++)
        //{
        //    if (!hashSetInts.Contains(ListaAOrdenar[i]))
        //    {
        //        hashSetInts.Add(ListaAOrdenar[i]);
        //    }
        //}
        //foreach (var numero in hashSetInts)
        //{
        //    Debug.Log(numero);
        //}
    }

    ///4
    ///Crea una funci�n que reciba una pila de strings, imprime sus contenidos y llena
    ///con ellos una cola de strings y ahora imprime los elementos de la cola utilizando
    ///los m�todos respectivos de cada estructura(push, pop, queue, dequeue y peek), 
    ///puedes copiar los elementos de la pila a la cola en el mismo uso del peek, esta
    ///funci�n no retornar� nada, solo imprimir� los valores en la consola.
    private void miFuncionPila(Stack<string> pilaEjemplo)
    {
        
        int contadorPila;

        //Opcion A v2
        Debug.Log("Ej4 - Pila Original");
        contadorPila = pilaEjemplo.Count;
        for (int i = 0; i < contadorPila; i++)
        {
            Debug.Log(pilaEjemplo.Peek());
            colaString.Enqueue(pilaEjemplo.Pop());
        }
        Debug.Log("Ej4 - Cola copiada Pila");
        foreach (var cola in colaString)
        {
            Debug.Log(cola);
        }


        //Opcion A v1
        //string contenido;
        //Debug.Log("Pila Original");
        //contadorPila = pilaEjemplo.Count;
        //for (int i = 0; i < contadorPila; i++)
        //{
        //    contenido = (string)pilaEjemplo.Pop();
        //    Debug.Log(contenido);
        //    colaString.Enqueue(contenido);
        //}
        //Debug.Log("Cola copiada Pila");
        //foreach (var cola in colaString)
        //{
        //    Debug.Log(cola);
        //}

        //Opcion2
        //Debug.Log("Pila Original");
        //foreach (var pila in pilaEjemplo)
        //{
        //    Debug.Log(pila);
        //    colaString.Enqueue(pila);
        //}

        //Debug.Log("Cola copiada Pila");
        //foreach (var cola in colaString)
        //{
        //    Debug.Log(cola);
        //}
    }
}
