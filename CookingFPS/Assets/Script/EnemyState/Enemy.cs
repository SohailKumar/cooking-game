using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy:MonoBehaviour{ 
	[SerializeField] private int hp;
	[SerializeField] private float step;
	public GameObject target;
    public GameManager gm;
    public GameObject spawnSource;
    //private String battle_cry; 
    //private String is_hit_sound; 
    //private String dying_sound; 

    [SerializeField] private float timeBtwDmg;
    private float currTimeBtwDMg;

    public void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Protect");
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        currTimeBtwDMg = 0;
    }

    public void TakeDamage(int dmg)
    {
        if (currTimeBtwDMg <= 0)
        {
            Debug.Log("HP: " + hp + ", DMG: " + dmg);
            hp -= dmg;
            if (hp <= 0)
            {
                Destroy(this.gameObject);
            }
            currTimeBtwDMg = timeBtwDmg;
        }
    }

    private void Update()
    {
		transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step * Time.deltaTime);
        transform.LookAt(target.transform.position);
        if(currTimeBtwDMg > 0)
        {
            currTimeBtwDMg -= Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Protect"))
        {
            gm.GameOver();
        }
    }
    public void OnDestroy()
    {
        if (spawnSource != null)
        {
            spawnSource.GetComponent<EnemySpawner>().EnemyDestroyed();
        }
    }
}

