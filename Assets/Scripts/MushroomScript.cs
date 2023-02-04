using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class MushroomScript : MonoBehaviour
{
    public float scanRadius;
    public LayerMask filterMask;
    private SpawnerJamur sj;
    Collider2D checkCollider;

    public int mushroomType;
    
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
            sj.spawn = 0;
        }
    }
}
