using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody m_Rigidbody;
    public float m_Speed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveInputs();
    }

    void MoveInputs()
    {
        if (Input.GetKey(KeyCode.W))
        {
            m_Rigidbody.velocity = transform.forward * m_Speed;
            Quaternion rotation = new Quaternion();
            rotation.eulerAngles = new Vector3(0, 0, 0);
            transform.rotation = rotation;
        }
    }
}
