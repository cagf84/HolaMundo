using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente1 : MonoBehaviour
{
    public GameObject Item1;
    public bool cambiocolorItem1;

    private void FixedUpdate()
    {
        CambiarColorItem1();
    }

    private void CambiarColorItem1()
    {
        GameObject tempGameObject = Instantiate<GameObject>(Item1);
        if (cambiocolorItem1 == true)
        {
            tempGameObject.GetComponent<MeshRenderer>().material.color = Color.white;
            cambiocolorItem1 = false;
        }
        else
        {
            tempGameObject.GetComponent<MeshRenderer>().material.color = Color.black;
            cambiocolorItem1 = true;
        }
    }
}
