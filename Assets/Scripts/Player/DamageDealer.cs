using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    public int myType;
    public int powerLevel;
    public HealthManager healthManager;
    public int damage = 1;
    

    // Start is called before the first frame update
    void Start()
    {
        {
            if (myType == 0)
            {
                //I am the player
                powerLevel = 1;
            }
            else if (myType == 1)
            {
                //I am the enemy
                powerLevel = 2;
            }
        }
        
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Enemy")
        {
            healthManager.TakeDamage(damage);
            Destroy(other.gameObject);

        }

       
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
