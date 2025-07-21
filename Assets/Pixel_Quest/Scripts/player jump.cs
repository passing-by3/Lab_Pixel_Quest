using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerjump : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpForce = 10;
    public float fallForce = -1;
    private Vector2 gf;

    public float capsuleHeight = .25f;
    public float capsuleRadius = .08f;

    public Transform feetCollider;
    public LayerMask groundMask;
    private bool gc;

    private bool wc;
    private string wt = "Water";
    // Start is called before the first frame update
    void Start()
    {
        gf = new Vector2(0, Physics2D.gravity.y);
        rb  = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        gc = Physics2D.OverlapCapsule(feetCollider.position, new Vector2(capsuleHeight, capsuleRadius), CapsuleDirection2D.Horizontal, 0, groundMask);

        if (Input.GetKeyDown(KeyCode.Space) && (gc || wc))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        if(rb.velocity.y<0)
        {
            rb.velocity += gf * (fallForce * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag(wt))
        {
            wc = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(wt))
        {
            wc = false;
        }
    }
}
