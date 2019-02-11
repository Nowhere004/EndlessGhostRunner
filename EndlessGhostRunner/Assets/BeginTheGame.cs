using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginTheGame : MonoBehaviour {

    public void BeginGame()
    {
        SceneManager.LoadScene("GhostRunner");
    }
}
