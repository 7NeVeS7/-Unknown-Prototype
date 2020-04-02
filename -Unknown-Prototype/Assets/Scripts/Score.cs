using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public void SetScore(int score)
    {
        scoreText.text = score.ToString();
    }
}
