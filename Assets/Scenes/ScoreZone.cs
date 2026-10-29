using UnityEngine;
using TMPro;

public class ScoreZone : MonoBehaviour
{
    public TMP_Text scoreText;
    int score = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bird"))
        {
            score++;
            scoreText.text = score.ToString();
            gameObject.SetActive(false);
        }
    }
}