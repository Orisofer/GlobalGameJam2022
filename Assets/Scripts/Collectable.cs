using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    private GameObject[] objectToColorChange;
    [SerializeField] private float radius;

    public ContactFilter2D CF2;

    List<Collider2D> results = new List<Collider2D>();

    //controlling the music in this area
    public GameObject areaMusicObject;

    //check for object in the radius

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            //AudioManager.instance.PlaySFX(2);
            areaMusicObject.SetActive(true);
            areaMusicObject.transform.SetParent(null);

            int collectableCollider = Physics2D.OverlapCircle(transform.position, radius, CF2, results);

            for (int i=0; i<collectableCollider; i++)
            {
                if (results[i].gameObject.tag == "Player")
                {
                    continue;
                }

                ColorChange CC = results[i].gameObject.GetComponent<ColorChange>();

                if (CC != null)
                {
                    CC.SetDifferentColor();
                }

                TriggerChange TC = results[i].gameObject.GetComponent<TriggerChange>();
                if( TC != null){
                    TC.SetIsTriggerFalse();
                }
            }

            gameObject.SetActive(false);
            
        }
    }

}
