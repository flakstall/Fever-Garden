using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
     //private Camera camera;
     public string toolPake;
     /*
     Penyiram
     Palu
     Gunting
     Glove
     */

    void Start() {
       // camera = Camera.main;
    }

    // Update is called once per frame
    void Update() {
        //DetectObject();
    }

    /*
    public void DetectObject() {
        if (Input.GetMouseButtonDown(0)) {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) {
                Debug.Log("click");
                
                //Debug.Log($"{hit.collider.name} Detected", hit.collider.gameObject);

                Debug.Log(hit.collider.gameObject.name);
            }
        }
    }
    */
}
