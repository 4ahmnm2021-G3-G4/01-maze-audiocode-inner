using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
  public int collected;
  public int KeyAmount = 1;
  public GameObject door;

  void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.tag == "Coin")
    {
      collected = collected +1;  
      collision.gameObject.active = false;
      Debug.Log("Key touched Door");
    }
    if (collected == KeyAmount)
    {
      Debug.Log("Key eingesammelt");
      door.transform.rotation = Quaternion.Euler(new Vector3(0f, -90f ,0f));
    }
  }
}
