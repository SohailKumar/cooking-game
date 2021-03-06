using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{

	//private String is_hit_sound; 
	//private String dying_sound;
	[SerializeField] private GameObject inHand;
	[SerializeField] private float shootSpeed;
	private GameManager gm;

    /*
	public Player(){ 
		this.hp = 100; 
		this.level = 0; 
		this.exp = 0; 
		this.exp_needed_to_level_up = 10; 
		this.is_hit_sound = "aaahhh" 
		this.dying_sound = "aaahhh"; 
		this.is_dead = false; 
	}*/
    /*
	public void take_damage(int damage){
		if(damage >= this.hp){ 
			this.hp = 0; 
			this.is_dead = true; 
		}  
		else{ 
			this.hp -= damage; 
		} 
	}
*/
    /*
	public void gain_exp(int exp_gained){ 
		if(this.exp + exp_gained >= this.exp_needed_to_level_up){ 
			this.level ++;
			this.exp += exp_gained - exp_needed_to_level_up  
			this.exp_needed_to_level_up += 5; 
		} 
		else{ 
			this.exp += this.exp_gained; 
		}
	}
	*/

    private void Start()
    {
		gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
		inHand = null;
		gm.UpdateHand ("None");

	}

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
			Shoot();
        }
    }

    private void Shoot()
    {
		if (inHand != null)
		{
			inHand.GetComponent<Food>().Shot(this.transform, shootSpeed);
			inHand = null;
			gm.UpdateHand("None");
		}
    }

    private void OnTriggerStay(Collider other)
    {
        if (inHand == null && Input.GetMouseButton(1))
        {
			if (other.CompareTag("PickUp"))
			{
                try
				{
					inHand = other.gameObject;
					other.GetComponent<Food>().PickUp();
					gm.UpdateHand(inHand.gameObject.name);
				}catch
                {
					inHand = null;
					gm.UpdateHand("None");
				}
			}else if (other.CompareTag("Appliance"))
            {
				inHand = other.GetComponent<applianceState>().PickupFood();
				gm.UpdateHand(inHand.name);
			}
        }
    }
}
