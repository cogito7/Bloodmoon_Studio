using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint; //tip of gun
    private int shooting;

    void Start()
    {
        shooting = 1;// Default shooting mode

    }

    void Update()
    {
        Shoot();
    }
    void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            switch (shooting)
            {
                case 1:
                    //Create a single bullet
                    Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

                    break;
                case 2:

                    //Create two bullets (spread shot)
                    Instantiate(bulletPrefab, firePoint.position + new Vector3(-0.5f, 0, 0), firePoint.rotation);
                    Instantiate(bulletPrefab, firePoint.position + new Vector3(0.5f, 0, 0), firePoint.rotation);

                    break;
            }
        }
    }

    }
