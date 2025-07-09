using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geocontrol : MonoBehaviour
{
    int var = 3;
    string varOne = "Hello ";
    // Start is called before the first frame update
    void Start()
    {
        string varTwo = "World";
     Debug.Log(varOne + varTwo);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(var);
        var++;

    }
}
