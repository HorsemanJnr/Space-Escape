using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenDeactivator : Deactivator
{
    public GreenDeactivator()
    {
        Color = "Green";
    }

    public override string GetColor()
    {
        return Color;
    }

    public override Forcefield GetForcefield()
    {
        return forcefield;
    }

    public override void Remove()
    {
        Instantiate(LeverFlipAnim, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
