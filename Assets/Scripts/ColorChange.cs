using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private Color colorToChange;

    public void SetDifferentColor()
    {
        print("entering color change");
        colorToChange = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1);
        GetComponent<SpriteRenderer>().color = colorToChange;
    }
}