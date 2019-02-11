using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {

    public GameObject obstacle;
    private void Start()
    {
       GameObject obstaclePoint= Instantiate(obstacle,transform.position,Quaternion.identity);
        Destroy(obstaclePoint,3f);
    }
}
