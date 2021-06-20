using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatFoodTrigger : MonoBehaviour
{
    public GameObject catFood;
    public GameObject Coin2;
    public AudioSource Cat;
    
    public void OnTriggerEnter(Collider catcoll)
    {
       
        if (catcoll.gameObject.CompareTag("CatTrigger"))
        {
            Coin2.transform.position= new Vector3(7, 1, 11);
            catFood.transform.position = new Vector3(7, 5, 13);
            Cat.Stop();
        }

       

    }
}
