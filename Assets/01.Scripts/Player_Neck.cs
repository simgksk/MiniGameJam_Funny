using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Neck : MonoBehaviour
{
    RectTransform rectTransform;
    SpriteRenderer sprite;

    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Neck"))
        {
            sprite.size = new Vector2(0, 3);
        }
    }
}
