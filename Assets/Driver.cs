using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 200f;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float slowSpeed = 2.5f;
    [SerializeField] float boostSpeed = 10f;
    // Update is called once per frame
    void Update()
    {
        float steerHAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float steerVAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerHAmount);
        transform.Translate(0,steerVAmount,0);
    }
    void OnCollisionEnter2D(Collision2D other) {
        moveSpeed = slowSpeed;
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Boost"){
            Debug.Log("BOOST!");
            moveSpeed = boostSpeed;
        }
    }
}
