using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : MonoBehaviour
{

    public Transform player;

    public float speed = 2f;
    public int t = 0;
    private NavMeshAgent agent;

    private bool chasingPlayer = true;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //locate player and chase if within close proximity
        if (chasingPlayer && player != null)
        {
            Debug.Log("Chasing Player "+ player.position);
            agent.SetDestination(player.position);
        }
        

    }
    


    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something entered: " + other.gameObject.name); // Debug log
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player detected - start chasing!");
            chasingPlayer = true;
        }
    }







}
