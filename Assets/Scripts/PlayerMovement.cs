using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 7f,movement;


    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        float dx = Input.acceleration.x;
        transform.position += new Vector3(movement,0f,0f) * speed * Time.deltaTime;
        transform.position += new Vector3(dx,0f,0f) * speed * Time.deltaTime;
    }
}
