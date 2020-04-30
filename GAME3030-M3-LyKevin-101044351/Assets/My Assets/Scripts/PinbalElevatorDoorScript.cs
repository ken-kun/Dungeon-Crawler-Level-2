using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinbalElevatorDoorScript : MonoBehaviour
{

    
    public LockedDoor openDoor;
    bool isOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        isOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isOpen)
        {
            OpenGate();
        }
    }


    public void OpenGate()
    {

        openDoor.OpenDoor();

    }


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag =="Ball")
        {
            isOpen = true;
        }
    }
}
