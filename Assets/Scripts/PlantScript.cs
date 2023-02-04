using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantScript : MonoBehaviour
{
    [SerializeField] float timeToGrow;
    float growingTime;
    void Start()
    {
        
    }

    void Update()
    {
        if(growingTime < timeToGrow)
        {
            growingTime += Time.deltaTime;
        }

        //Debug.Log(growingTime);
    }
}
