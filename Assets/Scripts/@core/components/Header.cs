using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Header : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Header work");

        Debug.Log(Calculator.Add(2, 5));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
