using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerJamur : MonoBehaviour
{
    [SerializeField] GameObject[] jamur;
    public float timeToSpawn;

    Vector2 pos;
    float minX, maxX, minY, maxY;
    public float spawn;

    void Awake()
    {
        Vector2 bounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        minX = -bounds.x + 0.75f;
        maxX = bounds.x - 0.75f;
        minY = -bounds.y / 2;
        maxY = bounds.y - 0.75f;

        Debug.Log(minY);
    }

    void Update()
    {
        pos = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        int objIndex = Random.Range(0, jamur.Length);

        spawn -= Time.deltaTime;
        if(spawn <= 0)
        {
            GameObject obj = Instantiate(jamur[objIndex], pos, Quaternion.identity) as GameObject;
            obj.transform.parent = transform;
            spawn = timeToSpawn;
        }
    }
}
