﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectCoin : MonoBehaviour
{


    public int count;
    public Text scoreText;
    public Text allPickedUp;

    private void Start()
    { 
        count = 0;
    }


    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Coin"))
        {
            Debug.Log("mit Coin collided");
            //Destroy(gameobjekt mit tag Coin)
            Destroy(collider.gameObject);
            count += 1;
            scoreText.text = count.ToString() + "/3 Coins";
        }

        if (count ==3)
        {
        allPickedUp.enabled = true;
        }
       

    }
    
}

