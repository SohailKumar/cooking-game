using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawner : MonoBehaviour
{
    public GameObject spawnSource;
    void OnDestroy()
    {
        spawnSource.GetComponent<Spawner>().Spawn();
    }
}
