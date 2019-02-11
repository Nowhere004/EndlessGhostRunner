using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour {
    public Animator anim;
	// Use this for initialization
    public void CamShake()
    {
        anim.SetTrigger("shake");
    }
}
