using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text text;
    int score = 0;
    public void Start()
    {
        SetText();
    }


    public void GetScore()
    {
        score += 1;
        SetText();
    }
    public void SetText()
    {
        text.text = "Score : " + score.ToString();
    }
}
