using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Componente5 : MonoBehaviour
{
    public GameObject Item5;
    public Componente3 tempComponente3;
    public Componente4 tempComponente4;
    bool colorItem3;
    bool colorItem4;
    public bool cambiocolorItem5;

    // Start is called before the first frame update
    void Start() 
    {
        //Para ejecutarlo 1 vez
        //ObtenerBooleanosGO();
    }

    private void FixedUpdate()
    {
        CambiarColorItem5();
    }

    private void ObtenerBooleanosGO()
    {
        colorItem3 = tempComponente3.cambiocolorItem3;
        colorItem4 = tempComponente4.cambiocolorItem4;

        if (colorItem3 == true && colorItem4 == true)
        {
            cambiocolorItem5 = true;
        }
        else
        {
            cambiocolorItem5 = false;
        }
    }

    //Cambia color
    public void CambiarColorItem5()
    {
        GameObject tempGameObject = Instantiate<GameObject>(Item5);
        if (tempComponente3.cambiocolorItem3 == true && tempComponente4.cambiocolorItem4 == true)
        {
            tempGameObject.GetComponent<MeshRenderer>().material.color = Color.black;
            cambiocolorItem5 = false;
        }
        else
        {
            tempGameObject.GetComponent<MeshRenderer>().material.color = Color.white;
            cambiocolorItem5 = true;
        }
    }
}