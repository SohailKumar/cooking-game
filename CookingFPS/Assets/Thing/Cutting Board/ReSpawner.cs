using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawner : MonoBehaviour
{
    
    public GameObject spawnSource;
    void OnDestroy()
    {
        if(!(spawnSource == null)) spawnSource.GetComponent<Spawner>().Spawn();
    }
}
