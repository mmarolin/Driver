using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float slowSpeed = 15f;
    [SerializeField] float boostSpeed = 30f;

    void Start()
    {

    }


    void Update()
    {

        float steerAmount = Input.GetAxis("Horizontal") * Time.deltaTime * steerSpeed;
        float moveAmount = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            Debug.Log("You've been boosted");
            moveSpeed = boostSpeed;


        }

        if (other.tag == "Bump")
        {
            Debug.Log("You've been slowed down!");
            moveSpeed = slowSpeed;
        }
    }



}
