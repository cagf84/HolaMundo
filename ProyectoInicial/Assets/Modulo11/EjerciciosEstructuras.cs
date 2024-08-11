using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEditor.Experimental.GraphView;

public class EjerciciosEstructuras : MonoBehaviour
{
    public List<int> listaNumeros = new List<int>();
    public HashSet<int> hashSetInts = new HashSet<int>();
    public Stack<string> pilaString = new Stack<string>();
    public Queue<string> colaString = new Queue<string>();

    // Start is called before the first frame update
    void Start()
    {

        ///1
        miFuncion(20, Random.Range(0, 10), Random.Range(11, 20));


        ///2
        miFuncionOrdenada();

        ///3
        listaNumeros.Clear();
        for (int i = 0; i < 20; i++)
        {
            listaNumeros.Add(Random.Range(0, 10));
        }
        miFuncionOrdenadaHashset(listaNumeros);


        ///4
        pilaString.Push("Tarea");
        pilaString.Push("Modulo");
        pilaString.Push("11");
        pilaString.Push("EBAC");
        pilaString.Push("2024");
        miFuncionPila(pilaString);
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
            //listaNumeros.Add(i);
            listaNumeros.Add(Random.Range(rangoInferior, rangoSuperior));
        }
        foreach (var numero in listaNumeros)
        {
            Debug.Log(numero);
        }
    }

    ///2
    ///Crea una funci�n que reciba como entrada un arreglo de enteros, y regrese un 
    ///arreglo con los mismos n�meros pero ordenados de manera descendente.
    private void miFuncionOrdenada()
    {
        listaNumeros.Clear();
        for (int i = 0; i < 20; i++)
        {
            listaNumeros.Add(Random.Range(0, 20));
        }
        foreach (var numero in listaNumeros)
        {
            Debug.Log(numero);
        }
        var listaOrdenada = listaNumeros.OrderByDescending(p => p).ToList();
        Debug.Log("lista de numeros ordenada");
        foreach (var numero in listaOrdenada)
        {
            Debug.Log(numero);
        }
    }

    ///3
    ///Crea una funci�n que reciba una lista previamente llena de n�meros o strings 
    ///que contenga elementos repetidos, y de salida regresa un hashset sin elementos
    ///repetidos, puedes usar la funci�n contains o linq para simplificar esto.
    private void miFuncionOrdenadaHashset(List<int> ListaAOrdenar)
    {
        //Metodo A
        Debug.Log("Lista Original");
        foreach (var numero in ListaAOrdenar)
        {
            Debug.Log(numero);
        }
        Debug.Log("lista de numeros ordenada hashSet");
        for (int i = 0; i < ListaAOrdenar.Count; i++)
        {
            if (!hashSetInts.Contains(ListaAOrdenar[i]))
            {
                hashSetInts.Add(ListaAOrdenar[i]);
            }
        }
        foreach (var numero in hashSetInts)
        {
            Debug.Log(numero);
        }

        //Metodo B
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
    }

    ///4
    ///Crea una funci�n que reciba una pila de strings, imprime sus contenidos y llena
    ///con ellos una cola de strings y ahora imprime los elementos de la cola utilizando
    ///los m�todos respectivos de cada estructura(push, pop, queue, dequeue y peek), 
    ///puedes copiar los elementos de la pila a la cola en el mismo uso del peek, esta
    ///funci�n no retornar� nada, solo imprimir� los valores en la consola.
    private void miFuncionPila(Stack<string> pilaEjemplo)
    {
        string contenido;
        int contadorPila;

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

        Debug.Log("Pila Original");
        contadorPila = pilaEjemplo.Count;
        for (int i = 0; i < contadorPila; i++)
        {
            contenido = (string)pilaEjemplo.Pop();
            Debug.Log(contenido);
            colaString.Enqueue(contenido);
        }
        Debug.Log("Cola copiada Pila");
        foreach (var cola in colaString)
        {
            Debug.Log(cola);
        }
    }
}