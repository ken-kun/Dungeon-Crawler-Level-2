using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    [SerializeField] float distance = 3.0f;
    // Start is called before the first frame update
    [SerializeField] GameObject cameraDoor;
    public float timer;

    
    void Start()
    {
       //OpenDoor();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(timer == 5)
        {
            TurnCameraOn();
        }

        if(timer == 100)
        {
            TurnCameraOff();
        }
        
    }

    public void OpenDoor()
    {
        timer++;
        

        
        if(transform.position.y < distance)
        transform.Translate(Vector3.up * Time.deltaTime);
        
        
    }

    

    public void TurnCameraOn() {
        cameraDoor.SetActive(true);
        

    }

    public void TurnCameraOff()
    {
        cameraDoor.SetActive(false);


    }


}
