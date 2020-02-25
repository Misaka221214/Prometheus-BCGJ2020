using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ignoreColl : MonoBehaviour
{
    public Collider2D[] list = { };
    // public Collider2D body;
    // Start is called before the first frame update
    void Start()
    {
        foreach(Collider2D coll in list)
        {
            foreach(Collider2D coll2 in list)
            {
                Physics2D.IgnoreCollision(coll, coll2);
            }
        }
    }
}
