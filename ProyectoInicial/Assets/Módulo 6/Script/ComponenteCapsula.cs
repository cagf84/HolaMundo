using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponenteCapsula : MonoBehaviour
{
    public GameObject CapsulaEBAC;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        GameObject tempGameObject = Instantiate<GameObject>(CapsulaEBAC);
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
    }
}
