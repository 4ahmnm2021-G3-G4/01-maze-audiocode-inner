using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoors : MonoBehaviour
{

    public int collected;
    public int CoinAmount = 1;
    public GameObject door;


    // Start is called before the first frame update
    void CoinCollected()
    {
     if(collected == CoinAmount)
     collected = collected + 1;
        door.transform.rotation = Quaternion.Euler(new Vector3(0f, -90f, 0f));

    }

}
