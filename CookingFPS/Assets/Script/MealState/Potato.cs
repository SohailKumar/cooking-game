using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potato : Food
{
    public GameObject bakedPotato;
    public float cookTime;
    [SerializeField] private float currTime = 0;
    private bool isCooking;
    private GameObject stove = null;

    private void Update()
    {
        if (isCooking)
        {
            if (currTime > 0)
            {
                currTime -= Time.deltaTime;
            }
            else
            {
                isCooking = false;
                currTime = 0;
                GameObject bp = Instantiate(bakedPotato, stove.transform.position, Quaternion.identity);
                bp.GetComponent<MeshRenderer>().enabled = false;
                bp.gameObject.GetComponent<Collider>().enabled = false;
                stove.GetComponent<applianceState>().SwitchFood(bp);
                //switch to baked potato.
            }
        }
    }

    // Start is called before the first frame update
    public override void Cook(GameObject app)
    {
        if(app.gameObject.name == "Stove")
        {
            stove = app;
            if (currTime == 0)
            {
                currTime = cookTime;
            }
            isCooking = true;
        }
    }

    public override void Remove()
    {
        if (isCooking)
        {
            isCooking = false;
            stove = null;
        }
    }
}
