using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private Color colorToChange;

    public void ChangeColor()
    {
        colorToChange = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1);
        GetComponent<SpriteRenderer>().color = colorToChange;
    }

    //public IEnumerator ChangeColor()
    //{
    //    print("Entering CoRouting");
    //    float timeStarted = Time.time;
    //    float timeSinceStarted = Time.time - timeStarted;
    //    print("timeSinceStarted:   " + timeSinceStarted);
    //    float presantageComplete = timeSinceStarted / .5f;
    //    Color currentColor = gameObject.GetComponent<SpriteRenderer>().color;
    //    print("currentcolor:     " + currentColor);

    //    while (true)
    //    {
    //        timeSinceStarted = Time.time - timeStarted;
    //        presantageComplete = timeSinceStarted / .5f;
    //        print("currentColor: " + currentColor + ", colorToChange: " + colorToChange + ", presantageComplete: " + presantageComplete);
    //        Color newColor = Color.Lerp(currentColor, colorToChange, presantageComplete);
    //        print("newColor: " + newColor);
    //        currentColor = newColor;
    //        GetComponent<SpriteRenderer>().color = currentColor;

    //        if (presantageComplete >= 1f)
    //        {
    //            break;
    //        }

    //        yield return new WaitForEndOfFrame();
    //    }
    //}
}