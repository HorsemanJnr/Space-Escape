using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenForcefield : Forcefield
{

    void Start()
    {
        Color = "Green";
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


    public override void Deactivate()
    {
        StartCoroutine(TurnOff());
    }

    IEnumerator TurnOff()
    {
        spriteRenderer.sprite = Spark;


        yield return new WaitForSeconds(0.5f);
        gameObject.SetActive(false);
    }


    public override string GetColor()
    {
        return Color;
    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (col.collider.CompareTag("Player"))
        {
            Player player = col.transform.root.GetComponentInChildren<Player>();
            if (player.invincible)
            {
                Deactivate();
            }
            else
            {
                player.Hurt();
            }
        }
    }
}
