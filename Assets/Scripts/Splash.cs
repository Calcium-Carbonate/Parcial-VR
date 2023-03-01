using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splash : MonoBehaviour
{   int count = 0;
    [SerializeField] ParticleSystem splash1;
    [SerializeField] ParticleSystem splash2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        splash1.Play(true);
        count++;
        Destroy(other.gameObject);
        if (other.CompareTag("Ingredient"))
        {
            if (count == 3)
            {
                splash2.Play(true);
                count = 0;
            }
        }
       


    }
}
