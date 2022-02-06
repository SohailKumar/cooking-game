using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applianceState : MonoBehaviour
{
    private GameManager gm;
    private GameObject foodCooking = null;

    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        gm.UpdateStove("None");
    }

    public void StartCooking(GameObject food){
        this.foodCooking = food;
        gm.UpdateStove(food.name);
        //food.GetComponent<Food>().Cook(); 
    }
    public GameObject PickupFood(){
        if (this.foodCooking != null) {
            foodCooking.GetComponent<MeshRenderer>().enabled = false;
            foodCooking.GetComponent<BoxCollider>().enabled = false;

            GameObject temp = this.foodCooking;
            this.foodCooking = null;
            gm.UpdateStove("None");
            return temp;
        }else{
            Debug.Log("Appliance is empty");
            return null;
        }
    }

    public void SwitchFood(GameObject newFood)
    {
        foodCooking = newFood;
        gm.UpdateStove(newFood.name);
    }
}