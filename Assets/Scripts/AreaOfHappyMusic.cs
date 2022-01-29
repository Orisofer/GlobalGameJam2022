using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaOfHappyMusic : MonoBehaviour
{
    private void Start()
    {
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            AudioManager.instance.PlayMusic(1);
            AudioManager.instance.TurnDownVolume(0);

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            AudioManager.instance.StopMusic(1);
            AudioManager.instance.gameMusic[0].volume = AudioManager.instance.originalVolume;

        }
    }
}
