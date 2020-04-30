using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    public bool colorState;
    public Material blueState;

    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && colorState == false)
        {
            this.GetComponent<Renderer>().material.color = Color.blue;
            colorState = true;
        }
        else if (other.gameObject.tag == "Player" && colorState == true)
        {
            this.GetComponent<Renderer>().material.color = Color.yellow;
            colorState = false;
        }
    }
}
