using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManage : MonoBehaviour {
    [SerializeField] private string ScoreTextAppend = "Score: ";
    [SerializeField] private TextMeshProUGUI _textFinal;

    private void Update()
    {
        _textFinal.text = ScoreTextAppend + ScoreManager.Instace.Score.ToString("00000");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            ScoreManager.Instace.AddScore(1);
        }
    }
}

