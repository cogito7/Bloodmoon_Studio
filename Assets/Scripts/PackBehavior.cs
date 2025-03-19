using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackBehavior : MonoBehaviour
{
    public GameObject leader;
    public float speed;

    private void FixedUpdate()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SwarmAround();
    }

    public void SwarmAround()
    {
        transform.RotateAround(leader.transform.position, Vector3.up, speed * Time.deltaTime);
    }
}
