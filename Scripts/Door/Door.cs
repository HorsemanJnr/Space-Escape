using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public GameObject DoorOpen;

    public void Unlock()
    {
        Instantiate(DoorOpen, transform.position, Quaternion.identity);
        Destroy(gameObject);

        //END LEVEL
        StartCoroutine(NextLevel());

    }

    IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(2);
               
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
