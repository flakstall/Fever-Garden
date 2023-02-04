using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class MushroomScript : MonoBehaviour
{
    public float scanRadius = 3f;
    public LayerMask filterMask;
    private SpawnerJamur sj;
    Collider2D checkCollider;
    
    [SerializeField] GameObject jamur;

    public int jamurType;
    /*
    0: Jamur Enoki
    1: Jamur Payung
    2: Jamur Kuping
    */

    public int keGunting = 0;
    public int kePalu = 0;

    public Interaction im;

    
    void Awake()
    {
        sj = FindObjectOfType<SpawnerJamur>();
    }
    void Update()
    {
        checkCollider = Physics2D.OverlapCircle(transform.position, scanRadius, filterMask);
        if (checkCollider != null && checkCollider.transform != transform)
        {
            Destroy(checkCollider.gameObject);
            sj.timeToSpawn = 0;
        }

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
    protected void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, scanRadius);

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
