using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public string hoger = "";
    public string vanster = "";
    public string upp = "";
    public string ner = "";
    // Start is called before the first frame update
    void Start()
    {
       hoger = "d";
       vanster = "a";
       upp = "w";
       ner = "s";
    }

    // Update is called once per frame
    void Update()
    {
        // Movement med piltangenterna. Detta "teleporterar" spelaren ett litet hack i varje riktning.
        if (Input.GetKey(vanster))
        {
            transform.position = new Vector3(transform.position.x - 0.1f, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(hoger))
        {
            transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(upp))
        {
            
        }
        if (Input.GetKey(ner))
        {
           
        }

    }
}
