using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{

    public GameObject Coin;
    public GameObject Player;
    public Collider CoinCollider;




    public void OnCollisionEnter()
    {
        CoinCollider = Coin.GetComponent<BoxCollider>();

       // if (CoinCollider.isTrigger == true)
            //Destroy(Coin);

                //ontrigger??

    }
}
