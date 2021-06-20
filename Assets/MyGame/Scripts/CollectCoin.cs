using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectCoin : MonoBehaviour
{
    public int count = 0;
    public Text scoreText;
    public Text allPickedUp;

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Coin"))
        {
            Destroy(collider.gameObject);
            count += 1;
            scoreText.text = count.ToString() + "/3 Coins";
        }

        if (count == 3)
        {
            allPickedUp.gameObject.SetActive(true);
        }
    }
}
