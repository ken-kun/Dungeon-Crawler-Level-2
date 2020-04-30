using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorScript : MonoBehaviour
{
    enum elevatorDirection { Downward, Upward }
    [SerializeField] elevatorDirection direction;
    private bool isMoving = false;
    [SerializeField] float distance = 3.0f;
    [SerializeField] float speed;
    
    // Start is called before the first frame update
    void Start()
    {
         MoveElevator ();
    }

    // Update is called once per frame
    void Update()
    {
        MoveElevator();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isMoving = true;
        }
    }


    public void MoveElevator()
    {
        switch (direction)
        {
            case elevatorDirection.Downward:
                if (isMoving)
                {
                    if (transform.position.y > distance)
                    {
                        transform.Translate(0, -0.1f * speed, 0);
                    }
                }
                break;

            case elevatorDirection.Upward:
                if (isMoving)
                {
                    if (transform.position.y < distance)
                        transform.Translate(0,0.1f * speed,0);
                }
                break;
        }

       


    }


}
