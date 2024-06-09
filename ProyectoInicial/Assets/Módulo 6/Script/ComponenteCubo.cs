using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponenteCubo : MonoBehaviour
{

    public GameObject CuboEBAC;

    void Awake()
    {
        GameObject tempGameObject = Instantiate<GameObject>(CuboEBAC);
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }


}
