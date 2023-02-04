using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class MushroomScript : MonoBehaviour
{
    [SerializeField] GameObject jamur;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Mushroom")
        {
            Destroy(collision.gameObject);
            GameObject obj = Instantiate(jamur, this.transform.position, Quaternion.identity) as GameObject;
        }
    }
}
