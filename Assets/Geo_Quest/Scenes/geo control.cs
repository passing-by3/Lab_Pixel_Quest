using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class geocontrol : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    public int speed = 3;
    public string nextLevel = "Level 1";
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xSpeed * speed, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Alpha1)) 
        { sr.color = Color.yellow; }
        if (Input.GetKeyDown(KeyCode.Alpha2)) 
        { sr.color = Color.red; }
        if (Input.GetKeyDown(KeyCode.Alpha3)) 
        { sr.color = Color.blue; }
        /*if (Input.GetKeyDown(KeyCode.W))
        {transform.position += new Vector3(0, 1, 0);}
        if (Input.GetKeyDown(KeyCode.S))
        {transform.position += new Vector3(0, -1, 0);}
        if (Input.GetKeyDown(KeyCode.D))
        {transform.position += new Vector3(1, 0, 0);}
        if (Input.GetKeyDown(KeyCode.A))
        {transform.position += new Vector3(-1, 0, 0);}*/

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    Debug.Log("Player has died");
                    break;
                }

            case "Finish":
                {
                    SceneManager.LoadScene (nextLevel);
                    Debug.Log("Next level reached");
                    break;
                }
        }
    }
}
