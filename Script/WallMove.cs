using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMove : MonoBehaviour
{
    public GameObject SW;
  public float speed;
    Vector3 destination = new Vector3 (0.59f, -4.89f, 5.07f);
    void Update(){
         SW.transform.position= Vector3.MoveTowards(SW.transform.position, destination,speed);
    }
}
   