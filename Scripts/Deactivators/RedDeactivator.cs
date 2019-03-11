using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedDeactivator : Deactivator
{
    public RedDeactivator()
    {
        Color = "Red";

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
