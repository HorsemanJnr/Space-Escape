using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeverFlip : MonoBehaviour
{
    public Sprite[] frames;
    public float framesPerSecond = 5;

    SpriteRenderer spriteRenderer;
    int currentFrameIndex = 0;
    float frameTimer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        frameTimer = (1f / framesPerSecond);
        currentFrameIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        frameTimer -= Time.deltaTime;

        if (frameTimer <= 0)
        {
            currentFrameIndex++;
            if (currentFrameIndex >= frames.Length)
            {
                //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                //Destroy(gameObject);
                return;
            }
            frameTimer = (1f / framesPerSecond);
            spriteRenderer.sprite = frames[currentFrameIndex];
        }
    }
}