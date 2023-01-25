using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steertSpeed = 0.1f;
    [SerializeField] float moveSpeed= 0.01f;

    void Start()
    {
        
    }

     
    void Update()
    {
        float SteerAmount=Input.GetAxis("Horizontal")* steertSpeed;
        float moveAmount=Input.GetAxis("Vertical")* moveSpeed;

        transform.Rotate(0,0,-SteerAmount);
        transform.Translate(0,moveAmount,0);
    }
}
