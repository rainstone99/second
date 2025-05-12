using Unity.VisualScripting.FullSerializer;
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
    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else if (Instance != null)
            Instance = null;
    }
}
