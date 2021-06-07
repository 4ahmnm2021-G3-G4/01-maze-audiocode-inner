using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{


    public int count;

    private void Start()
    { 
        count = 0;
    }


    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Coin")
        {
            Debug.Log("mit Coin collided");
            collider.gameObject.SetActive(false);
            //Destroy(gameobjekt mit tag Coin)
        }
        count = +1;

    }
    
}

