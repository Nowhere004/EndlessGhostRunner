using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBeginController : MonoBehaviour {


    private Vector2 targetpos;
    public float Yincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public GameObject playerEffect;
    private Shake shake;
    public GameObject popSound;


    private void Start()
    {        
        
    }
    // Update is called once per frame
    void Update()
    {        
        transform.position = Vector2.MoveTowards(transform.position, targetpos, speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight)
        {
            GameObject popEffect = Instantiate(popSound, transform.position, Quaternion.identity);
            Destroy(popEffect, 1f);           
            GameObject moveEffect = Instantiate(playerEffect, transform.position, Quaternion.identity);
            targetpos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            Destroy(moveEffect, 2f);

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight)
        {
            GameObject popEffect = Instantiate(popSound, transform.position, Quaternion.identity);
            Destroy(popEffect, 1f);            
            GameObject moveEffect = Instantiate(playerEffect, transform.position, Quaternion.identity);
            targetpos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            Destroy(moveEffect, 2f);
        }
    }
}
