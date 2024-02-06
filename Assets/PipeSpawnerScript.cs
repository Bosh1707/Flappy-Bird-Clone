using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject Pipe;
    public float SpawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < SpawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
        
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;   
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(Pipe, new Vector3(transform.position.x, UnityEngine.Random.Range(lowestPoint, highestPoint), 0), transform.rotation);

    }
}
