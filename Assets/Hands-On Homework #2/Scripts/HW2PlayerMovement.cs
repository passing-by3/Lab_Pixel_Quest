using UnityEngine;

public class HW2PlayerMovement : MonoBehaviour
{
    private Rigidbody2D m_Rigidbody;

    private float xspeed;
    private float yspeed;

    private string Inputx = "Horizontal";
    private string Inputy = "Vertical";

    public float speed = 3;

    private void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        xspeed = Input.GetAxis("Horizontal");
        yspeed = Input.GetAxis("Vertical");

        m_Rigidbody.velocity = new Vector2 (xspeed, yspeed) * speed;
    }
}
