using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovements : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    public int speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        if (xInput > 0) {sr.flipX = true;}
        else if (xInput < 0) {sr.flipX=false;}
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
    }
}
