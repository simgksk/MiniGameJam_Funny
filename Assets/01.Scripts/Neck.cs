using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Neck : MonoBehaviour
{
    float fallSpeed = 5f;
    int rd;

    void Update()
    {
        Falling();
        RandomPoint();
    }

    private void Falling()
    {
        transform.position += Vector3.down * fallSpeed * Time.deltaTime;
    }
    
    private void RandomPoint()
    {
        rd = Random.Range(10, 100);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager._instance.AddScore(rd);
            Destroy(gameObject);
        }
        
        if (collision.CompareTag("Line"))
        {
            Debug.Log("Line");
            Destroy(gameObject);
        }
    }
}
