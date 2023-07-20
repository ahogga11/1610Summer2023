using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;

    public float xRange = 8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Moves Player Left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector2.left * Time.deltaTime * speed);
        }

        // Moves Player Right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector2.right * Time.deltaTime * speed);
        }

        // Keep Player Within Set Bounds
        // Left Side Wall
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector2(-xRange, transform.position.y);
        }

        // Right Side Wall
        if (transform.position.x > xRange)
        {
            transform.position = new Vector2(xRange, transform.position.y);
        }
    }
}
