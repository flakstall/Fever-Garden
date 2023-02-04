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

    private int keGunting = 0;
    private int kePalu = 0;

    public Interaction im;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Mushroom")
        {
            Destroy(collision.gameObject);
            GameObject obj = Instantiate(jamur, this.transform.position, Quaternion.identity) as GameObject;
        }
    }

    void Update() {
        switch(jamurType) {
            case 0:
                cekGunting();
                break;
            case 1:
                cekPalu();
                break;
            case 2:
                break;
        }
    }

    private void cekGunting() {
        if (keGunting > 0){
            Destroy(gameObject);
        }
    }

    private void cekPalu() {
        if (kePalu > 2) {
            Destroy(gameObject);
        }
    }

    private void OnMouseDown() {
        if (im.toolPake == "Gunting") {
            keGunting++;
        } else if (im.toolPake == "Palu") {
            kePalu++;
        }
    }
}
