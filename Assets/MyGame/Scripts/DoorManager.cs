using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    [SerializeField]
    CollectCoin collectCoinO;
    int doorsCounter = 1;
    [SerializeField]
    GameObject[] doorsGOA = new GameObject[4];

    public void TriggerEntered()
    {
        Debug.Log(collectCoinO.count + " " + doorsCounter);
        if (collectCoinO.count == doorsCounter)
        {
            doorsGOA[doorsCounter - 1].SetActive(false);
            doorsCounter++;
        }
    }
}