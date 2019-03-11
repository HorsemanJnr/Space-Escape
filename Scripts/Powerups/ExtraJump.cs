using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraJump : MonoBehaviour
{
    public Sprite[] frames;
    public float framesPerSecond = 5;
    protected SpriteRenderer spriteRenderer;
    protected int currentFrameIndex = 0;
    protected float frameTimer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        frameTimer = (1f / framesPerSecond);
        currentFrameIndex = 0;
    }


    void Update()
    {
        frameTimer -= Time.deltaTime;

        if (frameTimer <= 0)
        {
            currentFrameIndex++;
            if (currentFrameIndex >= frames.Length)
            {
                currentFrameIndex = 0;
            }
            frameTimer = (1f / framesPerSecond);
            spriteRenderer.sprite = frames[currentFrameIndex];
        }
    }
}