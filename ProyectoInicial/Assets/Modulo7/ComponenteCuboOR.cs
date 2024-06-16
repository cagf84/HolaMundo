using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponenteCuboOR : MonoBehaviour
{
    public GameObject CuboEBAC_OR;
    ComponenteEsfera tempComponenteEsfera_OR;
    ComponenteCapsula tempComponenteCapsula_OR;
    public bool colorCuboEBAC_OR;
    public bool colorCapsulaEBAC_OR;
    int obtienecolor_OR = 0;
    public bool cambiocolorCubo_OR;

    void Start() 
    {


    }

    private void FixedUpdate()
    {
        //Se define funcion para solo 1 vez tomar el valor de los
        //bool de los ComponenteCubo y ComponenteEsfera
        ObtenerBooleanosGO_OR();
        CambiarcolorCuboEBAC_OR();

    }

    //obtiene el valor de las bool de los otros GO
    //Se obtiene una unica vez para estar siempre
    //obteniendo su valor, luego de eso se maneja individualmente
    private void ObtenerBooleanosGO_OR()
    {
        if (obtienecolor_OR == 0)
        {
            tempComponenteEsfera_OR = FindAnyObjectByType<ComponenteEsfera>();
            tempComponenteCapsula_OR = FindAnyObjectByType<ComponenteCapsula>();
            colorCuboEBAC_OR = tempComponenteEsfera_OR.cambiocolorEsfera;
            colorCapsulaEBAC_OR = tempComponenteCapsula_OR.cambiocolorCapsula;
            obtienecolor_OR++;

            //Usamos tabla verdad de lo explicado en el 7.2
            //(OR o ||)
            if (colorCuboEBAC_OR == true || colorCapsulaEBAC_OR == true)
            {
                cambiocolorCubo_OR = true;
            }
            else if(colorCuboEBAC_OR == true || colorCapsulaEBAC_OR == false)
            {
                cambiocolorCubo_OR = true;
            }
            else if (colorCuboEBAC_OR == false || colorCapsulaEBAC_OR == true)
            {
                cambiocolorCubo_OR = true;
            }
            else if (colorCuboEBAC_OR == false && colorCapsulaEBAC_OR == false)
            {
                cambiocolorCubo_OR = false;
            }
        }
    }

     
    //Cambia color
    public void CambiarcolorCuboEBAC_OR()
    {
        GameObject tempGameObject = Instantiate<GameObject>(CuboEBAC_OR);
        if (cambiocolorCubo_OR == true)
        {
            tempGameObject.GetComponent<MeshRenderer>().material.color = Color.white;
            cambiocolorCubo_OR = false;
        }
        else
        {
            tempGameObject.GetComponent<MeshRenderer>().material.color = Color.black;
            cambiocolorCubo_OR = true;
        }
    }
}
