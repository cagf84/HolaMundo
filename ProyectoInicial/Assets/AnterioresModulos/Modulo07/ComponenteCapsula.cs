using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponenteCapsula : MonoBehaviour
{
    public GameObject CapsulaEBAC;
    public bool cambiocolorCapsula;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        //GameObject tempGameObject = Instantiate<GameObject>(CapsulaEBAC);
        //Color c = new Color(Random.value, Random.value, Random.value);
        //tempGameObject.GetComponent<MeshRenderer>().material.color = c;

        CambiarcolorCapsulaEBAC();
    }

    public void CambiarcolorCapsulaEBAC()
    {
        GameObject tempGameObject = Instantiate<GameObject>(CapsulaEBAC);
        if (cambiocolorCapsula == true)
        {
            tempGameObject.GetComponent<MeshRenderer>().material.color = Color.white;
            cambiocolorCapsula = false;
        }
        else
        {
            tempGameObject.GetComponent<MeshRenderer>().material.color = Color.black;
            cambiocolorCapsula = true;
        }
    }

}


//En el primer GO crea una variable booleana que se modifique cada FixedUpdate, 
//    si su valor era falso, vuélvelo verdadero y viceversa, 
//    pon el color del GO blanco cuando sea verdadero y negro cuando sea falso.