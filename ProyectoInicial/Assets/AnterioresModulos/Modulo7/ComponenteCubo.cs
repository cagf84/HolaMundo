using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponenteCubo : MonoBehaviour
{
    public GameObject CuboEBAC;
    ComponenteEsfera tempComponenteEsfera;
    ComponenteCapsula tempComponenteCapsula;
    public bool colorCuboEBAC;
    public bool colorCapsulaEBAC;
    int obtienecolor = 0;
    public bool cambiocolorCubo;

    void Awake()
    {
        //GameObject tempGameObject = Instantiate<GameObject>(CuboEBAC);
        //Color c = new Color(Random.value, Random.value, Random.value);
        //tempGameObject.GetComponent<MeshRenderer>().material.color = c;
    }

    // Start is called before the first frame update
    void Start() 
    {


    }

    private void FixedUpdate()
    {
        //GameObject tempGameObject = Instantiate<GameObject>(CapsulaEBAC);
        //Color c = new Color(Random.value, Random.value, Random.value);
        //tempGameObject.GetComponent<MeshRenderer>().material.color = c; 
        
        //Se define funcion para solo 1 vez tomar el valor de los
        //bool de los ComponenteCubo y ComponenteEsfera
        ObtenerBooleanosGO();
        CambiarcolorCuboEBAC();

    }

    //obtiene el valor de las bool de los otros GO
    //Se obtiene una unica vez para estar siempre
    //obteniendo su valor, luego de eso se maneja individualmente
    private void ObtenerBooleanosGO()
    {
        if (obtienecolor == 0)
        {
            tempComponenteEsfera = FindAnyObjectByType<ComponenteEsfera>();
            tempComponenteCapsula = FindAnyObjectByType<ComponenteCapsula>();
            colorCuboEBAC = tempComponenteEsfera.cambiocolorEsfera;
            colorCapsulaEBAC = tempComponenteCapsula.cambiocolorCapsula;
            obtienecolor++;

            //Usamos tabla verdad de lo explicado en el 7.2
            //Podriamos evaluar solo una condicion donde ambas son verdaderas y para lo demas es false
            //pero se dejo asi para esta tarea (AND o &&)
            if (colorCuboEBAC == true && colorCapsulaEBAC == true)
            {
                cambiocolorCubo = true;
            }
            else if(colorCuboEBAC == true && colorCapsulaEBAC == false)
            {
                cambiocolorCubo = false;
            }
            else if (colorCuboEBAC == false && colorCapsulaEBAC == true)
            {
                cambiocolorCubo = false;
            }
            else if (colorCuboEBAC == false && colorCapsulaEBAC == false)
            {
                cambiocolorCubo = false;
            }
        }
    }

     
    //Cambia color
    public void CambiarcolorCuboEBAC()
    {
        GameObject tempGameObject = Instantiate<GameObject>(CuboEBAC);
        if (cambiocolorCubo == true)
        {
            tempGameObject.GetComponent<MeshRenderer>().material.color = Color.white;
            cambiocolorCubo = false;
        }
        else
        {
            tempGameObject.GetComponent<MeshRenderer>().material.color = Color.black;
            cambiocolorCubo = true;
        }
    }
}
