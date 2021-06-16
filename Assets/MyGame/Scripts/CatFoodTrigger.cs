using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatFoodTrigger : MonoBehaviour
{
    public GameObject catCol;
    public GameObject Coin2;
    
    private void OnTriggerEnter(Collider other)
    {
        if (catCol.CompareTag("CatTrigger"))
        {
            Coin2.transform.position= new Vector3(7, 1, 11);
            transform.position = new Vector3(7, 5, 13);
        }

    }
}
