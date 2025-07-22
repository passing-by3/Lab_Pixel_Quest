using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerstats : MonoBehaviour
{
    public string nextLevel = "Level 1";
    public int coincount = 0;
    public int heart = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
                    SceneManager.LoadScene(nextLevel);
                    Debug.Log("Next level reached");
                    break;
                }

            case "coin":
                {
                    coincount++;
                    Destroy(collision.gameObject);
                    break;
                }

            case "heart":
                {
                    heart++;
                    Destroy(collision.gameObject);
                    break;
                }
        }
    }
}
