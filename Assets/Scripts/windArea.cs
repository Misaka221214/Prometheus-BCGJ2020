using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windArea : MonoBehaviour
{
    public int strength;
    public
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D other)
{
        var force = Random.Range(strength - 50, strength + 50);
        other.attachedRigidbody.AddForce(-force * other.attachedRigidbody.velocity);
    }
}
