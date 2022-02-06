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

    public void Spawn()
    {
        GameObject Spawned = Instantiate(spawnable, (transform.position + new Vector3(0,0.17f,0)), new Quaternion(0, 0, 0, 0));
        Spawned.GetComponent<ReSpawner>().spawnSource = gameObject;
    }
}
