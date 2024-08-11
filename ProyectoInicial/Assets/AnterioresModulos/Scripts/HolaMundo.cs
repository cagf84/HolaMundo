using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    int x;
    // Start is called before the first frame update
    void Start()
    {
        //x = 0;
        //print("Algo a mostrar");     
        
        //Debug.LogWarning("Algo salio con alerta");
        //Debug.LogError("Algo salio con Error");
    }

    // Update is called once per frame
    void Update()
    {
        //x = x + 1;
        //Debug.Log(x);
        //Debug.Log("Algo paso");

        Debug.Log("Hola desde Update");
    }

    private void FixedUpdate()
    {
        Debug.LogWarning("Hola desde Fixed Update cada 80 frames");
    }

    private void LateUpdate()
    {
        Debug.Log("Hola desde Late Update");
    }

    private void OnEnable()
    {
        Debug.LogWarning("El objeto ha sido habilitado");
    }

    private void OnDisable()
    {
        Debug.LogWarning("El objeto ha sido inhabilitado");
    }
}
