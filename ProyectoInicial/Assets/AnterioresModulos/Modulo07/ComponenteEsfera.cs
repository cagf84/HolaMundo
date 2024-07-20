using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponenteEsfera : MonoBehaviour
{
    public GameObject EsferaEBAC;
    public bool cambiocolorEsfera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject tempGameObject = Instantiate<GameObject>(EsferaEBAC);
        //Color c = new Color(Random.value, Random.value, Random.value);
        //tempGameObject.GetComponent<MeshRenderer>().material.color = c;
    }

    private void FixedUpdate()
    {
        //GameObject tempGameObject = Instantiate<GameObject>(CapsulaEBAC);
        //Color c = new Color(Random.value, Random.value, Random.value);
        //tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        CambiarcolorEsferaEBAC();

    }
    public void CambiarcolorEsferaEBAC()
    {
        GameObject tempGameObject = Instantiate<GameObject>(EsferaEBAC);
        if (cambiocolorEsfera == true)
        {
            tempGameObject.GetComponent<MeshRenderer>().material.color = Color.white;
            cambiocolorEsfera = false;
        }
        else
        {
            tempGameObject.GetComponent<MeshRenderer>().material.color = Color.black;
            cambiocolorEsfera = true;
        }
    }

}
