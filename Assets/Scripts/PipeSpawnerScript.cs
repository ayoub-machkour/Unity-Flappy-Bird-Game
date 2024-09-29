using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float hightOffset = 5;

    // Start is called before the first frame update
    void Start()
    {
        Spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Spawnpipe();
            timer = 0;
        }
    }
    void Spawnpipe()
    {
        float lowestPoint = transform.position.y - hightOffset;
        float hightPoint = transform.position.y + hightOffset;

        Instantiate(pipe,new Vector3(transform.position.x , Random.Range(lowestPoint,hightPoint),0), transform.rotation);
    }
}
