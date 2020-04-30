using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApparatusPuzzleDoorScript : MonoBehaviour
{

    [SerializeField] float doorDistance = 161.0f;
    [SerializeField] ApparatusButtonScript blueSwitch;
    [SerializeField] ApparatusButtonScript redSwitch;
    [SerializeField] ApparatusButtonScript yellowSwitch;
    [SerializeField] ApparatusButtonScript greenSwitch;
    // Start is called before the first frame update

    public float timer;
    [SerializeField] GameObject cameraDoor;
    void Start()
    {
        // OpenDoor();
    }

    // Update is called once per frame
    void Update()
    {
        if(blueSwitch.state && redSwitch.state && yellowSwitch.state && greenSwitch.state)
        OpenDoor();

        if (timer == 5)
        {
            TurnCameraOn();
        }

        if (timer == 100)
        {
            TurnCameraOff();
        }
    }

    public void OpenDoor()
    {

        timer++;

        if (transform.position.y < doorDistance)
            transform.Translate(Vector3.up * Time.deltaTime);


    }


    public void TurnCameraOn()
    {
        cameraDoor.SetActive(true);


    }

    public void TurnCameraOff()
    {
        cameraDoor.SetActive(false);


    }
}
