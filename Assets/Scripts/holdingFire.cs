using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holdingFire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");
        if (collision.gameObject.tag == "Wind")
        {
            Debug.Log("Wind and Fire Collision");
            Manager.reload();
        }
    }
}
