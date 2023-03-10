using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerJamur : MonoBehaviour
{
    [SerializeField] GameObject[] jamur;
    [SerializeField] float timeToSpawn;

    Vector2 pos;
    float minX, maxX, minY, maxY;
    float spawn;

    void Start()
    {
        Vector2 bounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        minX = -bounds.x;
        maxX = bounds.x;
        minY = -bounds.y;
        maxY = bounds.y;
    }

    void Update()
    {

        pos = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));

        int objIndex = Random.Range(0, jamur.Length);

        spawn -= Time.deltaTime;

        if(spawn <= 0)
        {
            GameObject obj = Instantiate(jamur[objIndex], pos, Quaternion.identity);
            obj.transform.parent = transform;
            spawn = timeToSpawn;
        }
    }
}
