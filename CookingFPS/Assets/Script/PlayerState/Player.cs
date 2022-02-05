public class Player{ 
	private int hp; 
	private int level; 
	private int exp; 
	private int exp_needed_to_level_up; 
	private String is_hit_sound; 
	private String dying_sound;
	private Bool is_dead;  

	public Player(){ 
		this.hp = 100; 
		this.level = 0; 
		this.exp = 0; 
		this.exp_needed_to_level_up = 10; 
		this.is_hit_sound = "aaahhh" 
		this.dying_sound = "aaahhh"; 
		this.is_dead = false; 
	}

	public void take_damage(int damage){
		if(damage >= this.hp){ 
			this.hp = 0; 
			this.is_dead = True; 
		}  
		else{ 
			this.hp -= damage; 
		} 
	}
	
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

	public void shoot(Meal meal){ 
	}  


}  
