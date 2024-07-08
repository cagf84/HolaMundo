using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    public GameObject Cubo;

    int incremeta1 =0;
    float incremeta2=1;
    bool cambiocolor;
    int miCastOperacion;
    string ParOImpar;
    float varNumeroPI = 3.1415f;
    string varCastNumeroPI;
    string varLetraNumero1;
    string varLetraNumero2; 
    string varLetraNumero3;
    string varLetraNumero4;
    string varPalabra = "Tarea numero 8";
    string varPalabrasPar;

    void Start()
    {

        //Crea dos variables flotantes, has una operación entre ellas y obtén el resultado en un tipo de 
        //dato entero que requiera un casteo explícito.
        float num1 = Random.Range(1, 10);
        float num2 = Random.Range(1, 10);
        float miOperacion;
        float miResultado;

        miOperacion = Random.Range(1, 4);

        if (miOperacion == 1)
        {
            miResultado = num1 + num2;
            miCastOperacion = (int)miResultado;
            Debug.Log($"El valor {num1} - {num2} fue sumado y es: {miCastOperacion}");
        }
        else if (miOperacion == 2)
        {
            miResultado = num1 - num2;
            miCastOperacion = (int)miResultado;
            Debug.Log($"El valor {num1} - {num2} fue restado y es: {miCastOperacion}");
        }
        else if (miOperacion == 3)
        {
            miResultado = num2 * num1;
            miCastOperacion = (int)miResultado;
            Debug.Log($"El valor {num1} - {num2} fue multiplicado y es: {miCastOperacion}");

        }
        else
        {
            Debug.Log("No se hizo nada");
        }

        if (miCastOperacion % 2 == 0)
        {
            ParOImpar = "Par";
        }
        else
        {
            ParOImpar = "ImPar";
        }


        //Convertir un numero flotante a string e imprimir 4 posiciones de precisión (decimales).
        varCastNumeroPI = varNumeroPI.ToString();
        Debug.Log(varCastNumeroPI);
        varLetraNumero1 = varCastNumeroPI[2].ToString();
        Debug.Log(varLetraNumero1);
        varLetraNumero2 = varCastNumeroPI[3].ToString();
        Debug.Log(varLetraNumero2);
        varLetraNumero3 = varCastNumeroPI[4].ToString();
        Debug.Log(varLetraNumero3);
        varLetraNumero4 = varCastNumeroPI[5].ToString();
        Debug.Log(varLetraNumero4);


        //Utilizar el método substring para separar su nombre completo en 3 strings y utilizar el
        //método Split para separar su nombre completo en una lista de strings.
        string varNombreCompleto = "Cristian Godoy Fuentes";
        string[] varNombre = varNombreCompleto.Split(" ");
        Debug.Log("El nombre es: " + varNombre[0]);
        Debug.Log("El Apellido Paterno es: " + varNombre[1]);
        Debug.Log("El Apellido Materno es: " + varNombre[2]);


        //Crea dos variables string que guarden valores numéricos de miles, pasalas a tipos de datos 
        //numéricos utilizando la función tryParse, realiza una operación con ellas e imprime el resultado.
        int varCastAno1;
        int varCastAno2;
        string varAno1;
        string varAno2;

        varAno1 = "1984";
        varAno2 = "2024";

        if (!int.TryParse(varAno1.ToString(), out varCastAno1))
        {
            Debug.LogError("eso no es un tipo de dato valido");
        }
        else
        {
            Debug.Log(varCastAno1);
        }
        
        if (!int.TryParse(varAno2.ToString(), out varCastAno2))
        {
            Debug.LogError("eso no es un tipo de dato valido");
        }
        else
        {
            Debug.Log(varCastAno2);
        }

        //Crea un string con una oración, imprime sólo los caracteres que se encuentren en un índice
        //par, por ejemplo “Hola Mundo”, solo deberá imprimir los caracteres: H,l, ,u,d. (recuerda para
        //qué sirve el uso del operador módulo).
        CuentaPalabras();
        Debug.Log(varPalabrasPar);

        //Crea un string guarda, una oración en él y elimina los primeros 5 caracteres de este ya sea
        //con la función substring, Split, o cualquier otro método disponible en la clase String.
        string varEliminaPalabras = varPalabra.Substring(6);
        Debug.Log(varEliminaPalabras);
    }

    // Update is called once per frame
    void Update()
    {
        incremeta1++;
        //Debug.Log($"El valor int es: {incremeta1}");
    }

    void FixedUpdate()
    {
        incremeta2*=2;
        //Debug.Log($"El valor float es: {incremeta2}");
        CambiarColorItem();
    }

    void CambiarColorItem()
    {
        //Utilizar un string y una sentencia switch y dependiendo de la palabra, el cubo deberá 
        //cambiar de color.
        
        GameObject tempGameObject = Instantiate<GameObject>(Cubo);
        switch (ParOImpar)
        {
            case "Par":
                tempGameObject.GetComponent<MeshRenderer>().material.color = Color.white;
                ParOImpar = "ImPar";
                break;
            case "ImPar":
                tempGameObject.GetComponent<MeshRenderer>().material.color = Color.black;
                ParOImpar = "Par";
                break;
            default:
                break;
        }
    }

    void CuentaPalabras()
    {
        for (int i = 0; i < varPalabra.Length; i++)
        {
            if (varPalabra[i] % 2 == 0)
            {
                if (i == 0)
                {
                    varPalabrasPar = varPalabra[i].ToString();
                }
                else{
                    varPalabrasPar = varPalabrasPar + "," + varPalabra[i].ToString();
                }                
            }
        }
    }

}
