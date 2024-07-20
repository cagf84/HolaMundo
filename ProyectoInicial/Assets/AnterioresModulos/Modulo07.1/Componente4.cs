using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Componente4 : MonoBehaviour
{
    public GameObject Item4;
    public Componente1 tempComponente1;
    public Componente2 tempComponente2;
    bool colorItem1;
    bool colorItem2;
    public bool cambiocolorItem4;

    // Start is called before the first frame update
    void Start()
    {
        //Para ejecutarlo 1 vez
        //ObtenerBooleanosGO();
    }

    private void FixedUpdate()
    {
        CambiarColorItem4();
    }

    private void ObtenerBooleanosGO()
    {
        colorItem1 = tempComponente1.cambiocolorItem1;
        colorItem2 = tempComponente2.cambiocolorItem2;

        if (colorItem1 == false || colorItem2 == false)
        {
            cambiocolorItem4 = false;
        }
        else 
        {
            cambiocolorItem4 = true;
        }
    }

    //Cambia color
    public void CambiarColorItem4()
    {
        GameObject tempGameObject = Instantiate<GameObject>(Item4);
        if (tempComponente1.cambiocolorItem1 == false || tempComponente2.cambiocolorItem2 == false)
        {
            tempGameObject.GetComponent<MeshRenderer>().material.color = Color.white;
            cambiocolorItem4 = true;
        }
        else
        {
            tempGameObject.GetComponent<MeshRenderer>().material.color = Color.black;
            cambiocolorItem4 = false;
        }
    }
}