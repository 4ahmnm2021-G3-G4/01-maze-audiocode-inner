using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

   
    public float xAngle, yAngle, zAngle = 2f;
   // public float yPosition;

    void Update()
    {
     gameObject.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
    }
}
