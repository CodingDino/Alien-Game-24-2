using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Print the log to the console window
        Debug.Log("Hello world.");

        transform.Translate(2, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.001f, 0, 0);
    }
}
