using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOver : MonoBehaviour {
    [SerializeField] private float _FadeTime = 1f;
    [SerializeField] private Image _fadeImage;
    [SerializeField] private Color _FadeColor = Color.black;
    [SerializeField] private Color _ScoreTextolor = Color.white;
    [SerializeField] private TextMeshProUGUI _ScoreText;


	public void StartGameOver()
    {
        StartCoroutine(GameOverRoutine());
    }
    private IEnumerator GameOverRoutine()
    {
        float fadeTimer = 0f;
        while(fadeTimer < _FadeTime)
        {
            fadeTimer += Time.deltaTime;
            _fadeImage.color = Color.Lerp(Color.clear, _FadeColor, fadeTimer / _FadeTime);
            yield return new WaitForEndOfFrame();
        }
        //_ScoreText.text = "Final Score: " + ScoreManager.Instace.Score;
        fadeTimer = 0;
        while(fadeTimer < _FadeTime)
        {
            _ScoreText.color = Color.Lerp(Color.clear, _ScoreTextolor, fadeTimer / _FadeTime);
            fadeTimer += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
    }
}
