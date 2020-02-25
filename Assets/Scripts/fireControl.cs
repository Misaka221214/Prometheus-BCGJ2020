using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireControl : MonoBehaviour
{
    public GameObject leftFire;
    public GameObject left;
    public GameObject rightFire;
    public GameObject right;
    public GameObject lf;
    public GameObject rf;
    private bool l = true;
    private bool r = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("t"))
        {
            if(l && !r)
            {
                r = true;
                l = false;
            }
            else
            {
                r = false;
                l = true;
            }
        }
        if (l && r)
        {
            l = true;
            r = false;
        }
        if(l)
        {
            setAbleThis(leftFire, true);
            setAbleThis(left, false);
            setAbleThis(rightFire, false);
            setAbleThis(right, true);
            setFire(lf, true);
            setFire(rf, false);
        }
        if (r)
        {
            setAbleThis(leftFire, false);
            setAbleThis(left, true);
            setAbleThis(rightFire, true);
            setAbleThis(right, false);
            setFire(lf, false);
            setFire(rf, true);
        }
    }

    private void setAbleThis(GameObject gm, bool b)
    {
        gm.GetComponent<Collider2D>().enabled = b;
        gm.GetComponent<SpriteRenderer>().enabled = b;
    }
    private void setFire(GameObject gm, bool b)
    {
        gm.GetComponent<Collider2D>().enabled = b;
    }
}
