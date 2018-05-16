using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : Entity 
{

    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
        //other.GetComponent<ParticleSystem>().Play();
        
    }
}
