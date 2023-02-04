using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomScript : MonoBehaviour
{
    CircleCollider2D coll;

    void Start()
    {
        coll= GetComponent<CircleCollider2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(coll.gameObject.tag == "Mushroom")
        {
            Debug.Log("overlapping");
            Destroy(coll.gameObject);
        }
    }
}
