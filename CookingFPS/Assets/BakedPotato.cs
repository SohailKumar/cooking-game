using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BakedPotato : Food
{
    public override void Cook(GameObject app)
    {
        Debug.Log("cooik");
    }

    public override void Remove()
    {
        Debug.Log("Rmove");
    }

}
