using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinBallScript : MonoBehaviour
{
    [SerializeField] GameObject puzzleBoard;
    private bool puzzleState = false;
    [SerializeField] GameObject player;
    [SerializeField] GameObject puzzleCamera;
    private bool switchState = false;
    [SerializeField] GameObject text;
    [SerializeField] GameObject text2;

    

    



    // Update is called once per frame
    void Update()
    {
        
        SetSwitch();
        if (switchState )
        {
           
            BoardMovement();
            

            


        }

        

        //if (puzzleBoard.transform.eulerAngles.x > 0)
        //{
        //    puzzleBoard.transform.Rotate(-0.5f, 0, 0);

        //    if(puzzleBoard.transform.eulerAngles.x == 0)
        //    {
        //        puzzleBoard.transform.Rotate(0, 0, 0);
        //    }
        //}

        //if (puzzleBoard.transform.eulerAngles.z > 0 || puzzleBoard.transform.eulerAngles.z < 0)
        //{
            //puzzleBoard.transform.Rotate(0, 0, -0.5f);
        //}
    }


   
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            puzzleState = true;
            //player.SetActive(false);
            //puzzleCamera.SetActive(true);
            text.SetActive(true);
            text2.SetActive(true);

            Debug.Log("ON" + puzzleState);
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            puzzleState = false;
            text.SetActive(false);
            text2.SetActive(false);
            Debug.Log("OFF" + puzzleState);
        }
    }

    
    void SetSwitch()
    {
        if (Input.GetKey(KeyCode.F) && puzzleState)
        {
            switchState = true;
            player.SetActive(false);
            puzzleCamera.SetActive(true);
            Debug.Log("switch ON");


        }



        if (Input.GetKey(KeyCode.G) && switchState)
        {
            switchState = false;
            player.SetActive(true);
            puzzleCamera.SetActive(false);
            Debug.Log("switch ON");


        }
    }




    void BoardMovement()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
           

            puzzleBoard.transform.Rotate(-0.5f, 0, 0);

            



        }


        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {


            puzzleBoard.transform.Rotate(0.5f, 0, 0);

            

        }


        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            puzzleBoard.transform.Rotate(0, 0, 0.5f);
        }


        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            puzzleBoard.transform.Rotate(0, 0, -0.5f);
        }

        
    }
}
