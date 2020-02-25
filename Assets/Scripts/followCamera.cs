using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCamera : MonoBehaviour
{
    public Transform trans;
    public Transform myTrans;
    // Start is called before the first frame update
    void Start()
    {
        myTrans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        myTrans.position = new Vector3(trans.position.x, trans.position.y, 10f);
    }
}
