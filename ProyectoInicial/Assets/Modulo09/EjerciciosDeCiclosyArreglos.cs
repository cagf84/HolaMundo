using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EjerciciosDeCiclosyArreglos : MonoBehaviour
{

    string JuntaPalabra;

    // Start is called before the first frame update
    void Start()
    {

        //1) Crea dos arreglos unidimensionales de números enteros y llenalos usando un ciclo y la
        //función Random.Range con números enteros, después crea un tercer arreglo y llénalo
        //con la suma de los elementos de los primeros dos: por ejemplo arr3[5] = arr1[5] + arr[6]
        int[] miArreglo1 = new int[5];
        int[] miArreglo2 = new int[5];
        int[] miArreglo3 = new int[5];
        int num1;
        int num2;

        for (int i = 0; i < miArreglo1.Length; i++)
        {
            num1 = Random.Range(1, 10);
            miArreglo1[i] = num1;
            num2 = Random.Range(11, 20);
            miArreglo2[i] = num2;
        }

        for (int x = 0; x < miArreglo3.Length; x++)
        {
            miArreglo3[x] = miArreglo1[x] + miArreglo2[x];
            Debug.Log($"A1[{x}].valor[{miArreglo1[x]}] + A2[{x}].valor[{miArreglo2[x]}] = A3[{x}].valor[{miArreglo3[x]}]");
        }

        //2) Crea un arreglo de strings y llena cada elemento con una palabra de una oración, 
        //después utilizando un ciclo foreach concatena sus elementos e imprime la oración
        //completa en la consola en un solo string.
        string[] Horacion = new string[9] { "T", "a", "r", "e", "a", " ", "N", "9", "v2" };

        foreach (string Palabra in Horacion)
        {
            JuntaPalabra += Palabra;
        }
        Debug.Log(JuntaPalabra);


        //3) Crea un arreglo bidimensional de enteros de 2 renglones y 3 columnas al menos y
        //multiplícalo por un arreglo unidimensional de enteros con la cantidad de elementos
        //que se alinee a la cantidad de renglones del arreglo bidimensional de tal manera que
        //la operación sea una multiplicación matriz* vector que da como resultado un arreglo
        //unidimensional descrito en la siguiente fórmula:
        int[,] miMatrizMult = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        int[,] miArregloMult = new int[3, 1] { { 7 }, { 8 }, { 9 } };
        int[,] Multiplicacion = new int[miMatrizMult.GetLength(0), miArregloMult.GetLength(1)];

        for (int x = 0; x < miMatrizMult.GetLength(0); x++)
        {
            for (int y = 0; y < miArregloMult.GetLength(1); y++)
            {
                Multiplicacion[x, y] = 0;
                for (int z = 0; z < miMatrizMult.GetLength(1); z++)
                {
                    Multiplicacion[x, y] = miMatrizMult[x, z] * miArregloMult[z, y] + Multiplicacion[x, y];
                }
            }
        }

        for (int j = 0; j < Multiplicacion.GetLength(0); j++)
        {
            for (int k = 0; k < Multiplicacion.GetLength(1); k++)
            {
                Debug.Log($"La Multiplicacion de los arreglos es: Multiplicacion[{j}].[{k}].valor[{Multiplicacion[j, k]}]");
            }
        }

    }

}