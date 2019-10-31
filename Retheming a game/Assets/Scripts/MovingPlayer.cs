using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovingPlayer : MonoBehaviour
{
    public float moveSpeed = 10f;

    void Start(){
        moveSpeed *= 1.5f;
    }

    void Update(){
        transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime);
    }
    
   
}
