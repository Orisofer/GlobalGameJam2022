using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    [SerializeField] private Color colorToChange;
    [SerializeField] private GameObject objectToColorChange;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            objectToColorChange.GetComponent<SpriteRenderer>().color = colorToChange;
            gameObject.SetActive(false);
        }
    }

}
