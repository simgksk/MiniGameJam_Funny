using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float moveSpeed = 5f;

    SpriteRenderer sprite;
    RectTransform rectTransform;

    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(1,0,0).normalized * moveSpeed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(-1, 0, 0).normalized * moveSpeed * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

}
