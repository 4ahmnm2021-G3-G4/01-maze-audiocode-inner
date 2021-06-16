using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WoodWell : MonoBehaviour
{
    public CollectCoin collectCoinO;
    public Text keyText;
    public Text wish;
    public AudioSource sprinkle;

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Well collided");
        if (collectCoinO.count == 3)
        {
            sprinkle.Play();
            collectCoinO.count++;
            keyText.enabled = true;
            wish.enabled = true;
            StartCoroutine("CountDown");

        }
    }
    IEnumerator CountDown()
    {
        Debug.Log("BB");
        yield return new WaitForSeconds(5);
        Debug.Log("BB2");
        wish.gameObject.SetActive(false);
        sprinkle.Stop();
    }
}
