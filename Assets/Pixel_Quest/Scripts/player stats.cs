using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerstats : MonoBehaviour
{
    public Transform respawn;
    public string nextLevel = "Level 1";
    public int coincount = 0;
    public int heart = 3;
    public int heartmax = 0;
    private playerUIcontrol pUIc;


    // Start is called before the first frame update
    private void Start()
    {
        pUIc = GetComponent<playerUIcontrol>();
        pUIc.UpdateHealth(heart, heartmax);
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
                    heart--;
                    pUIc.UpdateHealth(heart, heartmax);
                    if (heart <= 0)
                    {
                        string thisLevel = SceneManager.GetActiveScene().name;
                        SceneManager.LoadScene(thisLevel);
                    }
                    else
                    {
                        transform.position = respawn.position;
                    }
                    break;
                }

            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    Debug.Log("Next level reached");
                    break;
                }

            case "Coin":
                {
                    coincount++;
                    Destroy(collision.gameObject);
                    break;
                }

            case "Health":
                {
                    if (heart < 3)
                    {
                        heart++;
                        pUIc.UpdateHealth(heart, heartmax);
                        Destroy(collision.gameObject);
                    }
                    
                    break;
                }

            case "Respawn":
                { 
                    respawn.position = collision.transform.Find("point").position;
                    break;
                }
        }
    }
}
