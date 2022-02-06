using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applianceState : MonoBehaviour
{
    //private System.Windows.Forms.Timer timer1;  
    private GameObject gameObject = null;

    // int case timer is needed in appliance
    /*private int counter = 60;
   private void btnStart_Click_1(object sender, EventArgs e)
   {
        timer1 = new System.Windows.Forms.Timer();
        timer1.Tick += new EventHandler(timer1_Tick);
        timer1.Interval = 1000; // 1 second
        timer1.Start();
        lblCountDown.Text = counter.ToString();
    }
    private void timer1_Tick(object sender, EventArgs e)
    {
        counter--;
        if (counter == 0)
            timer1.Stop();
        lblCountDown.Text = counter.ToString();
    }    */
    public void StartCooking(GameObject food){
        this.gameObject = food;
        food.GetComponent<Food>().Cook(); 
    }
    public GameObject PickupFood(){
        if (this.gameObject != null) {
            GameObject temp = this.gameObject;
            this.gameObject = null;
            return temp;
        }else{
            print("Appliance is empty");
            return null;
        }
    }
}