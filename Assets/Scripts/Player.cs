using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Player: MonoBehaviour
{
    private float speed = 5;
    public Rigidbody2D rb;
    // Update is called once per frame
    void Update()
    {
        //How the player move
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        
    } 
}
