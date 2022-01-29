using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerChange : MonoBehaviour
{

     private void Awake()
    {
        Collider2D collider = GetComponent<Collider2D>();
        collider.isTrigger = true;
    }

    public void SetIsTriggerFalse()
    {
        print("entering SetIsTrigger");
        Collider2D collider = GetComponent<Collider2D>();
        collider.isTrigger = false;
    }
}
