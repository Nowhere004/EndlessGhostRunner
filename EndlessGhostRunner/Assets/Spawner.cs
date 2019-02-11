using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] obstaclePatterns;
    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.55f;

    private void Update()
    {
        if (timeBtwSpawn<=0)
        {
            int rand = Random.Range(0,obstaclePatterns.Length);
           GameObject patternPoint= Instantiate(obstaclePatterns[rand],transform.position,Quaternion.identity);
            Destroy(patternPoint, 3f);
            timeBtwSpawn = startTimeBtwSpawn;
            if (startTimeBtwSpawn>minTime)
            {
                startTimeBtwSpawn -= decreaseTime;
            }
            
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
