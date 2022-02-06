using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy:MonoBehaviour{ 
	[SerializeField] private int hp; 
	//private String battle_cry; 
	//private String is_hit_sound; 
	//private String dying_sound; 
	public void TakeDamage(int dmg)
    {
		Debug.Log("HP: " + hp + ", DMG: " + dmg);
		hp -= dmg;
		if(hp <= 0)
        {
			Destroy(this.gameObject);
        }
    }
}

