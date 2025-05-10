using UnityEngine;
using UnityEngine.UI;

public class ScoreAmount : MonoBehaviour
{
    public static ScoreAmount Instance;
    public Text ScoreText;

    public int score = 0;

    public void AddScore(int amount)
    {
        score += amount;
        SetText();
    }
    public void SetText()
    {
        ScoreText.text = "점수 : " + score.ToString();
    }
    void Awake() //이 부분 지피티 썼습니다...
    {
        if (Instance == null)
            Instance = this;
    }
}
