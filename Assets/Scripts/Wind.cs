using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public float xForce;
    public float yForce;
    private Rigidbody2D rigid;
    private PolygonCollider2D coll;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        coll = GetComponent<PolygonCollider2D>();
        rigid.gravityScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        rigid.AddForce(new Vector2(xForce, yForce), ForceMode2D.Force);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        coll.enabled = false;
        Destroy(this, 5f);
    }
}
