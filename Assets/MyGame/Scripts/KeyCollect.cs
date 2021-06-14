using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollect : MonoBehaviour
{
    int coinCounter;
    bool keyCollected;
    [SerializeField]
    GameObject Ausgang;
    public void ItemCollected(bool isKey)
    {
        if (isKey)
        {
            keyCollected = true;
        }
        else
        {
            coinCounter++;
        }
        //pickUpAudioS.Play();
        if (keyCollected && coinCounter == 3)
        {
            //Ausgang.GetComponent<OpenDoors>().openDoor = true;
        }
    }
}
