using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneManagement : MonoBehaviour

{


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("WinningScene");

        }
    }

    public void ButtonPressed()
    {
        SceneManager.LoadScene("MazeScene");
    }

   
}

