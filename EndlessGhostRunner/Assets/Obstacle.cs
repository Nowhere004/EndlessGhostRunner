using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    private int damage = 1;
    public float speed;
    public GameObject obstacleEffect;
    private Shake shake;
    public GameObject expSound;

    private void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject expEffect = Instantiate(expSound,transform.position,Quaternion.identity);
            Destroy(expEffect,1f);
            shake.CamShake();
            other.GetComponent<PlayerController>().health -= damage;          
            GameObject destroyEffect = Instantiate(obstacleEffect,transform.position,Quaternion.identity);
            Destroy(destroyEffect,0.5f);
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        transform.Translate(Vector2.left*speed*Time.deltaTime);
    }
}
