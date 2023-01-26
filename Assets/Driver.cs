using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    
    [SerializeField] float steertSpeed = 0.1f;
    [SerializeField] float moveSpeed= 15f;
    [SerializeField] float slowSpeed= 12f;
    [SerializeField] float boostSpeed= 21f;



    //Slow down when player bump to anything 
    void OnCollisionEnter2D(Collision2D other) 
    {
        moveSpeed = slowSpeed;
        
    }
     //Speed up when player past the yellow circle
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag=="Boost")
        {
            moveSpeed=boostSpeed;
        }

    }

    //Add inputs for car & fram rate independent 
    void Update()
    {
        float SteerAmount=Input.GetAxis("Horizontal")* steertSpeed * Time.deltaTime;
        float moveAmount=Input.GetAxis("Vertical")* moveSpeed * Time.deltaTime ;

        transform.Rotate(0,0,-SteerAmount);
        transform.Translate(0,moveAmount,0);
    }
}
