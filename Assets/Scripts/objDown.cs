using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objDown : MonoBehaviour
{
    public GameObject obj;
    private int startY = 20;
    private int endY = -10;

    // Start is called before the first frame update
    void Start()
    {
        obj.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.x);

    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.Translate(Vector3.down * 10 * Time.deltaTime, Space.World);
        if (obj.transform.position.y <= endY)
        {
            transform.position = new Vector3(transform.position.x, startY, transform.position.z);
        }
    }
}
