using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager _instance = null;

    [SerializeField] TextMeshProUGUI scoreText;
    public int score = 0;

    [SerializeField] AudioSource audio;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(_instance);
        }

        else
        {
            Destroy(_instance);
        }

        audio = GetComponent<AudioSource>();
    }

    private void Start()
    {
        UpdateScoreText();
        audio.Play();
    }

    private void Update()
    {
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = $"{score}";
    }

    public void AddScore(int point)
    {
        score += point;
        UpdateScoreText();
    }
}
