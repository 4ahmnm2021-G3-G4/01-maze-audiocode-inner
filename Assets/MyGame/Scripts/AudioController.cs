using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{

    public AudioSource A_Coin;
    public Button aButton;

    // Start is called before the first frame update

    void Start()
    {
        A_Coin = GetComponent<AudioSource>();
    }

    public void ButtonPressed()
    {
    A_Coin.Play();
   // A_Coin.Stop(5);



    }
   
}
