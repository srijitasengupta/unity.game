using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlock2 : MonoBehaviour
{

    Rigidbody2D rb;
    public float leftbound = 2f;
    public float rightbound = 14f;
    bool left;
    public float speed;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Move();

    }

    void Move()
    {
        if (left)
        {
            Vector2 temp = transform.position;
            temp.x = temp.x - speed * Time.deltaTime;
            transform.position = temp;
            if (transform.position.x < leftbound)
            {
                left = false;
            }
        }
        else
        {
            Vector2 temp = transform.position;
            temp.x = temp.x + speed * Time.deltaTime;
            transform.position = temp;
            if (transform.position.x > rightbound)
            {
                left = true;
            }

        }
    }
}
