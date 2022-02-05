public abstract class Meal{
	private List<String> recipe; 
	private List<String> steps_completed; 
	private String launch_sound; 
	private String hit_enemy_sound; 
	private String miss_enemy_sound;
	private int damage_points;
	private Bool bread; 
	private Bool potato;
	private float cook_time;  
} 

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

public abstract class Enemy{ 
	private int hp; 
	private String weakness; 
	private Point3D location;
	private String battle_cry; 
	private String is_hit_sound; 
	private String dying_sound; 

	public abstract void advance(){
		this.x
			 
		
	} 
}
	
} 
