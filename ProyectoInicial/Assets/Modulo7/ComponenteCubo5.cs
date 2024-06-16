using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponenteCubo5 : MonoBehaviour
{
    public GameObject Cubo5;
    ComponenteCubo tempComponenteCubo;
    ComponenteCuboOR tempComponenteCuboOR;
    public bool colorCubo5;
    public bool colorCuboOR5;
    int obtienecolor5 = 0;
    public bool cambiocolorCubo5;

    void Start() 
    {


    }

    private void FixedUpdate()
    {
        ObtenerBooleanosGO5();
        CambiarcolorCubo5();

    }

    //obtiene el valor de las bool de los otros GO
    //Se obtiene una unica vez para estar siempre
    //obteniendo su valor, luego de eso se maneja individualmente
    private void ObtenerBooleanosGO5()
    {
        if (obtienecolor5 == 0)
        {
            tempComponenteCubo = FindAnyObjectByType<ComponenteCubo>();
            tempComponenteCuboOR = FindAnyObjectByType<ComponenteCuboOR>();
            colorCubo5 = tempComponenteCubo.cambiocolorCubo;
            colorCuboOR5 = tempComponenteCuboOR.cambiocolorCubo_OR;
            obtienecolor5++;

            //Usamos tabla verdad de lo explicado en el 7.2
            //Podriamos evaluar solo una condicion donde ambas son verdaderas y para lo demas es false
            //pero se dejo asi para esta tarea (AND o &&)
            if (colorCubo5 == true && colorCuboOR5 == true)
            {
                cambiocolorCubo5 = true;
            }
            else if(colorCubo5 == true && colorCuboOR5 == false)
            {
                cambiocolorCubo5 = false;
            }
            else if (colorCubo5 == false && colorCuboOR5 == true)
            {
                cambiocolorCubo5 = false;
            }
            else if (colorCubo5 == false && colorCuboOR5 == false)
            {
                cambiocolorCubo5 = false;
            }
        }
    }

     
    //Cambia color
    public void CambiarcolorCubo5()
    {
        GameObject tempGameObject = Instantiate<GameObject>(Cubo5);
        if (cambiocolorCubo5 == true)
        {
            tempGameObject.GetComponent<MeshRenderer>().material.color = Color.white;
            cambiocolorCubo5 = false;
        }
        else
        {
            tempGameObject.GetComponent<MeshRenderer>().material.color = Color.black;
            cambiocolorCubo5 = true;
        }
    }
}
