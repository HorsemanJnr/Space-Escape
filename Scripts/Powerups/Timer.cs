using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public Sprite[] frames;
    //public float framesPerSecond = 5;

    SpriteRenderer spriteRenderer;
    int currentFrameIndex;
    float timer;


    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        currentFrameIndex = 0;
        timer = 0;
        spriteRenderer.sprite = frames[currentFrameIndex];
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            spriteRenderer.sprite = frames[currentFrameIndex];

            currentFrameIndex++;

            timer = 1;

            if (currentFrameIndex >= frames.Length)
            {
                Destroy(gameObject);
                return;
            }
        }
    }
}
