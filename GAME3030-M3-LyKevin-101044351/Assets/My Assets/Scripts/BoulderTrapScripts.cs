using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderTrapScripts : MonoBehaviour
{
    [SerializeField] Transform boulderSpawner;
    [SerializeField] GameObject boulder;
    //public bool isSpawning = false;
    //float time;
    // Start is called before the first frame update

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            
         InvokeRepeating("SpawnBoulder", 3, 5);
            
        }
    }

    void SpawnBoulder()
    {
        Instantiate(boulder, boulderSpawner.position, Quaternion.identity);
    }
}
