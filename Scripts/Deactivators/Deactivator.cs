using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Deactivator : MonoBehaviour
{
    abstract public string GetColor();
    abstract public Forcefield GetForcefield();
    abstract public void Remove();
    public Forcefield forcefield;
    public string Color;
    //public bool Active;
    public GameObject LeverFlipAnim;
}