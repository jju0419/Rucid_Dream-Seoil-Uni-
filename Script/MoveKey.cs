using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveKey : MonoBehaviour
{
Vector3 destination = new Vector3 (-5.65f, 0.963f, -0.4359999f);
    void Update()
    {
           transform.position= Vector3.MoveTowards(transform.position, destination,0.0001f);
    }
}
