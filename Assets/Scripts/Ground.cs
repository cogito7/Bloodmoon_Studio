using JetBrains.Annotations;
using System.IO.IsolatedStorage;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class Ground : MonoBehaviour
{


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CreateGround();
    }


    void CreateGround()
    {
        GameObject plane = GameObject.CreatePrimitive(PrimitiveType.Plane);
        plane.transform.localScale = new Vector3(2, 1, 2); //enlarges plane

        Renderer renderer = plane.GetComponent<Renderer>();
        renderer.material.color = Color.green;
    }



    // Update is called once per frame
    void Update()
    {

    }

}