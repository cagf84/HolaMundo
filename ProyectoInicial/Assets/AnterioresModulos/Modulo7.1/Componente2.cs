using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente2 : MonoBehaviour
{
    public GameObject Item2;
    public bool cambiocolorItem2;

    private void FixedUpdate()
    {
        CambiarColorItem2();

    }
    private void CambiarColorItem2()
    {
        GameObject tempGameObject = Instantiate<GameObject>(Item2);
        if (cambiocolorItem2 == true)
        {
            tempGameObject.GetComponent<MeshRenderer>().material.color = Color.white;
            cambiocolorItem2 = false;
        }
        else
        {
            tempGameObject.GetComponent<MeshRenderer>().material.color = Color.black;
            cambiocolorItem2 = true;
        }
    }
}