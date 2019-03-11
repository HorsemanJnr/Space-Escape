using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Forcefield : MonoBehaviour
{
    public string Color;
    public Sprite Spark;
    abstract public void Deactivate();
    abstract public string GetColor();

    public Sprite[] frames;
    public float framesPerSecond = 5;
    protected SpriteRenderer spriteRenderer;
    protected int currentFrameIndex = 0;
    protected float frameTimer;

}
