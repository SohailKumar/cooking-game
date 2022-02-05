using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject spawnable;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Spawner: " + spawnable.name);
        Spawn();
    }

    void Spawn()
    {
        GameObject Spawned = Instantiate(spawnable, transform.position, transform.rotation);
        Spawned.GetComponent(ReSpawner).spawner = gameObject;
    }
}
