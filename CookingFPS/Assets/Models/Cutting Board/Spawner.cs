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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
