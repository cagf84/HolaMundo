using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponenteCrearCuboAwake : MonoBehaviour
{
    GameObject objToSpawn;
    Vector3[] vertices = {
        new Vector3(0,0,0),      //Vertice0
        new Vector3(1,0,0),      //Vertice1
        new Vector3(1,1,0),      //Vertice2
        new Vector3(0,1,0),      //Vertice3
        new Vector3(0,1,1),      //Vertice4
        new Vector3(1,1,1),      //Vertice5
        new Vector3(1,0,1),      //Vertice6
        new Vector3(0,0,1),      //Vertice7
    };

    int[] triangulos = {
        0,2,1,                  //Cara 1
        0,3,2,
        2,3,4,                  //Cara 2
        2,4,5,
        1,2,5,                  //Cara 3
        1,5,6,
        0,7,4,                  //Cara 4
        0,4,3,
        5,4,7,                  //Cara 5
        5,7,6,
        0,6,7,                  //Cara 6
        0,1,6
     };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Awake()
    {
        objToSpawn = new GameObject("CuboCreadoAwake");
        objToSpawn.AddComponent<MeshFilter>();
        var meshfilter = objToSpawn.GetComponent<MeshFilter>().mesh;
        meshfilter.Clear();
        meshfilter.vertices = vertices;
        meshfilter.triangles = triangulos;
        meshfilter.Optimize();
        meshfilter.RecalculateNormals();

        objToSpawn.AddComponent<BoxCollider>();
        var boxcollider = objToSpawn.GetComponent<BoxCollider>();
        boxcollider.center = new Vector3(0.5f, 0.5f, 0.5f);

        objToSpawn.AddComponent<MeshRenderer>();
        var meshrender = objToSpawn.GetComponent<MeshRenderer>().material;

        Color c = new Color(Random.value, Random.value, Random.value);
        meshrender.color = c;
        objToSpawn.transform.position = Vector3.one;
    }
}
