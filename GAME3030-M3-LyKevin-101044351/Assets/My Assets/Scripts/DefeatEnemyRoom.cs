using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefeatEnemyRoom : MonoBehaviour
{
    [SerializeField] EnemyHealth enemy1;
    [SerializeField] EnemyHealth enemy2;
    [SerializeField] EnemyHealth enemy3;
    [SerializeField] LockedDoor openDoor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AllEnemiesDead();
    }

    void AllEnemiesDead()
    {
        if(enemy1.isAlive == false && enemy2.isAlive == false && enemy3.isAlive == false)
        {
            openDoor.OpenDoor();
        }
    }
}
