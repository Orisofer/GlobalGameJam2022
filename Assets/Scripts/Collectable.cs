using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    private GameObject[] objectToColorChange;
    [SerializeField] private float radius;

    public ContactFilter2D CF2;

    List<Collider2D> results = new List<Collider2D>();

    //check for object in the radius

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            int collectableCollider = Physics2D.OverlapCircle(transform.position, radius, CF2, results);
            print("collectableCollider: " + collectableCollider);
            print("results: " + results);

            for (int i=0; i<collectableCollider; i++)
            {
                print(results[i].gameObject);
                if (results[i].gameObject.tag == "Player")
                {
                    continue;
                }
                ColorChange CC = results[i].gameObject.GetComponent<ColorChange>();
                CC.SetDifferentColor();
            }

            gameObject.SetActive(false);
            
        }
    }

}
