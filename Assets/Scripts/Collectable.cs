using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    private GameObject[] objectToColorChange;

    //check for object in the radius
    [SerializeField] LayerMask tessellLayer;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            objectToColorChange = GameObject.FindGameObjectsWithTag("Tessell_FG");

            foreach (GameObject obj in objectToColorChange)
            {
                ColorChange CC = obj.GetComponent<ColorChange>();
                CC.ChangeColor();
                //StartCoroutine(CC.ChangeColor());
            }

            gameObject.SetActive(false);
        }
    }

}
