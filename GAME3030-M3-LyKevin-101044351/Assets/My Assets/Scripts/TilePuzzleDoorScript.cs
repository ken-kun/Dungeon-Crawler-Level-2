using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilePuzzleDoorScript : MonoBehaviour
{
    public TileScript tileHolder1;
    public TileScript tileHolder2;
    public TileScript tileHolder3;
    public TileScript tileHolder4;
    public TileScript tileHolder5;
    public TileScript tileHolder6;
    public TileScript tileHolder7;
    public TileScript tileHolder8;
    public TileScript tileHolder9;
    public TileScript tileHolder10;
    public TileScript tileHolder11;
    public TileScript tileHolder12;
    public TileScript tileHolder13;
    public TileScript tileHolder14;
    public TileScript tileHolder15;
    public TileScript tileHolder16;
    public TileScript tileHolder17;
    public TileScript tileHolder18;
    public TileScript tileHolder19;
    public TileScript tileHolder20;
    public TileScript tileHolder21;
    public TileScript tileHolder22;
    public TileScript tileHolder23;
    public TileScript tileHolder24;
    public TileScript tileHolder25;


    bool isOpen = false;

    public Animation playGate;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (tileHolder1.colorState && tileHolder2.colorState && tileHolder3.colorState && tileHolder4.colorState && tileHolder5.colorState
            && tileHolder6.colorState && tileHolder7.colorState && tileHolder8.colorState && tileHolder9.colorState && tileHolder10.colorState
            && tileHolder11.colorState && tileHolder12.colorState && tileHolder13.colorState && tileHolder14.colorState && tileHolder15.colorState
            && tileHolder16.colorState && tileHolder17.colorState && tileHolder18.colorState && tileHolder19.colorState && tileHolder20.colorState
            && tileHolder21.colorState && tileHolder22.colorState && tileHolder23.colorState && tileHolder24.colorState && tileHolder25.colorState

            )
        {
            if (!isOpen)
            {
                Invoke("OpenGate", 2);
            }
        }
    }


    public void OpenGate()
    {
        isOpen = true;
        playGate.Play();

    }
}

