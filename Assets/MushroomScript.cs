using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class MushroomScript : MonoBehaviour
{
    [SerializeField] GameObject jamur;

    public int jamurType;
    /*
    0: Jamur Enoki
    1: Jamur Payung
    2: Jamur Kuping
    */

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Mushroom")
        {
            Destroy(collision.gameObject);
            GameObject obj = Instantiate(jamur, this.transform.position, Quaternion.identity) as GameObject;
        }
    }
}
