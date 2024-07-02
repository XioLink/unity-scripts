using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steave : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0, 1, -5);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(1, 1, -5);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-1, 1, -5);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(1, 0, -5);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-1, 0, -5);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(1, -1, -5);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-1, -1, -5);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0, 2, -5);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(1, 2, -5);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-1, 2, -5);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0, 3, -5);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(1, 3, -5);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-1, 3, -5);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0, 4, -5);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(1, 4, -5);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-1, 4, -5);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0, 5, -5);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-2, 3, -5);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-3, 3, -5);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-3, 4, -5);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(2, 3, -5);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(3, 3, -5);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(3, 4, -5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
