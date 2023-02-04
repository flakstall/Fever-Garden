using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toolbox : MonoBehaviour
{
    
    public Interaction im;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown() {
        Debug.Log("cl");

        im.toolPake = gameObject.name;
        Debug.Log(im.toolPake);
        
    }
}
