using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApparatusButtonScript : MonoBehaviour
{
    public bool state;
    enum colourState {blueState, greenState, yellowState, redState };
    [SerializeField] colourState colorState;

    private void Start()
    {
        this.GetComponent<Renderer>().material.color = Color.gray;
    }




    private void OnTriggerEnter(Collider other)
    {
        switch (colorState) {

            case colourState.blueState:
                if (other.gameObject.tag == "Player" && state == false)
                {
                    this.GetComponent<Renderer>().material.color = Color.blue;
                    state = true;
                }
                else if (other.gameObject.tag == "Player" && state == true)
                {
                    this.GetComponent<Renderer>().material.color = Color.gray;
                    state = false;
                }
                break;

            case colourState.redState:
                if (other.gameObject.tag == "Player" && state == false)
                {
                    this.GetComponent<Renderer>().material.color = Color.red;
                    state = true;
                }
                else if (other.gameObject.tag == "Player" && state == true)
                {
                    this.GetComponent<Renderer>().material.color = Color.gray;
                    state = false;
                }
                break;

            case colourState.greenState:
                if (other.gameObject.tag == "Player" && state == false)
                {
                    this.GetComponent<Renderer>().material.color = Color.green;
                    state = true;
                }
                else if (other.gameObject.tag == "Player" && state == true)
                {
                    this.GetComponent<Renderer>().material.color = Color.gray;
                    state = false;
                }
                break;

            case colourState.yellowState:
                if (other.gameObject.tag == "Player" && state == false)
                {
                    this.GetComponent<Renderer>().material.color = Color.yellow;
                    state = true;
                }
                else if (other.gameObject.tag == "Player" && state == true)
                {
                    this.GetComponent<Renderer>().material.color = Color.gray;
                    state = false;
                }
                break;
        }


       
    }
}
