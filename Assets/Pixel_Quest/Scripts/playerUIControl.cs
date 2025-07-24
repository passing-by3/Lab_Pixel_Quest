using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerUIcontrol : MonoBehaviour
{
    public Image heartImage;
    // Start is called before the first frame update
    private void Start()
    {
        heartImage = GameObject.Find("heartImage").GetComponent<Image>();
    }

    public void UpdateHealth(float currentHealth, float maxHealth)
    {
        heartImage.fillAmount = currentHealth / maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
