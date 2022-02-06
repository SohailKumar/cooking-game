using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy:MonoBehaviour{ 
	[SerializeField] private int hp;
	[SerializeField] private float step;
	public GameObject target;
    public GameManager gm;
    //private String battle_cry; 
    //private String is_hit_sound; 
    //private String dying_sound; 

    public void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Protect");
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    public void TakeDamage(int dmg)
    {
		Debug.Log("HP: " + hp + ", DMG: " + dmg);
		hp -= dmg;
		if(hp <= 0)
        {
			Destroy(this.gameObject);
        }
    }

    private void Update()
    {
		transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step * Time.deltaTime);
        transform.LookAt(target.transform.position);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Protect"))
        {
            gm.GameOver();
        }
    }
}

