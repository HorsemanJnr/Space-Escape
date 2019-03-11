using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueDeactivator : Deactivator
{
    public BlueDeactivator()
    {
        Color = "Blue";
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
