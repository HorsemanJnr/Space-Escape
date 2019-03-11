using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHandler : MonoBehaviour
{
    GameObject keycard = null;

    public AudioClip doorUnlocked;
    public AudioClip doorDenied;

    public AudioClip gotKeycard;
    public AudioClip gotItem;


    private void OnTriggerEnter2D(Collider2D other)
    {
        //FORCEFIELDS
        if (other.CompareTag("Deactivator"))
        {
            AudioSource.PlayClipAtPoint(gotItem, transform.position);
            Deactivator deact = other.GetComponent<Deactivator>();
            Forcefield field = deact.GetForcefield();
            field.Deactivate();
            deact.Remove();
        }

        //FINAL DOOR
        //Pick up final keycard
        if (other.CompareTag("Keycard"))
        {
            if(keycard == null)
            {
                keycard = other.gameObject;
                AudioSource.PlayClipAtPoint(gotKeycard, transform.position);

                keycard.transform.SetParent(transform);
                keycard.transform.position = transform.position + Vector3.right * 0.5f + Vector3.up * 1.5f;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        //Unlock final door
        if (other.CompareTag("Door"))
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                if (keycard != null)
                {
                    AudioSource.PlayClipAtPoint(doorUnlocked, transform.position);

                    Door finalDoor = other.GetComponent<Door>();
                    Destroy(keycard);
                    finalDoor.Unlock();
                }
                else
                {
                    AudioSource.PlayClipAtPoint(doorDenied, transform.position);
                }
            }
        }
    }
}
