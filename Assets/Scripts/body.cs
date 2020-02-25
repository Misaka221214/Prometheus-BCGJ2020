using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class body : MonoBehaviour
{
    private Rigidbody2D rigid;
    public float force = 0;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        // rigid.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("c"))
        {
            // rigid.freezeRotation = false;
            rigid.AddTorque(force, ForceMode2D.Force);
            rigid.AddForce(new Vector2(-force * 0.5f, 0f), ForceMode2D.Force);
        }
        if (Input.GetKey("n"))
        {
            // rigid.freezeRotation = false;
            rigid.AddTorque(-force, ForceMode2D.Force);
            rigid.AddForce(new Vector2(force * 0.5f, 0f), ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // rigid.freezeRotation = false;
            rigid.AddForce(new Vector2(0, force * 0.1f), ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // rigid.freezeRotation = false;
            rigid.AddForce(new Vector2(-force * 0.1f, 0), ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // rigid.freezeRotation = false;
            rigid.AddForce(new Vector2(force * 0.1f, 0), ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.Keypad0))
        {
            Debug.Log("Pad0 Reload");
            Manager.reload();
        }
    }
}
