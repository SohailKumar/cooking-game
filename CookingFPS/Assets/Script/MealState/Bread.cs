using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bread : Food
{
    public override void Cook(GameObject app)
    {
        Debug.Log("Cooked");
    }

    public override void Remove()
    {
        Debug.Log("Removed");
    }
}
