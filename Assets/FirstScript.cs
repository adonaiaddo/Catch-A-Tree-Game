using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    public float a = 5f;
    public float b = 2f;
    public bool canDisplay = false;
    public string myName = "Adonai";
    
    // Start is called before the first frame update
    // void Start()
    // {
    //     float a = 5f;
    //     float b = 2f;
    //     Debug.Log("a plus b = " + (a+b));
    //     Debug.Log("a minus b = " + (a-b));
    //     Debug.Log("a times b = " + (a*b));
    //     Debug.Log("a divided by b = " + (a/b));
    // }

    // Update is called once per frame
    void Update()
    {
        if (canDisplay == true) {
            Debug.Log("Hey, " + myName + " a plus b = " + (a+b));
        } else {
            Debug.Log("I will show you nothing!");
        }
    }
}