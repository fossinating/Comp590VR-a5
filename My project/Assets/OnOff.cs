using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOff : MonoBehaviour
{
    private bool extended = true;
    private float maxHeight = 0.7f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            extended = !extended;
        }

        GetComponent<Transform>().localScale = new Vector3(0.05f, Mathf.Clamp(GetComponent<Transform>().localScale.y + Time.deltaTime * 0.7f * (extended ? 1 : -1), 0, maxHeight), 0.05f);
        Console.WriteLine(GetComponent<Transform>().localScale.y - maxHeight);
        GetComponent<Transform>().localPosition = new Vector3(0, 1.19f + (GetComponent<Transform>().localScale.y - maxHeight), -8.1f); ;
        GetComponent<Renderer>().enabled = GetComponent<Transform>().localScale.y > 0.001f;
    }
}
