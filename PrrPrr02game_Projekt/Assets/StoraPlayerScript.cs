using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoraPlayerScript : PlayerScript 
{
    // Start is called before the first frame update
    void Start()
    {
        vanster = "left";
        hoger = "right";
        upp = "up";
        ner = "down";
    }

    // Update is called once per frame
    void Update()
    {
        vanster = "left";
        hoger = "right";
        upp = "up";
        ner = "down";
    }
}