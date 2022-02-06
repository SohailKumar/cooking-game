using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public int maxEnemies;
    public GameObject enemy;
    private int curEnemies = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(curEnemies < maxEnemies)
        {
            Spawn();
        }
    }

    private void Spawn()
    {
        
        GameObject enemyIns = Instantiate(enemy, transform.position + new Vector3(0,0, Random.Range(-14.5f,14.5f)), transform.rotation) as GameObject;
        enemy.GetComponent<Enemy>().spawnSource = this.gameObject;
        curEnemies++;
    }

    public void EnemyDestroyed()
    {
        curEnemies--;
    }
}
