using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applianceState : MonoBehaviour
{ 
    private GameObject foodCooking = null;

    public void StartCooking(GameObject food){
        this.foodCooking = food;
        //food.GetComponent<Food>().Cook(); 
    }
    public GameObject PickupFood(){
        if (this.foodCooking != null) {
            foodCooking.GetComponent<MeshRenderer>().enabled = false;
            foodCooking.GetComponent<BoxCollider>().enabled = false;

            GameObject temp = this.foodCooking;
            this.foodCooking = null;
            return temp;
        }else{
            print("Appliance is empty");
            return null;
        }
    }

    public void SwitchFood(GameObject newFood)
    {
        foodCooking = newFood;
    }
}