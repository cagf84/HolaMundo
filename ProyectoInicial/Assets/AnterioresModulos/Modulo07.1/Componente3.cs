using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente3 : MonoBehaviour
{
    public GameObject Item3;
    public Componente1 tempComponente1;
    public Componente2 tempComponente2;
    bool colorItem1;
    bool colorItem2;
    public bool cambiocolorItem3;

    // Start is called before the first frame update
    void Start() 
    {
        //Para ejecutarlo 1 vez
        //ObtenerBooleanosGO();
    }

    private void FixedUpdate()
    {
        CambiarColorItem3();
    }

    private void ObtenerBooleanosGO()
    {
        colorItem1 = tempComponente1.cambiocolorItem1;
        colorItem2 = tempComponente2.cambiocolorItem2;

        if (colorItem1 == true && colorItem2 == true)
        {
            cambiocolorItem3 = true;
        }
        else
        {
            cambiocolorItem3 = false;
        }
    }

    //Cambia color
    public void CambiarColorItem3()
    {
        GameObject tempGameObject = Instantiate<GameObject>(Item3);
        if (tempComponente1.cambiocolorItem1 == true && tempComponente2.cambiocolorItem2 == true)
        {
            tempGameObject.GetComponent<MeshRenderer>().material.color = Color.black;
            cambiocolorItem3 = false;
        }
        else
        {
            tempGameObject.GetComponent<MeshRenderer>().material.color = Color.white;
            cambiocolorItem3 = true;
        }
    }
}