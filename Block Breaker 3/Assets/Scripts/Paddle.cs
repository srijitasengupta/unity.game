using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePos = Input.mousePosition.x / Screen.width * 16f;
        Vector2 paddlePos = new Vector2(transform.position.y, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePos, minX, maxX);
        transform.position = paddlePos;
    }
}
