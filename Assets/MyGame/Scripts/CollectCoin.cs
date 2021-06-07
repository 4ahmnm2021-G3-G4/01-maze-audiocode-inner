using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{

    public GameObject Coin;
    public GameObject CoinSound;
    public int count;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
    }


    public void OnTriggerEnter(Collision collider)
    {
        if (collider.gameObject.CompareTag("Coin"))
        {
            Debug.Log(collider.collider.name);
            Destroy(Coin);
            Destroy(CoinSound);
            count =+ 1;
        }

    }
}

