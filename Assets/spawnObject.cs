using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObject : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameObject;
    public int strength;
    public int frequency;
    public GameObject player;
    int count;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        if (count % frequency == 0) {
            spawn();
        }
    }

    void spawn() {
        float x = player.transform.position.x;
        float y = player.transform.position.y;
        Vector2 vector = new Vector2(Random.Range(x-30, x+30), y + strength);
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        gameObject.transform.position = vector;
        gameObject.transform.rotation = new Quaternion();
    }
}
