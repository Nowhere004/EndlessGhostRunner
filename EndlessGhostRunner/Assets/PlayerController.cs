using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    private Vector2 targetpos;
    public float Yincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public int health = 3;
    public GameObject playerEffect;
    private Shake shake;
    public Text healthDisplay;
    public GameObject gameOver;
    public GameObject popSound;


    private void Start()
    {
        Time.timeScale = 1;
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
    }
    // Update is called once per frame
    void Update () {
        
        healthDisplay.text = "HP: " + health.ToString();
        if (health<=0)
        {
            
            Time.timeScale = 0;         
            gameOver.SetActive(true);           
            Destroy(gameObject);

        }
        transform.position = Vector2.MoveTowards(transform.position,targetpos,speed*Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.UpArrow)&& transform.position.y<maxHeight)
        {
            GameObject popEffect = Instantiate(popSound,transform.position,Quaternion.identity);
            Destroy(popEffect,1f);
            shake.CamShake();
            GameObject moveEffect = Instantiate(playerEffect,transform.position,Quaternion.identity);
            targetpos = new Vector2(transform.position.x,transform.position.y+Yincrement);
            Destroy(moveEffect, 2f);
          
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)&&transform.position.y>minHeight)
        {
            GameObject popEffect = Instantiate(popSound, transform.position, Quaternion.identity);
            Destroy(popEffect, 1f);
            shake.CamShake();
            GameObject moveEffect = Instantiate(playerEffect, transform.position, Quaternion.identity);
            targetpos = new Vector2(transform.position.x,transform.position.y-Yincrement);
            Destroy(moveEffect, 2f);
        }
	}
}
